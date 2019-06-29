using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GPL_application
{
    /// <summary>
    /// Abstract class Shapes which is further extended by other shape classes
    /// </summary>
    abstract class Shapes
    {
        public abstract void draw(Graphics g);
        public abstract void set(Color col,params int[] list );
        
    }
}
