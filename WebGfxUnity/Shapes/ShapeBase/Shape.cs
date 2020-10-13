namespace WebGfxUnity.Shapes.ShapeBase
{
    public abstract class Shape : VectorImageElement
    {
        public bool Fill { get; set; }
        public bool Stroke { get; set; }

        internal Shape(bool fill, bool stroke)
        {
            Fill = fill;
            Stroke = stroke;
        }
    }
}