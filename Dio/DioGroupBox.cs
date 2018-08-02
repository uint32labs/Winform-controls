using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dio
{
    public class DioGroupBox : GroupBox
    {
        private readonly Color _overlapColor = Color.FromArgb(0, 0, 0, 0);

        public DioGroupBox()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            ShadowSize = 4;
            BackColor = Color.White;
            ForeColor = DioDefaults.DefaultDarkForeColor;
            ShadowColor = DioDefaults.DioDefaultshadowColor;
            Font = DioDefaults.DefaultFont;
            HandleCreated += (sender, args) => { DoubleBuffered = true; };
        }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public int ShadowSize { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Color ShadowColor { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Color BorderColor { get; set; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.Clear(Parent.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            if (ShadowSize > 0)
                GlobalHelpers.DrawDownFade(g, new Rectangle(-1, Height - ShadowSize, Width + 1, ShadowSize),
                    ShadowColor);
            using (
                SolidBrush backColorBrush = new SolidBrush(BackColor),
                foreColorBrush = new SolidBrush(ForeColor),
                overlayBrush = new SolidBrush(_overlapColor))
            using (Pen borderPen = new Pen(BorderColor), foreColorPen = new Pen(ForeColor))
            {
                Rectangle clippedBounds = new Rectangle(-1, -1, Width + 2, Height + 2 - ShadowSize);
                g.SetClip(new Rectangle(0, 0, Width, Height - ShadowSize + 1));
                g.FillRectangle(backColorBrush, clippedBounds);
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - ShadowSize);
                g.FillRectangle(overlayBrush, clippedBounds);
                g.DrawString(Text, Font, foreColorBrush, 10, 7);
                SizeF stringSize = g.MeasureString(Text, Font);
                g.DrawLine(foreColorPen, 10, stringSize.Height + 9, stringSize.Width + 10, stringSize.Height + 9);
            }
        }
    }
}