using System.Text;
using WebGfxUnity.Shapes;

namespace WebGfxUnity.Render
{
    public class CanvasCodeRenderer : CodeRenderer
    {
        public CanvasCodeRenderer(string elementId) : base(elementId)
        {
        }

        protected override string RenderStart(WebImage image) =>
            $@"<canvas id=""{ElementId}"" width=""{image.Size.Width}"" height=""{image.Size.Height}"" style=""background-color: {ColorToHtml(image.BackgroundColor)};"">
</canvas>
<script>
var ctx = {ElementId}.getContext(""2d"");
ctx.fillStyle = ""{ColorToHtml(FillColor)}"";
ctx.strokeStyle = ""{ColorToHtml(StrokeColor)}"";
ctx.lineWidth = {StrokeWidth};
";

        protected override string Render(StrokeWithModifier s) =>
            $"ctx.lineWidth = {s.Width};";

        protected override string Render(StrokeColorModifier s) =>
            $@"ctx.strokeStyle  = ""{ColorToHtml(s.Color)}"";";

        protected override string Render(FillColorModifier s) =>
            $@"ctx.fillStyle  = ""{ColorToHtml(s.Color)}"";";

        protected override string Render(AreaCircle circle)
        {
            var x = circle.Rectangle.X + circle.Rectangle.Width / 2;
            var y = circle.Rectangle.Y + circle.Rectangle.Height / 2;
            var r = (circle.Rectangle.Width + circle.Rectangle.Height) / 4;
            var s = new StringBuilder();
            
            s.AppendLine("ctx.beginPath();");
            s.AppendLine($"ctx.arc({x}, {y}, {r}, 0, 2 * Math.PI);");

            if (circle.Fill)
                s.AppendLine("ctx.fill();");

            if (circle.Stroke)
                s.AppendLine("ctx.stroke();");

            return s.ToString();
        }

        protected override string Render(RadiusCircle circle)
        {
            var s = new StringBuilder();

            s.AppendLine("ctx.beginPath();");
            s.AppendLine($"ctx.arc({circle.Position.X}, {circle.Position.Y}, {circle.Radius}, 0, 2 * Math.PI);");

            if (circle.Fill)
                s.AppendLine("ctx.fill();");

            if (circle.Stroke)
                s.AppendLine("ctx.stroke();");

            return s.ToString();
        }

        protected override string Render(Polygon polygon)
        {
            if (polygon.Points.Count <= 0)
                return "";

            var s = new StringBuilder();
            s.AppendLine("ctx.beginPath();");
            s.AppendLine($"ctx.moveTo({polygon.GetPointAsString(0)});");
            if (polygon.Points.Count > 1)
            {
                for (var i = 1; i < polygon.Points.Count; i++)
                {
                    s.AppendLine($"ctx.lineTo({polygon.GetPointAsString(i)});");
                }
            }
            s.AppendLine("ctx.closePath();");

            if (polygon.Fill)
                s.AppendLine("ctx.fill();");

            if (polygon.Stroke)
                s.AppendLine("ctx.stroke();");

            return s.ToString();
        }

        protected override string RenderEnd(WebImage image) =>
            "</script>";
    }
}