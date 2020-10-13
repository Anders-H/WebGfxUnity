using System.Drawing;

namespace WebGfxUnity.Shapes.ShapeBase
{
    public abstract class AreaShape : Shape
    {
        public Rectangle Rectangle { get; }

        protected AreaShape(Rectangle rectangle, bool fill, bool stroke) : base(fill, stroke)
        {
            Rectangle = rectangle;
        }
    }
}