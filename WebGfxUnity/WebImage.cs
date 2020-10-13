using System.Collections.Generic;
using System.Drawing;
using WebGfxUnity.Shapes;
using WebGfxUnity.Shapes.ShapeBase;

namespace WebGfxUnity
{
    public class WebImage
    {
        public Color BackgroundColor { get; }
        public Size Size { get; }
        public List<VectorImageElement> Elements { get; }

        public WebImage(Color backgroundColor, Size size)
        {
            BackgroundColor = backgroundColor;
            Size = size;
            Elements = new List<VectorImageElement>();
        }

        public void StrokeWidth(int width) =>
            Elements.Add(new StrokeWithModifier(width));

        public void StrokeColor(Color color) =>
            Elements.Add(new StrokeColorModifier(color));

        public void FillColor(Color color) =>
            Elements.Add(new FillColorModifier(color));
    }
}