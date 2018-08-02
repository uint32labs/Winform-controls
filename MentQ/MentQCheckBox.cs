using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQCheckBox : CheckBox
    {
        public MentQCheckBox()
        {
            Font = new Font("Verdana", 7);
            ForeColor = Color.Black;
            BackColor = MentQDefaults.MentQBlue;
            SetStyle(
                ControlStyles.CacheText | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            AutoSize = true;
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

        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(17 + Convert.ToInt32(Graphics.FromHwnd(Handle).MeasureString(Text, Font).Width), 14);
        }

        protected override void OnCreateControl()
        {
            DoubleBuffered = true;
            base.OnCreateControl();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(Parent.BackColor);
            using (SolidBrush backBrush = new SolidBrush(Color.FromArgb(5, 30, 30, 30)))
            {
                G.FillPath(backBrush, GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, 13, 13), 3));
            }

            G.SetClip(new Rectangle(3, 3, 8, 8));
            if (Checked)
                using (SolidBrush backColorBrush = new SolidBrush(BackColor))
                {
                    G.FillPath(backColorBrush, GlobalHelpers.GetRoundedRect(new RectangleF(2, 2, 9, 9), 4.3F));
                }

            G.ResetClip();
            using (Pen pen = new Pen(Color.FromArgb(85, 13, 13, 13)))
            {
                G.DrawPath(pen, GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, 13, 13), 2));
            }

            using (SolidBrush foreColorBrush = new SolidBrush(ForeColor))
            {
                G.DrawString(Text, Font, foreColorBrush, 15, (Height - G.MeasureString(Text, Font).Height) / 2);
            }

            if (Enabled == false)
                using (SolidBrush disabledBrush = new SolidBrush(Color.FromArgb(100, 222, 222, 222)))
                {
                    G.FillPath(disabledBrush, GlobalHelpers.GetRoundedRect(new Rectangle(0, 0, 13, 13), 3));
                    G.DrawString(Text, Font, disabledBrush, 15, (Height - G.MeasureString(Text, Font).Height) / 2);
                }
        }
    }
}