using System;

namespace Zadanie_1
{
    class Vector
    {
        private int x, y, z;

        public Vector(int x, int y, int z)
        {
            setX(x);
            setY(y);
            setZ(z);
        }

        private void setX(int _x)
        {
            this.x = _x;
        }

        private void setY(int _y)
        {
            this.y = _y;
        }

        private void setZ(int _z)
        {
            this.z = _z;
        }
    }
}
