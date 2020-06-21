using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zadanie_1
{
    class Plane
    {
        private Vector centralPoint;

        public Plane(int xCentral, int yCentral, int zCentral)
        {
            centralPoint = new Vector(xCentral, yCentral, zCentral);
        }
    }
}
