using System.Drawing;

namespace WebGfxUnity.Shapes.ShapeBase
{
    public abstract class RadiusShape : PositionShape
    {
        public int Radius { get; }

        internal RadiusShape(Point position, int radius, bool fill, bool stroke) : base(position, fill, stroke)
        {
            Radius = radius;
        }
    }
}