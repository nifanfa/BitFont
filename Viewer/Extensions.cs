using System.Drawing;

namespace Viewer
{
    public static class Extensions
    {
        public static void DrawPoint(this Graphics graphics, int X, int Y, Color Color)
        {
            SolidBrush solidBrush = new SolidBrush(Color);
            graphics.FillRectangle(solidBrush, X, Y, 1, 1);
            solidBrush.Dispose();
        }
    }
}
