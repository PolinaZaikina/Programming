﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shape
    {
        public Point TopLeft { get; set; }
        public double Width { get; set; }
        public double Height{
            get; set;
        }
        public Rectangle(double x, double y, double width, double height)
        { TopLeft= new Point(x,y)}
}
