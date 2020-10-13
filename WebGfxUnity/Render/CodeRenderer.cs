using System.Drawing;
using System.Text;
using WebGfxUnity.Shapes;
using WebGfxUnity.Shapes.ShapeBase;

namespace WebGfxUnity.Render
{
    public abstract class CodeRenderer
    {
        public string ElementId { get; }
        public Color FillColor { get; private set; }
        public Color StrokeColor { get; private set; }
        public int StrokeWidth { get; private set; }

        protected CodeRenderer(string elementId)
        {
            ElementId = elementId;
            FillColor = Color.Beige;
            StrokeColor = Color.Black;
            StrokeWidth = 1;
        }

        public string Render(WebImage image)
        {
            var s = new StringBuilder();
            s.AppendLine(RenderStart(image));
            foreach (var element in image.Elements)
            {
                if (element is Shape shape && !shape.Stroke && !shape.Fill)
                    continue;

                if (element is StrokeWithModifier s1)
                {
                    StrokeWidth = s1.Width;
                    s.AppendLine(Render(s1));
                }
                else if (element is StrokeColorModifier s2)
                {
                    StrokeColor = s2.Color;
                    s.AppendLine(Render(s2));
                }
                else if (element is FillColorModifier f1)
                {
                    FillColor = f1.Color;
                    s.AppendLine(Render(f1));
                }
                else if (element is AreaCircle c1)
                    s.AppendLine(Render(c1));
                else if (element is RadiusCircle c2)
                    s.AppendLine(Render(c2));
                else if (element is Polygon p1)
                    s.AppendLine(Render(p1));
            }
            s.AppendLine(RenderEnd(image));
            return s.ToString();
        }

        protected string ColorToHtml(Color color) =>
            $"#{color.R:X2}{color.G:X2}{color.B:X2}".ToLower();

        protected abstract string RenderStart(WebImage image);

        protected abstract string Render(StrokeWithModifier s);

        protected abstract string Render(StrokeColorModifier s);

        protected abstract string Render(FillColorModifier s);

        protected abstract string Render(AreaCircle circle);

        protected abstract string Render(RadiusCircle circle);

        protected abstract string Render(Polygon polygon);

        protected abstract string RenderEnd(WebImage image);
    }
}