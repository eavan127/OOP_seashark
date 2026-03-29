using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_GroupProject
{
    public class OutlineLabel : Label
    {
        [Browsable(true)]
        [Category("Appearance")]
        [Description("The color of the outline.")]
        public Color OutlineColor { get; set; } = Color.White;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The width of the outline.")]
        public float OutlineWidth { get; set; } = 2f;

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var outline = new System.Drawing.Drawing2D.GraphicsPath())
            using (var format = new StringFormat())
            {
                format.Alignment = StringAlignmentFromContentAlignment(TextAlign);
                format.LineAlignment = LineAlignmentFromContentAlignment(TextAlign);

                outline.AddString(
                    Text,
                    Font.FontFamily,
                    (int)Font.Style,
                    e.Graphics.DpiY * Font.Size / 72,
                    ClientRectangle,
                    format
                );

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (var pen = new Pen(OutlineColor, OutlineWidth) { LineJoin = System.Drawing.Drawing2D.LineJoin.Round })
                {
                    e.Graphics.DrawPath(pen, outline);
                }

                using (var brush = new SolidBrush(ForeColor))
                {
                    e.Graphics.FillPath(brush, outline);
                }
            }
        }

        private static StringAlignment StringAlignmentFromContentAlignment(ContentAlignment align)
        {
            switch (align)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    return StringAlignment.Near;
                case ContentAlignment.TopCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.BottomCenter:
                    return StringAlignment.Center;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    return StringAlignment.Far;
                default:
                    return StringAlignment.Near;
            }
        }

        private static StringAlignment LineAlignmentFromContentAlignment(ContentAlignment align)
        {
            switch (align)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    return StringAlignment.Near;
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    return StringAlignment.Center;
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    return StringAlignment.Far;
                default:
                    return StringAlignment.Near;
            }
        }
    }
}