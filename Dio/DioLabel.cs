using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dio
{
    public class DioLabel : Label
    {

        public DioLabel()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            Font = new Font(DioDefaults.DefaultFont.FontFamily, 14);
            BackColor = DioDefaults.DefaultBackColor;
            ForeColor = DioDefaults.DefaultDarkForeColor;
            TitleFont = DioDefaults.DefaultFont;
            DrawSide = true;
            HandleCreated += (sender, args) => { DoubleBuffered = true; };
        }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public string Title { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Font TitleFont { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public bool DrawSide { get; set; }

        public override bool AutoSize
        {
            get { return false; }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.Clear(Parent.BackColor);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (
                SolidBrush backColorBrush = new SolidBrush(BackColor),
                foreColorBrush = new SolidBrush(ForeColor))
            {
                int decal = 0;
                if (DrawSide)
                {
                    g.FillRectangle(backColorBrush, 0, 0, 4, Height);
                    decal = 8;
                }
                else
                {
                    decal = 0;
                }

                SizeF titleSize = new SizeF(0, 0);
                if (!string.IsNullOrEmpty(Title))
                {
                    titleSize = g.MeasureString(Title, TitleFont);
                    g.DrawString(Title, TitleFont, foreColorBrush, decal, 0);
                }

                SizeF textSize = g.MeasureString(Text, Font);
                g.DrawString(Text, Font, foreColorBrush, decal,
                    (Height - textSize.Height - titleSize.Height) / 2 + titleSize.Height);
            }
        }
    }
}