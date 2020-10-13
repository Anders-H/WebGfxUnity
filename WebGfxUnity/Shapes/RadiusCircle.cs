using System.Drawing;
using WebGfxUnity.Shapes.ShapeBase;

namespace WebGfxUnity.Shapes
{
    public class RadiusCircle : RadiusShape
    {
        public RadiusCircle(Point position, int radius, bool fill, bool stroke) : base(position, radius, fill, stroke)
        {
        }
    }
}