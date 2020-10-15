﻿using WebGfxUnity.Shapes.ShapeBase;
using Rect = System.Drawing.Rectangle;

namespace WebGfxUnity.Shapes
{
    public class AreaCircle : AreaShape
    {
        public AreaCircle(Rect rectangle, bool fill, bool stroke) : base(rectangle, fill, stroke)
        {
        }
    }
}