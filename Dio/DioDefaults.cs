#region

using System.Drawing;

#endregion

namespace Dio
{
    internal struct DioDefaults
    {
        public static Color DefaultBackColor { get; } = Color.CornflowerBlue;
        public static Color DefaultForeColor { get; } = Color.White;
        public static Font DefaultFont { get; } = new Font(new FontFamily("Segoe UI"), 8.25f);
        public static Color DioDefaultshadowColor { get; } = Color.FromArgb(200, 50, 50, 50);
        public static Color DefaultBorderColor { get; } = Color.FromArgb(100, 70, 70, 70);
        public static Color DefaultDarkForeColor { get; } = Color.FromArgb(200, 45, 45, 45);
    }
}