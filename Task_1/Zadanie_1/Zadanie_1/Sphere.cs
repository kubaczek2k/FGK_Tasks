using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1
{
    class Sphere
    {
        public int r { get; private set; }
        private Vector vector;

        public Sphere(int x, int y, int z, int r)
        {
            vector = new Vector(x, y, z);
            this.r = r;
        }

        //TODO: implement function to know if there was crossing point/s of sphere and line
        public int countDiscriminant()
        {
            //TODO: placeholer, to be changed to true value
            return 0;
        }
    }
}
