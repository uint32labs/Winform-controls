using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dio
{
    public class DioButton : Button
    {
        private readonly Color _downOverlay = Color.FromArgb(70, 0, 0, 0);
        private readonly Color _hoverOverlay = Color.FromArgb(45, 35, 35, 35);
        private Color _overlapColor = Color.FromArgb(0, 0, 0, 0);

        public DioButton()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            ShadowSize = 4;
            ShadowColor = DioDefaults.DioDefaultshadowColor;
            BackColor = DioDefaults.DefaultBackColor;
            ForeColor = DioDefaults.DefaultForeColor;
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
            using (Pen borderPen = new Pen(BorderColor))
            {
                Rectangle clippedBounds = new Rectangle(-1, -1, Width + 2, Height + 2 - ShadowSize);
                g.SetClip(new Rectangle(0, 0, Width, Height - ShadowSize + 1));
                g.FillRectangle(backColorBrush, clippedBounds);
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - ShadowSize);
                g.FillRectangle(overlayBrush, clippedBounds);
                SizeF stringSize = g.MeasureString(Text, Font);
                PointF textPosition = new PointF(0, 0);
                if (TextAlign == ContentAlignment.MiddleCenter)
                    textPosition = new PointF((Width - stringSize.Width) / 2,
                        (Height - stringSize.Height - ShadowSize) / 2);
                else if (TextAlign == ContentAlignment.MiddleLeft)
                    textPosition = new PointF(3, (Height - stringSize.Height - ShadowSize) / 2);
                else if (TextAlign == ContentAlignment.MiddleRight)
                    textPosition = new PointF(Width - 4 - stringSize.Width,
                        (Height - stringSize.Height - ShadowSize) / 2);
                else
                    throw new NotImplementedException();
                g.DrawString(Text, Font, foreColorBrush, textPosition);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _overlapColor = _hoverOverlay;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _overlapColor = _hoverOverlay;
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _overlapColor = Color.FromArgb(0, 0, 0, 0);
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _overlapColor = _downOverlay;
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            _overlapColor = _hoverOverlay;
            Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            _overlapColor = Color.FromArgb(0, 0, 0, 0);
            Invalidate();
            base.OnLostFocus(e);
        }

        protected override void OnKeyDown(KeyEventArgs kevent)
        {
            //Enter does not fire keydown
            if (kevent.KeyCode == Keys.Space)
                _overlapColor = _downOverlay;
            Invalidate();
            base.OnKeyDown(kevent);
        }

        protected override void OnKeyUp(KeyEventArgs kevent)
        {
            if (kevent.KeyCode == Keys.Space)
                _overlapColor = _hoverOverlay;
            base.OnKeyUp(kevent);
        }
    }
}