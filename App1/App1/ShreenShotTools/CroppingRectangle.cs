using System;
using SkiaSharp;
using Xamarin.Forms;

namespace App1.ShreenShotTools
{
    public class CroppingRectangle
    {
        private SKRect _maxRect;             // generally the size of the bitmap
        private float? _aspectRatio;

        public SKRect Rect { set; get; }

        public SKPoint[] Corners
        {
            get
            {
                return new SKPoint[]
                {
                new SKPoint(Rect.Left, Rect.Top),
                new SKPoint(Rect.Right, Rect.Top),
                new SKPoint(Rect.Right, Rect.Bottom),
                new SKPoint(Rect.Left, Rect.Bottom)
                };
            }
        }

        public CroppingRectangle(SKRect maxRect, float? aspectRatio = null)
        {
            this._maxRect = maxRect;
            this._aspectRatio = aspectRatio;

            // Set initial cropping rectangle
            Rect = new SKRect(0.9f * maxRect.Left + 0.1f * maxRect.Right,
                                0.9f * maxRect.Top + 0.1f * maxRect.Bottom,
                                0.1f * maxRect.Left + 0.9f * maxRect.Right,
                                0.1f * maxRect.Top + 0.9f * maxRect.Bottom);

            // Adjust for aspect ratio
            if (aspectRatio.HasValue)
            {
                SKRect rect = Rect;
                float aspect = aspectRatio.Value;

                if (rect.Width > aspect * rect.Height)
                {
                    float width = aspect * rect.Height;
                    rect.Left = (maxRect.Width - width) / 2;
                    rect.Right = rect.Left + width;
                }
                else
                {
                    float height = rect.Width / aspect;
                    rect.Top = (maxRect.Height - height) / 2;
                    rect.Bottom = rect.Top + height;
                }

                Rect = rect;
            }
        }



    }
}
