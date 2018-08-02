using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dio
{
    public class DioRadioButton : RadioButton
    {
        private readonly Color _downOverlay = Color.FromArgb(70, 0, 0, 0);
        private readonly Color _hoverOverlay = Color.FromArgb(45, 35, 35, 35);
        private Color _overlapColor = Color.FromArgb(0, 0, 0, 0);

        public DioRadioButton()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            BackColor = DioDefaults.DefaultBackColor;
            ForeColor = DioDefaults.DefaultDarkForeColor;
            Font = DioDefaults.DefaultFont;
            HandleCreated += (sender, args) => { DoubleBuffered = true; };
            AutoSize = true;
        }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Color BorderColor { get; set; }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(18 + Convert.ToInt32(Graphics.FromHwnd(Handle).MeasureString(Text, Font).Width), 15);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.Clear(Parent.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (
                SolidBrush backColorBrush = new SolidBrush(BackColor),
                foreColorBrush = new SolidBrush(ForeColor))
            using (Pen foreColorPen = new Pen(Color.FromArgb(100, ForeColor)), overlayPen = new Pen(_overlapColor))
            {
                g.DrawEllipse(foreColorPen, 0, 0, 14, 14);
                g.DrawEllipse(overlayPen, 0, 0, 14, 14);
                if (Checked)
                {
                    g.FillEllipse(backColorBrush, 3, 3, 8, 8);
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        using (GraphicsPath clipPath = new GraphicsPath())
                        {
                            path.AddPolygon(new[] {new Point(2, 12), new Point(11, 11), new Point(11, 2)});
                            clipPath.AddEllipse(3, 3, 8, 8);
                            g.SetClip(clipPath);
                            using (SolidBrush brush = new SolidBrush(Color.FromArgb(50, 20, 20, 20)))
                            {
                                g.FillPath(brush, path);
                            }

                            g.ResetClip();
                        }
                    }
                }

                g.DrawString(Text, Font, foreColorBrush, 18, (Height - g.MeasureString(Text, Font).Height) / 2);
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