﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGraphicEditor.Classes.Figures
{
    class Arrow : Figure
    {

        public Arrow()
        {
            _points = new PointF[8];
        }

        public override void calculatePoints(PointF originPoint, PointF endPoint)
        {

            Points[0].X = Points[6].X = originPoint.X; 
            Points[0].Y = Points[1].Y = originPoint.Y + ((_height) / 7) * 2;
            Points[1].X = Points[2].X = Points[4].X = Points[5].X = Points[0].X + (_width) / 3 * 2;
            Points[3].Y = originPoint.Y + (_height) / 2;
            Points[3].X = originPoint.X + (_width);
            Points[4].Y = originPoint.Y + (_height);
            Points[5].Y = Points[6].Y = originPoint.Y + ((_height) / 7) * 5;
            Points[2].Y = originPoint.Y;
            Points[7].X = originPoint.X + ((_width) / 4) * 1;
            Points[7].Y = originPoint.Y + ((_height) / 2);
        }

        public override GraphicsPath createPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(Points);
            return path;
        }
    }
}
