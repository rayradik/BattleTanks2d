using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BattleTanks2d
{
    class Figure
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float SizeX { get; set; }
        public float SizeY { get; set; }
        public Image FigureImage { get; set; }
        public Figure()
        {

        }
        public Figure(float x, float y, float sizeX, float sizeY)
        {
            X = x;
            Y = y;
            SizeX = sizeX;
            SizeY = sizeY;
        }
        public void Move()
        {
            X -= 8;
        }
    }
}

