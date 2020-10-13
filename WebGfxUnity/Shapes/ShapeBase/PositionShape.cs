using System.Drawing;

namespace WebGfxUnity.Shapes.ShapeBase
{
    public abstract class PositionShape : Shape
    {
        public Point Position { get; }

        protected PositionShape(Point position, bool fill, bool stroke) : base(fill, stroke)
        {
            Position = position;
        }
    }
}