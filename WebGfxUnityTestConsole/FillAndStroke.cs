using System.Drawing;
using WebGfxUnity;
using WebGfxUnity.Shapes;

namespace WebGfxUnityTestConsole
{
    public static class FillAndStroke
    {
        public static WebImage Create()
        {
            var image = new WebImage(Color.DarkGray, new Size(220, 110));
            image.FillColor(Color.Green);
            image.Elements.Add(new AreaCircle(new Rectangle(5, 5, 100, 100), true, false));
            image.StrokeColor(Color.Yellow);
            image.StrokeWidth(3);
            image.Elements.Add(new AreaCircle(new Rectangle(60, 5, 100, 100), false, true));
            image.FillColor(Color.Red);
            image.Elements.Add(new AreaCircle(new Rectangle(115, 5, 100, 100), true, false));
            return image;
        }
    }
}