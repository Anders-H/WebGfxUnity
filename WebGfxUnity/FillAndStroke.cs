using System.Drawing;
using WebGfxUnity.Shapes;
using Rect = System.Drawing.Rectangle;

namespace WebGfxUnity
{
    public static class FillAndStroke
    {
        public static WebImage Create()
        {
            var image = new WebImage(Color.Black, new Size(220, 110));
            image.FillColor(Color.Green);
            image.StrokeColor(Color.Yellow);
            image.StrokeWidth(3);
            image.Elements.Add(new AreaCircle(new Rect(5, 5, 100, 100), true, true));
            image.FillColor(Color.Red);
            image.Elements.Add(new AreaCircle(new Rect(50, 5, 100, 100), true, false));
            image.StrokeColor(Color.White);
            image.Elements.Add(new AreaCircle(new Rect(100, 5, 100, 100), false, true));
            return image;
        }
    }
}