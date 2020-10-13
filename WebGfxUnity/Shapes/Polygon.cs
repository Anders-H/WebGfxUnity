using System.Collections.Generic;
using System.Drawing;
using System.Text;
using WebGfxUnity.Shapes.ShapeBase;

namespace WebGfxUnity.Shapes
{
    public class Polygon : PositionShape
    {
        public List<Point> Points;

        public Polygon(Point position, bool fill, bool stroke) : base(position, fill, stroke)
        {
            Points = new List<Point>();
        }

        public Polygon(Point position, IEnumerable<Point> points, bool fill, bool stroke) : base(position, fill, stroke)
        {
            Points = new List<Point>();
            Points.AddRange(points);
        }

        internal Point GetPoint(int index)
        {
            var p = Points[index];
            return new Point(p.X + Position.X, p.Y + Position.Y);
        }

        internal string GetPointAsString(int index)
        {
            var p = GetPoint(index);
            return $"{p.X},{p.Y}";
        }

        internal string GetAllPointsAsString()
        {
            if (Points.Count <= 0)
                return "";

            var s = new StringBuilder();
            for (var i = 0; i < Points.Count; i++)
                s.Append($"{GetPointAsString(i)} ");
            return s.ToString().Trim();
        }
    }
}