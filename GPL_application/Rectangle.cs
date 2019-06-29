using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GPL_application
{
    /// <summary>
    /// Rectangle class which extends the Shapes class
    /// </summary>
    class Rectangle : Shapes
    {
        int x, y, size1, size2;
        Color col;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(col, 2);
            g.DrawRectangle(p, x, y, size1, size2);
        }
        public override void set(Color col,params int[] list)
        {
            this.col = col;
            this.x = list[0];
            this.y = list[1];
            this.size1 = list[2];
            this.size2 = list[3];
        }
    }
}
