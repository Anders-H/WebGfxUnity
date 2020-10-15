using System.Drawing;
using WebGfxUnity;
using WebGfxUnity.Shapes;
using Rect = System.Drawing.Rectangle;

namespace WebGfxUnityTestConsole
{
    public static class AreaCircleVsRadiusCircle
    {
        public static WebImage Create()
        {
            var image = new WebImage(Color.DarkGray, new Size(220, 110));
            image.Elements.Add(new AreaCircle(new Rect(5, 5, 100, 100), true, true));
            image.Elements.Add(new RadiusCircle(new Point(165, 55), 50, true, true));
            return image;
        }
    }
}