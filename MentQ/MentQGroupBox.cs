using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQGroupBox : ContainerControl
    {
        public delegate void CloseChangedEventHandler(object sender, EventArgs e);

        private readonly Image downArrow =
            GlobalHelpers.TuneTransparency(GlobalHelpers.Base64ToImage(GlobalHelpers.DownArrowBase64String), 80, true);

        private readonly List<Control> invisibleControls = new List<Control>();

        private readonly Image upArrow =
            GlobalHelpers.TuneTransparency(GlobalHelpers.Base64ToImage(GlobalHelpers.DownArrowBase64String), 80, true);

        private bool _closed;

        private int lastHeight;

        public MentQGroupBox()
        {
            BackColor = Color.FromArgb(255, 255, 255);
            ForeColor = Color.FromArgb(20, 20, 20);
            BorderColor = Color.FromArgb(180, 180, 180);
            Font = new Font("Segoe UI", 8.25F);
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw, true);
            Size = new Size(150, 100);
            Closable = false;
            upArrow.RotateFlip(RotateFlipType.RotateNoneFlipY);
        }

        private Color _borderColor { get; set; }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
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
        public bool Closed
        {
            get { return _closed; }
            set
            {
                _closed = value;
                OnCloseChanged();
                Invalidate();
            }
        }

        [Category("Appearance")] public bool Closable { get; set; }

        [Category("Appearance")] public Color UpperColor { get; set; }

        [Category("Appearance")] public Image Icon { get; set; }

        public event CloseChangedEventHandler ClosedChanged;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Parent.BackColor);
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                G.FillRectangle(brush, 0, 0, Width, Height);
            }

            using (SolidBrush upperBrush = new SolidBrush(UpperColor))
            {
                G.FillRectangle(upperBrush, 0, 0, Width, 26);
            }

            using (Pen borderPen = new Pen(BorderColor))
            {
                G.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
                G.DrawLine(borderPen, 0, 26, Width - 1, 26);
            }

            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                G.DrawString(Text, Font, textBrush, Icon == null ? 7 : 28,
                    (26 - G.MeasureString(Text, Font).Height) / 2);
            }

            if (Icon != null)
                G.DrawImage(Icon, new Rectangle(8, 5, 16, 16));
            if (Closable)
                if (Closed)
                    G.DrawImage(upArrow, Width - downArrow.Width - 8, (26 - downArrow.Height) / 2);
                else
                    G.DrawImage(downArrow, Width - downArrow.Width - 8, (26 - downArrow.Height) / 2);
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (Closable)
                if (e.X > Width - downArrow.Width - 8 && e.X < Width - 8 && e.Y > (26 - downArrow.Height) / 2 &&
                    e.Y < (26 - downArrow.Height) / 2 + downArrow.Height)
                    Closed = !Closed;

            base.OnMouseDown(e);
        }

        public void OnCloseChanged()
        {
            if (Closed)
            {
                lastHeight = Size.Height;
                foreach (Control control in Controls)
                    if (control.Location.Y > 27)
                        if (control.Visible)
                            control.Visible = false;
                        else
                            invisibleControls.Add(control);

                Size = new Size(Width, 27);
            }
            else
            {
                foreach (Control control in Controls)
                    if (!invisibleControls.Contains(control))
                        control.Visible = true;
                Size = new Size(Width, lastHeight);
                invisibleControls.Clear();
            }

            if (ClosedChanged != null)
                ClosedChanged(this, new EventArgs());
        }
    }
}