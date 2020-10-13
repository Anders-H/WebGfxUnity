using System.Drawing;
using WebGfxUnity;
using WebGfxUnity.Shapes;

namespace WebGfxUnityTestConsole
{
    public static class Polygons
    {
        public static WebImage Create()
        {
            var image = new WebImage(Color.DarkGray, new Size(315, 215));
            image.StrokeColor(Color.Blue);
            image.FillColor(Color.White);
            image.StrokeWidth(5);

            var star = new[] {new Point(100, 10), new Point(40, 198), new Point(190, 78), new Point(10, 78), new Point(160, 198)};

            image.Elements.Add(new Polygon(new Point(5, 5), star, true, true));
            image.Elements.Add(new Polygon(new Point(60, 5), star, false, true));
            image.Elements.Add(new Polygon(new Point(105, 5), star, true, false));
            return image;
        }
    }
}