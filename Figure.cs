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
        public string Tag { get; set; }
        public Figure()
        {

        }
        public Figure(string tag, float sizeX, float sizeY)
        {
            Tag = tag;
            SizeX = sizeX;
            SizeY = sizeY;
        }
        public Figure(float x, float y, float sizeX, float sizeY)
        {
            X = x;
            Y = y;
            SizeX = sizeX;
            SizeY = sizeY;
        }
        public Figure(string tag,float x, float y, float sizeX, float sizeY)
        {
            Tag = tag;
            X = x;
            Y = y;
            SizeX = sizeX;
            SizeY = sizeY;
        }
        public virtual void Move()
        {
            X -= 5;
        }
        public virtual void SpawnX()
        {
            X += 865;
        }
        public virtual void SpawnYRandom()
        {
            Random rnd = new Random();
            Y = rnd.Next(100, 295);
        }
    }
}

