using Rect = System.Drawing.Rectangle;

namespace WebGfxUnity.Shapes.ShapeBase
{
    public abstract class AreaShape : Shape
    {
        public Rect Rectangle { get; }

        protected AreaShape(Rect rectangle, bool fill, bool stroke) : base(fill, stroke)
        {
            Rectangle = rectangle;
        }
    }
}