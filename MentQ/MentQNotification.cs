using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQNotification : Control
    {
        public enum TextAlign
        {
            Left,
            Center
        }

        private Color _effectColor;
        private Styles _style;

        public MentQNotification()
        {
            UnderlineSize = 2;
            BackColor = MentQDefaults.MentQBlue;
            Font = new Font("Verdana", 7);
            ForeColor = Color.White;
            Size = new Size(60, 15);
            Style = Styles.None;
            EffectColor = Color.FromArgb(120, 65, 65, 65);
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw, true);
            TextAlignment = TextAlign.Center;
        }

        [Category("Appearance")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Styles Style
        {
            get { return _style; }
            set
            {
                _style = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color EffectColor
        {
            get { return _effectColor; }
            set
            {
                _effectColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")] public int UnderlineSize { get; set; }

        [Category("Appearance")] public TextAlign TextAlignment { get; set; }


        protected override void OnPaint(PaintEventArgs e)
        {
            int y = Style == Styles.Underlined ? -UnderlineSize + 1 : 0;
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(Parent.BackColor);
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                if (Style == Styles.Outlined)
                {
                    G.FillPath(brush, GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 5));
                    using (Pen outlinePen = new Pen(EffectColor))
                    {
                        G.DrawPath(outlinePen,
                            GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 5));
                    }
                }
                else if (Style == Styles.Underlined)
                {
                    using (SolidBrush darkBrush = new SolidBrush(EffectColor))
                    {
                        G.FillPath(darkBrush,
                            GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height + 1), 5));
                    }

                    G.SetClip(new Rectangle(0, 0, Width, Height - UnderlineSize));
                    G.FillPath(brush,
                        GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height - UnderlineSize + 1), 5));
                }
                else
                {
                    G.FillPath(brush, GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height + 1), 5));
                }
            }

            if (!string.IsNullOrEmpty(Text))

                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                {
                    if (TextAlignment == TextAlign.Center)
                        G.DrawString(Text, Font, textBrush, (Width - G.MeasureString(Text, Font).Width) / 2,
                            (Height - G.MeasureString(Text, Font).Height) / 2 + y);
                    if (TextAlignment == TextAlign.Left)
                        G.DrawString(Text, Font, textBrush, 4, (Height - G.MeasureString(Text, Font).Height) / 2 + y);
                }

            base.OnPaint(e);
        }
    }
}