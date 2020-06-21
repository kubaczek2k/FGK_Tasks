using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1
{
    class Radius
    {
        private Vector startPoint;
        private Vector direction;

        public Radius(int xStart, int yStart, int zStart, int xDirection, int yDirection, int zDirection)
        {
            startPoint = new Vector(xStart, yStart, zStart);
            direction = new Vector(xDirection, yDirection, zDirection);
        }

        public Vector GetStartPoint() { return this.startPoint; }
        public Vector GetDirection() { return this.direction; }

        public string ToString(string name)
        {
            return "StartPoint(" + startPoint.x.ToString() + "," + startPoint.y.ToString() + "," + startPoint.z.ToString() + ") of " + name + " Direction(" + direction.x.ToString() + "," 
                + direction.y.ToString() + "," + direction.y.ToString() + ") of " + name;
        }
    }
}
