using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PastYear
{
    public class CustomPanel : Panel
    {
        // Customizable properties that appear in the Visual Studio Designer
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.DeepSkyBlue;
        public int BorderThickness { get; set; } = 2;

        public CustomPanel()
        {
            this.DoubleBuffered = true; // Prevents UI flickering during resize
            this.BackColor = Color.White;
        }

        // We override the paint method to draw rounded corners and custom borders
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Makes the curves perfectly smooth

            // Create a path with rounded rectangles
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius);

            // Clip the panel region so controls inside don't bleed past the rounded corners
            this.Region = new Region(path);

            // Draw the custom background color
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillPath(brush, path);
            }

            // Draw the custom border
            if (BorderThickness > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    pen.Alignment = PenAlignment.Inset; // Keeps border inside panel boundaries
                    g.DrawPath(pen, path);
                }
            }
        }

        // Helper method to calculate the curved geometry corners
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-Left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-Right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-Right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-Left
            path.CloseFigure();

            return path;
        }
    }
}