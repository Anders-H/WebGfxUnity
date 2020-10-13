using System.Drawing;

namespace WebGfxUnity.Shapes.ShapeBase
{
    public abstract class ColorElement : VectorImageElement
    {
        public Color Color { get; }

        protected ColorElement(Color color)
        {
            Color = color;
        }
    }
}