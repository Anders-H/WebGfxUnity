using System.Drawing;
using WebGfxUnity;
using Rectangle = WebGfxUnity.Shapes.Rectangle;
using Rect = System.Drawing.Rectangle;

namespace WebGfxUnityTestConsole
{
    public static class ProtoDiagram
    {
        public static WebImage Create()
        {
            var image = new WebImage(Color.DarkGray, new Size(220, 110));
            image.FillColor(Color.White);
            image.StrokeColor(Color.Black);
            image.StrokeWidth(1);
            image.Elements.Add(new Rectangle(new Rect(5, 5, 210, 100), true, true));
            image.FillColor(Color.Red);
            for (var i = 0; i < 4; i++)
                image.Elements.Add(
                    new Rectangle(
                        new Rect(20 + 50 * i, 104 - ((i + 1) * 20), 30, (i + 1) * 20),
                        true,
                        false
                    )
                );
            return image;
        }
    }
}