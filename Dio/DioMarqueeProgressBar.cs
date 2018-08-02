using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Dio
{
    public class DioMarqueeProgressBar : Control
    {
        private readonly int _increment = 1;
        private readonly Timer timer;
        private int _marqueePos;

        private int _marqueeWidth;
        private int _marqueeWidthConst;
        private Color _overlapColor = Color.FromArgb(0, 0, 0, 0);

        public DioMarqueeProgressBar()
        {
            timer = new Timer();
            timer.Interval = 12;
            timer.Elapsed += (sender, args) => Callback();
            Size = new Size(150, 14);
            BorderColor = DioDefaults.DefaultBorderColor;
            Font = DioDefaults.DefaultFont;
            HandleCreated += (sender, args) => { DoubleBuffered = true; };
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
            ForeColor = DioDefaults.DefaultBackColor;

            MarqueeWidth = 50;
            MarqueeXPos = 20;
            MarqueeVisible = true;
            _marqueeWidth = MarqueeWidth;
            _marqueePos = MarqueeXPos;
        }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public Color BorderColor { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public bool MarqueeVisible { get; set; }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public int MarqueeWidth
        {
            get { return _marqueeWidthConst; }
            set
            {
                _marqueeWidthConst = value;
                _marqueeWidth = value;
            }
        }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(false)]
        public int MarqueeXPos { get; set; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.Clear(Parent.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using (Pen borderPen = new Pen(BorderColor))
            using (SolidBrush backColorBrush = new SolidBrush(BackColor), foreColorBrush = new SolidBrush(ForeColor))
            {
                g.FillRectangle(backColorBrush, 0, 0, Width - 1, Height - 1);
                if (MarqueeVisible)
                    g.FillRectangle(foreColorBrush, MarqueeXPos, 0, _marqueeWidth, Height - 1);
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            }
        }

        public void Start()
        {
            MarqueeVisible = true;
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void Callback()
        {
            if (MarqueeXPos + MarqueeWidth >= Width)
                _marqueeWidth = Width - MarqueeXPos - 2;
            if (_marqueePos < 0)
            {
                MarqueeXPos = 0;
                _marqueeWidth += _increment;
                _marqueePos += _increment;
            }
            else if (MarqueeXPos >= Width)
            {
                _marqueePos = -MarqueeWidth;
            }
            else
            {
                MarqueeXPos += _increment;
            }

            Invalidate();
        }
    }
}