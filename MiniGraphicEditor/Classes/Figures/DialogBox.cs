﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MiniGraphicEditor.Classes.Figures
{
    class DialogBox : Figure
    {

        public DialogBox()
        {
            _points = new PointF[7];
        }

        public override void calculatePoints(PointF originPoint, PointF endPoint)
        {
            float width = endPoint.X - originPoint.X;
            float height = endPoint.Y - originPoint.Y;

            Points[0].X = originPoint.X;
            Points[0].Y = originPoint.Y;
            Points[1].X = Points[0].X + width / 2;
            Points[1].Y = Points[2].Y = Points[5].Y = Points[6].Y = Points[0].Y + height / 4;
            Points[2].X = Points[3].X = endPoint.X;
            Points[3].Y = Points[4].Y = endPoint.Y;
            Points[4].X = Points[5].X = Points[0].X + width / 5;
            Points[6].X = Points[0].X + width / 3;

        }

    }
}
