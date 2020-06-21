using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1
{
    class Radius
    {
        private Vector startPoint;
        private Vector direction;
        public int MyProperty { get; private set; }

        public Radius(int xStart, int yStart, int zStart, int xDirection, int yDirection, int zDirection)
        {
            startPoint = new Vector(xStart, yStart, zStart);
            direction = new Vector(xDirection, yDirection, zDirection);
        }
    }
}
