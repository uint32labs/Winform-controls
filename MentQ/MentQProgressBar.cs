using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQProgressBar : ProgressBar
    {
        private Color _alternateForeColor;
        private bool _underline;
        private Color _underlineColor;
        private int _underlineSize;


        public MentQProgressBar()
        {
            InactiveBackColor = Color.FromArgb(150, 200, 200, 200);
            CornerRounding = 5;
            Size = new Size(170, 20);
            UnderlineSize = 2;
            UnderlineColor = Color.FromArgb(100, 70, 70, 70);
            BackColor = MentQDefaults.MentQBlue;
            ForeColor = Color.White;
            DoubleBuffered = true;
            SetStyle(
                ControlStyles.CacheText | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Font = new Font("Segoe UI", 7);
            AlternateForeColor = Color.FromArgb(40, 40, 40);
        }


        [Category("Appearance")] public bool DiagonalLines { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
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
        public Color AlternateForeColor
        {
            get { return _alternateForeColor; }
            set
            {
                _alternateForeColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public bool Underline
        {
            get { return _underline; }
            set
            {
                _underline = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public int UnderlineSize
        {
            get { return _underlineSize; }
            set
            {
                _underlineSize = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color UnderlineColor
        {
            get { return _underlineColor; }
            set
            {
                _underlineColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")] public int CornerRounding { get; set; }

        [Category("Appearance")] public Color InactiveBackColor { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        [Category("Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            //Get the region of the colored part
            float percent = (float) Width / Maximum * Value;

            //Transparent background effect
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;

            //Set clipping to reduce anti aliasing
            G.SetClip(new RectangleF(0, 0, Width, Height));

            //Create the background brush
            using (SolidBrush inactiveBackColorBrush = new SolidBrush(InactiveBackColor))

                //Draw the background
            {
                G.FillPath(inactiveBackColorBrush,
                    GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), CornerRounding));
                G.SetClip(new Rectangle(0, 0, Convert.ToInt32(percent), Height));
                using (SolidBrush backColorBrush = new SolidBrush(BackColor))
                {
                    G.FillPath(backColorBrush,
                        GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, percent + 1, Height + 1), CornerRounding));
                }

                if (Underline)
                    using (SolidBrush underlineBrush = new SolidBrush(UnderlineColor))
                    {
                        G.SetClip(new Rectangle(0, Height - UnderlineSize, Convert.ToInt32(percent), UnderlineSize));
                        G.FillPath(underlineBrush,
                            GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, percent + 1, Height + 1),
                                CornerRounding));
                    }
            }


            using (SolidBrush foreColorBrush = new SolidBrush(ForeColor))
            using (SolidBrush alternateForeColorBrush = new SolidBrush(AlternateForeColor))
            {
                G.SetClip(new Rectangle(0, 0, Convert.ToInt32(percent), Height));

                G.DrawString(Text, Font, foreColorBrush, 5,
                    (Height - G.MeasureString(Text, Font).Height) / 2);
                G.SetClip(new Rectangle(Convert.ToInt32(percent), 0, Width, Height));
                G.DrawString(Text, Font, alternateForeColorBrush, 5,
                    (Height - G.MeasureString(Text, Font).Height) / 2);
            }


            if (!Enabled)
                using (SolidBrush disabledBrush = new SolidBrush(Color.FromArgb(100, 222, 222, 222)))
                {
                    G.FillPath(disabledBrush,
                        GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), CornerRounding));
                }

            G.ResetClip();
            base.OnPaint(e);
        }
    }
}