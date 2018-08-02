using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQButton : Button
    {
        private Color _overlapColor;
        private bool _underline;
        private Color _underlineColor;
        private int _underlineSize;

        public MentQButton()
        {
            Font = new Font("Verdana", 7);
            ForeColor = Color.White;
            SetStyle(
                ControlStyles.CacheText | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            BackColor = MentQDefaults.MentQBlue;
            UnderlineSize = 2;
            UnderlineColor = Color.FromArgb(100, 70, 70, 70);
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics G = pevent.Graphics;
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (SolidBrush backColorBrush = new SolidBrush(BackColor))
            {
                G.FillPath(backColorBrush,
                    GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), 5));
            }

            using (SolidBrush overlapBrush = new SolidBrush(_overlapColor))
            {
                G.FillPath(overlapBrush,
                    GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), 5));
            }

            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                PointF textPosition = new PointF((Width - G.MeasureString(Text, Font).Width) / 2,
                    (Height - G.MeasureString(Text, Font).Height) / 2);
                if (ImageList != null)
                {
                    int index = ImageIndex;
                    if (!string.IsNullOrEmpty(ImageKey) && index != -1)
                        index = ImageList.Images.IndexOfKey(ImageKey);
                    if (index != -1)
                        ImageList.Draw(G, Convert.ToInt32(textPosition.X) - ImageList.ImageSize.Width - 5,
                            (Height - ImageList.ImageSize.Height) / 2, ImageIndex);
                }
                else if (Image != null)
                {
                    G.DrawImage(Image,
                        new Point(Convert.ToInt32(textPosition.X) - Image.Width - 5, (Height - Image.Height) / 2));
                }

                G.DrawString(Text, Font, textBrush, textPosition);
            }

            if (Underline)
                using (SolidBrush underlineBrush = new SolidBrush(UnderlineColor))
                {
                    G.SetClip(new Rectangle(0, Height - UnderlineSize, Width, UnderlineSize));
                    G.FillPath(underlineBrush,
                        GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), 5));
                }

            if (Enabled == false)
                using (SolidBrush disabledBrush = new SolidBrush(Color.FromArgb(100, 222, 222, 222)))
                {
                    G.FillPath(disabledBrush,
                        GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), 5));
                }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _overlapColor = Color.FromArgb(40, 50, 50, 50);
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _overlapColor = Color.FromArgb(40, 50, 50, 50);
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
            _overlapColor = Color.FromArgb(60, 0, 0, 0);
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            _overlapColor = Color.FromArgb(40, 50, 50, 50);
            Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            _overlapColor = Color.FromArgb(0, 0, 0, 0);
            Invalidate();
            base.OnLostFocus(e);
        }
    }
}