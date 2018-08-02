using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQTabControl : TabControl
    {
        private Color _backColor;

        public MentQTabControl()
        {
            Alignment = TabAlignment.Left;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(35, 175);
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            BackColor = Color.FromArgb(55, 55, 55);
            ForeColor = Color.FromArgb(240, 240, 240, 240);
            Font = new Font("Segoe UI", 9);
            DrawMode = TabDrawMode.OwnerDrawFixed;
            SelectedColor = Color.FromArgb(200, 80, 20);
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        [Category("Appearance")]
        public new Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        [Category("Appearance")]
        public new Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                Invalidate();
            }
        }


        [Category("Appearance")] public Color SelectedColor { get; set; }

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

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control.GetType() == typeof(TabPage))
                ((TabPage) e.Control).BackColor = SystemColors.Control;
            base.OnControlAdded(e);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics G = e.Graphics;
            G.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //G.SmoothingMode = SmoothingMode.HighQuality;
            //G.InterpolationMode = InterpolationMode.High;
            //G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.Clear(BackColor);
            int index = 0;
            using (SolidBrush unselectedForeColorBrush = new SolidBrush(Color.FromArgb(100, ForeColor)))
            using (SolidBrush foreColorBrush = new SolidBrush(ForeColor))
            using (SolidBrush selectedTabPageBrush = new SolidBrush(Color.FromArgb(40, 20, 20, 20)))
            {
                foreach (TabPage tabPage in TabPages)
                {
                    if (index == SelectedIndex)
                    {
                        G.FillRectangle(selectedTabPageBrush, 0, index * ItemSize.Width, ItemSize.Height + 4,
                            ItemSize.Width);
                        G.DrawString(tabPage.Text, Font, foreColorBrush, 34,
                            index * ItemSize.Width + (ItemSize.Width - G.MeasureString(tabPage.Text, Font).Height) / 2);
                        using (SolidBrush solidBrush = new SolidBrush(SelectedColor))
                        {
                            G.FillRectangle(solidBrush, 0, ItemSize.Width * index, 3, ItemSize.Width);
                        }
                    }

                    G.DrawString(tabPage.Text, Font, unselectedForeColorBrush, 34,
                        index * ItemSize.Width + (ItemSize.Width - G.MeasureString(tabPage.Text, Font).Height) / 2);
                    if (ImageList != null)
                    {
                        //if (tabPage.ImageIndex >= 0)
                        //    if (ImageList.Images.Count - 1 >= tabPage.ImageIndex)
                        //        G.DrawImage(
                        //            GlobalHelpers.TuneTransparency(ImageList.Images[tabPage.ImageIndex],
                        //                index == SelectedIndex ? 255 : 100, false), 12,
                        //            index * ItemSize.Width + (ItemSize.Width - ImageList.ImageSize.Height) / 2);
                        //if (ImageList.Images.ContainsKey(tabPage.ImageKey))
                        //    G.DrawImage(
                        //        ImageList.Images[tabPage.ImageKey], 12,
                        //        index * ItemSize.Width + (ItemSize.Width - ImageList.ImageSize.Height) / 2);
                        int imageIndex = tabPage.ImageIndex;
                        if (!string.IsNullOrEmpty(tabPage.ImageKey))
                            imageIndex = ImageList.Images.IndexOfKey(tabPage.ImageKey);
                        if (imageIndex > -1)
                            ImageList.Draw(G, 12,
                                index * ItemSize.Width + (ItemSize.Width - ImageList.ImageSize.Height) / 2, imageIndex);
                    }

                    index++;
                }
            }
        }
    }
}