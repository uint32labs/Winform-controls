using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQNumericUpDown : Control
    {
        public MentQNumericUpDown()
        {
            BackColor = Color.White;
            SelectedColor = MentQDefaults.MentQBlue;
            DoubleBuffered = true;
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint, true);
            Padding = new Padding(3);
            Size = new Size(90, 24);
            Size buttonSize = CalculateButtonSize();
            MentQButton upButton = new MentQButton
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Size = buttonSize,
                Location = new Point(Width - Padding.Right - buttonSize.Width, Padding.Top),
                Font = new Font("Segoe UI Symbol", 6),
                Text = "\uE010"
            };
            MentQButton downButton = new MentQButton
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Size = buttonSize,
                Location = new Point(Width - Padding.Right - buttonSize.Width,
                    Height - Padding.Bottom - buttonSize.Height),
                Font = new Font("Segoe UI Symbol", 6),
                Text = "\uE011"
            };
            InternalNumericUpDown = new NumericUpDown();
            InternalNumericUpDown.BackColor = BackColor;
            InternalNumericUpDown.BorderStyle = BorderStyle.None;

            // Remove the default numeric up down buttons
            InternalNumericUpDown.Controls.RemoveAt(0);
            UpButton = upButton;
            DownButton = downButton;
            UpButton.Click += (sender, args) => InternalNumericUpDown.UpButton();
            DownButton.Click += (sender, args) => InternalNumericUpDown.DownButton();
            Controls.Add(InternalNumericUpDown);
            InternalNumericUpDown.SendToBack();
            Controls.Add(UpButton);
            UpButton.BringToFront();
            Controls.Add(DownButton);
            DownButton.BringToFront();

            
        }

        public NumericUpDown InternalNumericUpDown { get; }
        private MentQButton UpButton { get; }
        private MentQButton DownButton { get; }
        public Color SelectedColor { get; set; }
        [Category("Appearance")]
        public decimal Value
        {
            get { return InternalNumericUpDown.Value; }
            set { InternalNumericUpDown.Value = value; }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            AdjustSize();
            base.OnHandleCreated(e);
            
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            MaximumSize = new Size(Int16.MaxValue, 24);
            MinimumSize = new Size(0, 24);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            AdjustSize();
            base.OnPaddingChanged(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AdjustSize();
        }

        private void AdjustSize()
        {
            if (InternalNumericUpDown != null)
            {
                InternalNumericUpDown.Width = Width - Padding.Horizontal - 5;
                InternalNumericUpDown.Location = new Point(Padding.Left,
                    Padding.Top + (Height - Padding.Vertical - InternalNumericUpDown.Height) / 2 + 1);
            }

            if (UpButton != null && DownButton != null)
            {
                Size buttonSize = CalculateButtonSize();
                UpButton.Size = buttonSize;
                DownButton.Size = buttonSize;
                DownButton.Location = new Point(Width - Padding.Right - buttonSize.Width,
                    Height - Padding.Bottom - buttonSize.Height);
            }
        }

        private Size CalculateButtonSize()
        {
            return new Size(20, (Height - Padding.Top - Padding.Bottom) / 2 - 1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(BackColor);
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                G.FillPath(brush, GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 4));
            }

            using (Pen pen = new Pen(Color.Gray))
            {
                G.DrawPath(pen, GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 4));
            }
        }
    }
}