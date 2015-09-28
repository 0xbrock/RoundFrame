using Xamarin.Forms;

namespace CustomControls.Controls
{
    public class RoundFrame : Frame
    {
        public static readonly BindableProperty BorderRadiusProperty = BindableProperty.Create<RoundFrame, double>(l => l.BorderRadius, default(double));

        /// <summary>
        /// The radius of the corner, in pixels.
        /// Minimum Value: 0
        /// Maximum Value: Half the Frame's Height/Width, whichever is smaller.
        /// If the value is outside of the range, the closest extreme will be used when rendering.
        /// </summary>
        public double BorderRadius
        {
            get { return (double)base.GetValue(BorderRadiusProperty); }
            set { base.SetValue(BorderRadiusProperty, value); }
        }

        public static readonly BindableProperty FillColorProperty = BindableProperty.Create<RoundFrame, Color>(l => l.FillColor, default(Color));

        /// <summary>
        /// The fill color for the frame.  
        /// Use this instead of Background color as Background color will not respect the rounded corners.
        /// </summary>
        public Color FillColor
        {
            get { return (Color)base.GetValue(FillColorProperty); }
            set { base.SetValue(FillColorProperty, value); }
        }
    }
}
