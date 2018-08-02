using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MentQ
{
    [Category("MentQ")]
    public class MentQInfoBox : Control
    {
        public enum Iconlayout
        {
            None,
            Scaled
        }

        public enum UnderlineStyle
        {
            ImageOnly,
            Full,
            None,
            ExcludeImage
        }

        private bool _antialias;
        private Image _backgroundImage;
        private Image _cachedTransparentImage;
        private Iconlayout _iconLayout;
        private bool _imageContainer;
        private Color _imageContainerColor;
        private int _imageTransparency;
        private string _title;
        private UnderlineStyle _underline;
        private Color _underlineColor;
        private int _underlineSize;


        public MentQInfoBox()
        {
            ImageContainerColor = Color.FromArgb(100, 30, 30, 30);
            ImageContainer = false;
            UnderlineSize = 4;
            Underline = UnderlineStyle.Full;
            UnderlineColor = Color.FromArgb(100, 70, 70, 70);
            AntiAliasImage = true;
            Size = new Size(220, 65);
            BackColor = MentQDefaults.MentQBlue;
            Font = new Font("Verdana", (float) 11.25, FontStyle.Regular);
            ForeColor = Color.White;
            DoubleBuffered = true;
            ImageTransparency = 255;
            Title = "Title";
            SetStyle(
                ControlStyles.CacheText | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
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
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public int ImageTransparency
        {
            get { return _imageTransparency; }
            set
            {
                _imageTransparency = value;
                if (BackgroundImage != null)
                    if (ImageTransparency > 0)
                        _cachedTransparentImage = EditBackgroundImage(BackgroundImage);
                    else
                        _cachedTransparentImage = null;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public new Iconlayout BackgroundImageLayout
        {
            get { return _iconLayout; }
            set
            {
                if (BackgroundImage != null)
                    if (ImageTransparency > 0)
                        _cachedTransparentImage = EditBackgroundImage(BackgroundImage);
                _iconLayout = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public bool AntiAliasImage
        {
            get { return _antialias; }
            set
            {
                _antialias = value;
                if (BackgroundImage != null)
                    if (ImageTransparency > 0)

                        _cachedTransparentImage = EditBackgroundImage(BackgroundImage);
                Invalidate();
            }
        }

        [Category("Appearance")]
        public UnderlineStyle Underline
        {
            get { return _underline; }
            set
            {
                if ((value == UnderlineStyle.Full) | (value == UnderlineStyle.None))
                    _underline = value;
                if ((value == UnderlineStyle.ImageOnly) | (value == UnderlineStyle.ExcludeImage))
                    if (BackgroundImage != null)
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

        [Category("Appearance")]
        public bool ImageContainer
        {
            get { return _imageContainer; }
            set
            {
                _imageContainer = BackgroundImage == null ? false : value;

                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color ImageContainerColor
        {
            get { return _imageContainerColor; }
            set
            {
                _imageContainerColor = value;
                Invalidate();
            }
        }

        public override Image BackgroundImage
        {
            get { return _backgroundImage; }
            set
            {
                _backgroundImage = value;
                if (ImageTransparency > 0)
                    _cachedTransparentImage = EditBackgroundImage(BackgroundImage);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            G.Clear(Parent.BackColor);

            G.SmoothingMode = SmoothingMode.HighQuality;

            using (
                SolidBrush backColorBrush = new SolidBrush(BackColor),
                foreColorBrush = new SolidBrush(ForeColor),
                titleColorBrush = new SolidBrush(Color.FromArgb(180, ForeColor)))
            {
                G.FillPath(backColorBrush,
                    GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height + 1), 5));
                DrawImage(G);
                if (BackgroundImage != null)
                    DrawUnderline(G, CalculateImageSize(BackgroundImage));
                else
                    DrawUnderline(G, new SizeF());

                if (!string.IsNullOrEmpty(Title))
                    G.DrawString(Title.ToUpper(), new Font("Verdana", 8),
                        titleColorBrush,
                        12, (Height - G.MeasureString(Text, Font).Height) / 2 - 7);

                G.DrawString(Text, Font, foreColorBrush, 12,
                    (Height - G.MeasureString(Text, Font).Height) / 2 + (string.IsNullOrEmpty(Title) ? 0 : 8));
            }

            if (!Enabled)
                using (SolidBrush disabledBrush = new SolidBrush(Color.FromArgb(100, 222, 222, 222)))
                {
                    G.FillPath(disabledBrush,
                        GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height + 1), 4));
                }

            base.OnPaint(e);
        }

        private void DrawImage(Graphics G)
        {
            #region "Background Image"

            if (BackgroundImage != null)
            {
                SizeF destinationSize = CalculateImageSize(BackgroundImage);

                #region "Image Container"

                if (ImageContainer)
                {
                    G.SetClip(CalculateContainerPosition(destinationSize));

                    using (SolidBrush brush = new SolidBrush(ImageContainerColor))
                    {
                        G.FillPath(brush,
                            GlobalHelpers.GetRoundedRect(new RectangleF(-1, -1, Width + 1, Height + 1), 5));
                    }

                    G.ResetClip();
                }

                #endregion


                #region "Draw Image"

                if (_cachedTransparentImage != null)
                    if (BackgroundImageLayout == Iconlayout.Scaled)
                        G.DrawImage(_cachedTransparentImage,
                            new RectangleF(
                                Width - destinationSize.Width - 5, (Height - destinationSize.Height) / 2,
                                destinationSize.Width, destinationSize.Height));
                    else
                        G.DrawImage(_cachedTransparentImage, Width - BackgroundImage.Width - 5,
                            (Height - BackgroundImage.Height) / 2);

                #endregion
            }

            #endregion
        }

        private void DrawUnderline(Graphics G, SizeF imageSizeF)
        {
            using (
                SolidBrush underlineBrush = new SolidBrush(UnderlineColor), backColorBrush = new SolidBrush(BackColor))
            {
                if (Underline != UnderlineStyle.None)
                {
                    Rectangle clipping = new Rectangle(0, Height - UnderlineSize, Width, UnderlineSize);
                    if (BackgroundImage != null)
                    {
                        Rectangle imageContainerPosition = CalculateContainerPosition(imageSizeF);
                        switch (Underline)
                        {
                            case UnderlineStyle.ImageOnly:
                                if (BackgroundImage != null)
                                    clipping = new Rectangle(imageContainerPosition.X, Height - UnderlineSize,
                                        imageContainerPosition.Width, UnderlineSize);
                                break;
                            case UnderlineStyle.ExcludeImage:
                                if (BackgroundImage != null)
                                    clipping = new Rectangle(0, Height - UnderlineSize,
                                        Width - imageContainerPosition.Width + 5, UnderlineSize);
                                break;
                        }
                    }

                    G.SetClip(clipping);
                    G.FillPath(underlineBrush,
                        GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height + 1), 5));
                    G.ResetClip();
                    //DrawImage(G);
                    //G.FillPath(underlineBrush,
                    //    GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height + 1), 5));

                    //G.SetClip(new Rectangle(-1, -1, Width + 1, Height - UnderlineSize));
                    //G.FillPath(backColorBrush,
                    //    GlobalHelpers.GetRoundedRect(new Rectangle(-1, -1, Width + 1, Height - UnderlineSize), 5));
                    //DrawImage(G);
                    //G.ResetClip();
                }
            }
        }

        private Image EditBackgroundImage(Image value)
        {
            return GlobalHelpers.TuneTransparency(value, ImageTransparency,
                AntiAliasImage);
        }

        private SizeF CalculateImageSize(Image value)
        {
            if (BackgroundImageLayout == Iconlayout.Scaled)
            {
                float ratio = (float) value.Height / Height;
                return new SizeF(value.Width / ratio - 15,
                    value.Height / ratio - 15);
            }

            return new SizeF(value.Width, value.Height);
        }

        private Rectangle CalculateContainerPosition(SizeF imageSize)
        {
            return new Rectangle(Width - Convert.ToInt32(imageSize.Width) - 10, 0,
                Convert.ToInt32(imageSize.Width) + 15,
                Height);
        }
    }
}