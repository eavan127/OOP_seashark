using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyApp.Controls;

public class OutlineLabel : Label
{
    public class OutlineLabel : Label
    {
        this.AutoSize = false;  
        this.BackColor = Color.Transparent;
    }

        public OutlineLabel()
        {
            using (StringFormat sf = new StringFormat())
            {
                if (this.TextAlign == ContentAlignment.MiddleCenter)
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                }
                else if (this.TextAlign == ContentAlignment.MiddleLeft)
                {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                }
                else if (this.TextAlign == ContentAlignment.MiddleRight)
                {
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Center;
                }

                float emSize = e.Graphics.DpiY * this.Font.Size / 72f;

                path.AddString(
                    this.Text ?? string.Empty,
                    this.Font.FontFamily,
                    (int)this.Font.Style,
                    emSize,
                    this.ClientRectangle,
                    sf
                );
            }

            using (Pen outlinePen = new Pen(this.OutlineColor, this.OutlineWidth) { LineJoin = LineJoin.Round })
            {
                e.Graphics.DrawPath(outlinePen, path);
            }

                if (this.TextAlign == ContentAlignment.MiddleCenter)
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                }
                else if (this.TextAlign == ContentAlignment.MiddleLeft)
                {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                }
                else if (this.TextAlign == ContentAlignment.MiddleRight)
                {
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Center;
                }

                float emSize = e.Graphics.DpiY * this.Font.Size / 72;

                path.AddString(
                    this.Text,
                    this.Font.FontFamily,
                    (int)this.Font.Style,
                    emSize,
                    this.ClientRectangle,
                    sf
                );

                using (Pen outlinePen = new Pen(OutlineColor, OutlineWidth)
                {
                    LineJoin = LineJoin.Round
                })
                {
                    e.Graphics.DrawPath(outlinePen, path);
                }

                using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.FillPath(textBrush, path);
                }
            }
        }
    }
}