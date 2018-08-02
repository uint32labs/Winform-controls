using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQEllipticalProgress : ProgressBar
    {
        private Color _hatchBrushColor;
        private HatchStyle _hatchBrushStyle;
        private bool _useHatchBrush;


        public MentQEllipticalProgress()
        {
            Size = new Size(70, 70);
            BackColor = MentQDefaults.MentQBlue;
            ForeColor = Color.Black;
            DoubleBuffered = true;
            SetStyle(
                ControlStyles.CacheText | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Font = new Font("Verdana", 8);
            HatchBrushStyle = HatchStyle.DarkDownwardDiagonal;
            HatchBrushSecondaryColor = Color.FromArgb(30, 200, 200, 200);
            UseHatchBrush = false;
            Text = "Percent";
        }

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

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        [Category("Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }

        [Category("Appearance")]
        public HatchStyle HatchBrushStyle
        {
            get { return _hatchBrushStyle; }
            set
            {
                _hatchBrushStyle = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color HatchBrushSecondaryColor
        {
            get { return _hatchBrushColor; }
            set
            {
                _hatchBrushColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public bool UseHatchBrush
        {
            get { return _useHatchBrush; }
            set
            {
                _useHatchBrush = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(Parent.BackColor);
            if (UseHatchBrush)
                using (HatchBrush backColorBrush = new HatchBrush(HatchBrushStyle, HatchBrushSecondaryColor, BackColor))
                {
                    G.FillPie(backColorBrush, 0, 0, Width - 1, Height - 1, 270, (int) (360 / (float) Maximum * Value));
                }
            else
                using (SolidBrush backColorBrush = new SolidBrush(BackColor))
                {
                    G.FillPie(backColorBrush, 0, 0, Width - 1, Height - 1, 270, (int) (360 / (float) Maximum * Value));
                }

            using (SolidBrush backBrush = new SolidBrush(Color.FromArgb(25, 45, 45, 54)))
            {
                G.FillEllipse(backBrush, 0, 0, Width - 1, Height - 1);
            }

            using (SolidBrush parentBrush = new SolidBrush(Parent.BackColor))
            {
                G.FillEllipse(parentBrush, 4, 4, Width - 9, Height - 9);
            }

            using (SolidBrush foreColorBrush = new SolidBrush(ForeColor))
            {
                G.DrawString(Value.ToString(), Font, foreColorBrush,
                    (Width - G.MeasureString(Value.ToString(), Font).Width) / 2,
                    (Height - G.MeasureString(Value.ToString(), Font).Height) / 2 -
                    (string.IsNullOrEmpty(Text) ? 0 : 2));
                if (!string.IsNullOrEmpty(Text))
                    using (SolidBrush titleBrush = new SolidBrush(Color.FromArgb(150, ForeColor)))
                    using (Font titleFont = new Font("Segoe UI", 6, FontStyle.Bold))
                    {
                        G.DrawString(Text.ToUpper(), titleFont, titleBrush,
                            (Width - G.MeasureString(Text.ToUpper(), titleFont).Width) / 2,
                            (Height - G.MeasureString(Text.ToUpper(), titleFont).Height) / 2 + 10);
                    }
            }

            base.OnPaint(e);
        }
    }
}