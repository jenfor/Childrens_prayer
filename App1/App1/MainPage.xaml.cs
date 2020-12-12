using SkiaSharp;
using SkiaSharp.HarfBuzz;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using System.IO;
using TouchTracking;
using System.Reflection;
using App1.ViewModels;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Linq;

namespace App1
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Dictionary<long, SKPath> _inProgressPaths = new Dictionary<long, SKPath>();
        private List<SKPath> _completedPaths = new List<SKPath>();
        private SKBitmap _saveBitmap;
        private MainPageViewModel _vm;
        private Locale _locale;

        public SKPaint paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColors.Salmon,
            StrokeWidth = 10,
            StrokeCap = SKStrokeCap.Round,
            StrokeJoin = SKStrokeJoin.Round
        };

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _vm = new MainPageViewModel();
        }

        public void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            switch (args.Type)
            {
                case TouchActionType.Pressed:
                    if (!_inProgressPaths.ContainsKey(args.Id))
                    {
                        SKPath path = new SKPath();
                        path.MoveTo(ConvertToPixel(args.Location));
                        _inProgressPaths.Add(args.Id, path);
                        UpdateBitmap();
                    }
                    break;

                case TouchActionType.Moved:
                    if (_inProgressPaths.ContainsKey(args.Id))
                    {
                        SKPath path = _inProgressPaths[args.Id];
                        path.LineTo(ConvertToPixel(args.Location));
                        UpdateBitmap();
                    }

                    break;

                case TouchActionType.Released:
                    if (_inProgressPaths.ContainsKey(args.Id))
                    {
                        _completedPaths.Add(_inProgressPaths[args.Id]);
                        _inProgressPaths.Remove(args.Id);
                        UpdateBitmap();
                    }
                    break;

                case TouchActionType.Cancelled:
                    if (_inProgressPaths.ContainsKey(args.Id))
                    {
                        _inProgressPaths.Remove(args.Id);
                        UpdateBitmap();
                    }
                    break;
            }
        }

        private SKPoint ConvertToPixel(TouchTrackingPoint pt)
        {
            return new SKPoint((float)(canvasView.CanvasSize.Width * pt.X / canvasView.Width),
                               (float)(canvasView.CanvasSize.Height * pt.Y / canvasView.Height));
        }

        public void UpdateBitmap()
        {
            if (_saveBitmap != null)
            {
                using (SKCanvas saveBitmapCanvas = new SKCanvas(_saveBitmap))
                {
                    saveBitmapCanvas.Clear();

                    foreach (SKPath path in _completedPaths)
                    {
                        saveBitmapCanvas.DrawPath(path, paint);
                    }

                    foreach (SKPath path in _inProgressPaths.Values)
                    {
                        saveBitmapCanvas.DrawPath(path, paint);
                    }
                }
                canvasView.InvalidateSurface();
            }
        }

        public void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            try
            {
                SKImageInfo info = args.Info;
                SKSurface surface = args.Surface;
                SKCanvas canvas = surface.Canvas;
                Assembly assembly = GetType().GetTypeInfo().Assembly;

                if (_saveBitmap == null)
                {
                    _saveBitmap = new SKBitmap(info.Width, info.Height);
                }

                SKBitmap bitmap = new SKBitmap(Math.Max(_saveBitmap.Width, info.Width),
                            Math.Max(_saveBitmap.Height, info.Height));

                float x = info.Width / 3;
                float y = (float)(info.Height / 1.5);

                using (SKCanvas c = new SKCanvas(bitmap))
                {
                    foreach (SKPath p in _completedPaths)
                    {
                        c.DrawPath(p, paint);
                    }

                    foreach (SKPath p in _inProgressPaths.Values)
                    {
                        c.DrawPath(p, paint);
                    }
                }

                canvas.Clear();
                canvas.DrawBitmap(bitmap, 0, 0);

                var emoji = _vm.Image;
                int exEmoji = 0x1f600;

                paint.Typeface = SKFontManager.CreateDefault().MatchCharacter(exEmoji);
                paint.TextSize = 210.0f;

                var tf = SKFontManager.CreateDefault().MatchCharacter(exEmoji);
                var shaper = new SKShaper(tf);
                canvas.DrawShapedText(shaper, emoji, x, y, paint);
            }
            catch { }
        }

        public void OnClearButtonClicked(object sender, EventArgs args)
        {
            _completedPaths.Clear();
            _inProgressPaths.Clear();
            UpdateBitmap();
            canvasView.InvalidateSurface();
        }

        public /*async*/ void OnSaveButtonClicked(object sender, EventArgs args)
        {
            using (SKImage image = SKImage.FromBitmap(_saveBitmap))
            {
                SKData data = image.Encode();
                DateTime dt = DateTime.Now;
                string filename = String.Format("FingerPaint-{0:D4}{1:D2}{2:D2}-{3:D2}{4:D2}{5:D2}{6:D3}.png",
                                                dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);


                /*IPhotoLibrary photoLibrary = DependencyService.Get<IPhotoLibrary>();
                bool result = await photoLibrary.SavePhotoAsync(data.ToArray(), "FingerPaint", filename);

                if (!result)
                {
                    await DisplayAlert("FingerPaint", "Artwork could not be saved. Sorry!", "OK");

                }*/

            }
        }

        void NewPage_Clicked(System.Object sender, System.EventArgs e)
        {
            SetLocale();
            if (_saveBitmap != null)
            {
                _completedPaths.Clear();
                _inProgressPaths.Clear();
                UpdateBitmap();
                canvasView.InvalidateSurface();

                SKBitmap bitmap = new SKBitmap((int)Math.Max(_saveBitmap.Width, canvasView.CanvasSize.Width),
                (int)Math.Max(_saveBitmap.Height, canvasView.CanvasSize.Height));

                if (_vm.ScreenShot != null)
                {
                    using (Stream stream = new MemoryStream((byte[])_vm.ScreenShot))
                    {
                        bitmap = SKBitmap.Decode(stream);
                    }

                    using (SKCanvas c = new SKCanvas(bitmap))
                    {
                        foreach (SKPath p in _completedPaths)
                        {
                            c.DrawPath(p, paint);
                        }

                        foreach (SKPath p in _inProgressPaths.Values)
                        {
                            c.DrawPath(p, paint);
                        }
                    }
                }
            }
        }

        private async void SetLocale()
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            _locale = locales.FirstOrDefault(x => x.Language.Equals("en-US"));

            if (_vm.Read.Equals("Läs"))
            {
                _locale = locales.FirstOrDefault(x => x.Language.Equals("sv-SE"));
            }

            if(_locale == null)
            {
                readButton.IsVisible = false;
            }
            else
            {
                readButton.IsVisible = true;
            }
        }

        async void Read_Clicked(System.Object sender, System.EventArgs e)
        {
            if (_locale != null)
            {
                var settings = new SpeechOptions()
                {
                    Locale = _locale
                };

                await TextToSpeech.SpeakAsync(_vm.Text, settings);
            }
        }
    }
}
