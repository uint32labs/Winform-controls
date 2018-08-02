using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dio
{
    public class DioTextBox : Control
    {
        private Color _overlapColor = Color.FromArgb(0, 0, 0, 0);

        public DioTextBox()
        {
            Size = new Size(150, 22);
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
            ForeColor = DioDefaults.DefaultDarkForeColor;
            BorderColor = DioDefaults.DefaultBackColor;
            Font = DioDefaults.DefaultFont;
            InitialBorderColor = DioDefaults.DefaultBorderColor;
            _overlapColor = InitialBorderColor;
            if (this.InlineTextBox == null)
                this.InlineTextBox = new TextBox();

            this.InlineTextBox.BorderStyle = BorderStyle.None;
            this.InlineTextBox.Location = new Point(3, 4);
            this.InlineTextBox.GotFocus += (sender, args) => OnGotFocus(args);
            this.InlineTextBox.LostFocus += (sender, args) => OnLostFocus(args);
            this.InlineTextBox.MouseDown += (sender, args) => OnMouseDown(args);
            this.InlineTextBox.MouseLeave += (sender, args) => OnMouseLeave(args);
            this.InlineTextBox.MouseEnter += (sender, args) => OnMouseEnter(args);
            this.InlineTextBox.Multiline = Multiline;
            this.InlineTextBox.MultilineChanged += (sender, args) =>
            {
                OnSizeChanged(args);
                Multiline = this.InlineTextBox.Multiline;
            };
            this.InlineTextBox.TextChanged += (sender, args) => Text = this.InlineTextBox.Text;
            this.InlineTextBox.BackColor = BackColor;
            this.InlineTextBox.ForeColor = ForeColor;
            HandleCreated += (sender, args) => { DoubleBuffered = true; };
            Controls.Add(this.InlineTextBox);
            BackColorChanged += (sender, args) => this.InlineTextBox.BackColor = BackColor;
            ForeColorChanged += (sender, args) => this.InlineTextBox.ForeColor = ForeColor;
        }

        //[Browsable(false)]
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //[Bindable(true)]
        public TextBox InlineTextBox { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Color BorderColor { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Color InitialBorderColor { get; set; }

        public bool Multiline { get; set; }

        public new Size Size
        {
            get { return base.Size; }
            set
            {
                base.Size = value;
                if (this.InlineTextBox != null) this.InlineTextBox.Size = new Size(base.Size.Width - 6, base.Size.Height - 6);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.Clear(Parent.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (SolidBrush backColorBrush = new SolidBrush(BackColor))
            using (Pen borderPen = new Pen(_overlapColor))
            {
                g.FillRectangle(backColorBrush, -1, -1, Width + 1, Height + 1);
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!this.InlineTextBox.Focused)
            {
                _overlapColor = Color.FromArgb(175, BorderColor);
                Invalidate();
                base.OnMouseEnter(e);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!this.InlineTextBox.Focused)
            {
                _overlapColor = InitialBorderColor;
                Invalidate();
                base.OnMouseLeave(e);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _overlapColor = BorderColor;
            Invalidate();
            if (!this.InlineTextBox.Focused)
                this.InlineTextBox.Focus();
            base.OnMouseDown(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (this.InlineTextBox.Multiline)
            {
                this.InlineTextBox.Size = new Size(Size.Width - 6, Size.Height - 6);
                this.InlineTextBox.Text = Text;
            }

            base.OnHandleCreated(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            _overlapColor = BorderColor;
            Invalidate();
            if (!this.InlineTextBox.Focused)
                this.InlineTextBox.Focus();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            _overlapColor = InitialBorderColor;
            Invalidate();
            base.OnLostFocus(e);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (Multiline)
                base.SetBoundsCore(x, y, width, height, specified);
            else
                base.SetBoundsCore(x, y, width, 22, specified);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.InlineTextBox != null)
                if (this.InlineTextBox.Multiline)
                    this.InlineTextBox.Size = new Size(Size.Width - 6, Size.Height - 6);
                else
                    this.InlineTextBox.Size = new Size(Size.Width - 6, this.InlineTextBox.Height);
            base.OnSizeChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            this.InlineTextBox.Text = Text;
            Invalidate();
            base.OnTextChanged(e);
        }
    }
}