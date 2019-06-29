using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPL_application
{
    /// <summary>
    /// The main ShapesFactory factory class
    /// </summary>
    class ShapesFactory
    {
        public Shapes GetShapes(String shapetype)
        {
            if (shapetype == "rectangle")
            {
                return new Rectangle();
            }
            else if (shapetype == "circle")
            {
                return new Circle();
            }
            else if (shapetype == "line")
            {
                return new Line();
            }
            else if (shapetype == "triangle")
            {
                return new Triangle();
            }
            else if (shapetype == "polygon")
            {
                return new Polygon();
            }
            return null;
        }
    }
}
