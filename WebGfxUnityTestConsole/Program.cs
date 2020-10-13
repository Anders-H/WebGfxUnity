using System.IO;
using System.Text;
using WebGfxUnity.Render;

namespace WebGfxUnityTestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //var image = AreaCircleVsRadiusCircle.Create();
            //var image = FillAndStroke.Create();
            var image = Polygons.Create();

            var canvasRenderer = new CanvasCodeRenderer("c");
            var svgRenderer = new SvgCodeRenderer("s");

            using var sw = new StreamWriter(@"C:\Temp\Tjo.html", false, Encoding.UTF8);
            sw.WriteLine(@"<!DOCTYPE html>

<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
    <title></title>
</head>
<body>");
            sw.WriteLine($@"<p>{canvasRenderer.Render(image)}</p>");
            sw.WriteLine($@"<p>{svgRenderer.Render(image)}</p>");
            sw.WriteLine(@"</body>
</html>");
            sw.Close();
        }
    }
}