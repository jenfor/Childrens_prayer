using System;
using System.IO;
using Android.App;
using Android.Graphics;
using App1.Droid;
using App1.Interfaces;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(ScreenshotService))]
namespace App1.Droid
{
    public class ScreenshotService : IScreenshotService
    {
        private Activity _currentActivity = Platform.CurrentActivity;

        public byte[] Capture()
        {
            var rootView = _currentActivity.Window.DecorView.RootView;

            using (var screenshot = Bitmap.CreateBitmap(
                                    rootView.Width,
                                    rootView.Height,
                                    Bitmap.Config.Argb8888))
            {
                var canvas = new Canvas(screenshot);
                rootView.Draw(canvas);

                using (var stream = new MemoryStream())
                {
                    screenshot.Compress(Bitmap.CompressFormat.Png, 90, stream);
                    return stream.ToArray();
                }
            }
        }


    }
}
