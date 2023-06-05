using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public static class Drawer
    {
        public static void DrawCircle(Circle circle)
        { throw new NotImplementedException(); }
        public static void DrawRectangle(Rectangle rectangle)
        { throw new NotImplementedException(); }
        public static void DrawShapes(List<Shape> shapes)
        { 
            foreach(object shape in shapes)
                shape.Draw()
        }

    }
}
