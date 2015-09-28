using CustomControls.Controls;
using CustomControls.iOS.Controls;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(RoundFrame), typeof(RoundFrameRenderer))]

namespace CustomControls.iOS.Controls
{
    public class RoundFrameRenderer : FrameRenderer
    {
        public override void Draw(System.Drawing.RectangleF rect)
        {
            var frame = (RoundFrame)Element;

            using (var context = UIGraphics.GetCurrentContext())
            {
                context.SetFillColor(frame.FillColor.ToCGColor()); 
                var radius = GetBorderRadius(frame);
                var path = CGPath.FromRoundedRect(this.Bounds, radius, radius);
                context.AddPath(path);
                context.DrawPath(CGPathDrawingMode.Fill);
            }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            var frame = (RoundFrame)Element;
            Element.BackgroundColor = Color.Transparent;
        }

        private static float GetBorderRadius(RoundFrame frame)
        {
            var radius = (float)frame.BorderRadius;
            radius = Math.Max(0, Math.Min(radius, GetShortestDimension(frame) /2));
            return radius;
        }

        private static float GetShortestDimension(RoundFrame frame)
        {
            return Math.Min((float)frame.Height, (float)frame.Width);
        }
    }
}