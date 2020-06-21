using System;

namespace Zadanie_1
{
    class Vector
    {

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int x { get; private set; }
        public int y { get; private set; }
        public int z{ get; private set; }
    }
}
