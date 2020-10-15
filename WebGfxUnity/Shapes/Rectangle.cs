using WebGfxUnity.Shapes.ShapeBase;
using Rect = System.Drawing.Rectangle;

namespace WebGfxUnity.Shapes
{
    public class Rectangle : AreaShape
    {
        public Rectangle(Rect rectangle, bool fill, bool stroke) : base(rectangle, fill, stroke)
        {
        }
    }
}