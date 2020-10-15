using System.Drawing;
using WebGfxUnity.Shapes;
using Rectangle = WebGfxUnity.Shapes.Rectangle;

namespace WebGfxUnity.Render
{
    public class SvgCodeRenderer : CodeRenderer
    {
        public SvgCodeRenderer(string elementId) : base(elementId)
        {
        }

        protected override string RenderStart(WebImage image) =>
            $@"<svg id=""{ElementId}"" width=""{image.Size.Width}"" height=""{image.Size.Height}"" style=""background-color: {ColorToHtml(image.BackgroundColor)};"">";

        protected override string Render(StrokeWithModifier s) =>
            $"";

        protected override string Render(StrokeColorModifier s) =>
            $"";

        protected override string Render(FillColorModifier s) =>
            $"";

        protected override string Render(AreaCircle circle)
        {
            var x = circle.Rectangle.X + circle.Rectangle.Width / 2;
            var y = circle.Rectangle.Y + circle.Rectangle.Height / 2;
            var r = (circle.Rectangle.Width + circle.Rectangle.Height) / 4;

            if (circle.Fill && circle.Stroke)
                return $@"<circle cx=""{x}"" cy=""{y}"" r=""{r}"" stroke=""{ColorToHtml(StrokeColor)}"" stroke-width=""{StrokeWidth}"" fill=""{ColorToHtml(FillColor)}"" />";
            
            if (circle.Fill)
                return $@"<circle cx=""{x}"" cy=""{y}"" r=""{r}"" fill=""{ColorToHtml(FillColor)}"" />";

            if (circle.Stroke)
                return $@"<circle cx=""{x}"" cy=""{y}"" r=""{r}"" stroke=""{ColorToHtml(StrokeColor)}"" stroke-width=""{StrokeWidth}"" fill=""none"" />";

            return "";
        }

        protected override string Render(RadiusCircle circle)
        {
            if (circle.Fill && circle.Stroke)
                return $@"<circle cx=""{circle.Position.X}"" cy=""{circle.Position.Y}"" r=""{circle.Radius}"" stroke=""{ColorToHtml(StrokeColor)}"" stroke-width=""{StrokeWidth}"" fill=""{ColorToHtml(FillColor)}"" />";

            if (circle.Fill)
                return $@"<circle cx=""{circle.Position.X}"" cy=""{circle.Position.Y}"" r=""{circle.Radius}"" fill=""{ColorToHtml(FillColor)}"" />";

            if (circle.Stroke)
                return $@"<circle cx=""{circle.Position.X}"" cy=""{circle.Position.Y}"" r=""{circle.Radius}"" stroke=""{ColorToHtml(StrokeColor)}"" stroke-width=""{StrokeWidth}"" fill=""none"" />";

            return "";
        }

        protected override string Render(Rectangle rectangle)
        {
            var r = rectangle.Rectangle;

            if (rectangle.Fill && rectangle.Stroke)
                return $@"<rect x=""{r.X}"" y=""{r.Y}"" width=""{r.Width}"" height=""{r.Height}"" style=""fill:{ColorToHtml(FillColor)};stroke:{ColorToHtml(StrokeColor)};stroke-width:{StrokeWidth};"" />";

            if (rectangle.Fill)
                return $@"<rect x=""{r.X}"" y=""{r.Y}"" width=""{r.Width}"" height=""{r.Height}"" style=""fill:{ColorToHtml(FillColor)};"" />";
            
            if (rectangle.Stroke)
                return $@"<rect x=""{r.X}"" y=""{r.Y}"" width=""{r.Width}"" height=""{r.Height}"" style=""stroke:{ColorToHtml(StrokeColor)};stroke-width:{StrokeWidth};"" />";

            return "";
        }

        protected override string Render(Polygon polygon)
        {
            if (polygon.Fill && polygon.Stroke)
                return $@"<polygon points=""{polygon.GetAllPointsAsString()}"" style=""fill:{ColorToHtml(FillColor)};stroke:{ColorToHtml(StrokeColor)};stroke-width:{StrokeWidth};fill-rule:nonzero;"" />";

            if (polygon.Fill)
                return $@"<polygon points=""{polygon.GetAllPointsAsString()}"" style=""fill:{ColorToHtml(FillColor)};stroke:none;fill-rule:nonzero;"" />";

            if (polygon.Stroke)
                return $@"<polygon points=""{polygon.GetAllPointsAsString()}"" style=""fill:none;stroke:{ColorToHtml(StrokeColor)};stroke-width:{StrokeWidth};"" />";

            return "";
        }

        protected override string RenderEnd(WebImage image) =>
            "</svg>";
    }
}