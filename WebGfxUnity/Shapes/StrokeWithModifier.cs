using WebGfxUnity.Shapes.ShapeBase;

namespace WebGfxUnity.Shapes
{
    public class StrokeWithModifier : VectorImageElement
    {
        public int Width { get; }

        public StrokeWithModifier(int width)
        {
            Width = width;
        }
    }
}