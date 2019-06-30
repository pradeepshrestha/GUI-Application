using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPL_application
{
    /// <summary>
    /// Polygon class which extends teh Shapes class
    /// </summary>
    class Polygon : Shapes
    {
        int x, y, size1, size2, size3, size4, size5, size6, size7, size8;
        Color col;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(col, 2);
            Point[] points = { new Point(x,y), new Point(size1, size2), new Point(size3, size4), new Point(size5, size6), new Point(size7, size8) };
            g.DrawPolygon(p,points);
        }

        public override void set(Color col, params int[] list)
        {
            this.col = col;
            this.x = list[0];
            this.y = list[1];
            this.size1 = list[2];
            this.size2 = list[3];
            this.size3 = list[4];
            this.size4 = list[5];
            this.size5 = list[6];
            this.size6 = list[7];
            this.size7 = list[8];
            this.size8 = list[9];
        }
    }
}
