using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Rectangle
    {
        public int posX;
        public int posY;

        public int PosY { get => posY; set => posY = value; }
        public int PosX { get => posX; set => posX = value; }

        public Rectangle() {
            posX = 0;
            posY = 0;
        }
    }
}
