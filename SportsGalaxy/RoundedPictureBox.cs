using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PastYear
{
    public class CirclePictureBox : PictureBox
    {
        private Color _borderColor = Color.FromArgb(41, 128, 185); // Default border color (blue)
        private int _borderThickness = 2; // Default border thickness
        public CirclePictureBox()
        {
            // Forces the image to scale nicely inside the circle bounds
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a graphics path that shapes a perfect circle matching the control size
            using (GraphicsPath path = new GraphicsPath())
            {
                // Add an ellipse that spans the exact width and height of the PictureBox
                path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);

                // Set the control's region to this circle path (clips the actual control canvas)
                this.Region = new Region(path);

                // Smooth out the pixels around the circular border edge (Anti-aliasing)
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Let the base winforms class draw the image inside our newly clipped region
                base.OnPaint(pe);

                // Optional: Draw a subtle accent border around your rounded logo
                using (Pen borderPen = new Pen(Color.FromArgb(41, 128, 185), 2)) // Change color to your brand accent
                {
                    pe.Graphics.DrawEllipse(borderPen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        // Force the control to stay perfectly square whenever it's resized in the designer
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.Width != this.Height)
            {
                this.Height = this.Width;
            }
        }
    }
}