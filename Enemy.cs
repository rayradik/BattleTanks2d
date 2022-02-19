using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleTanks2d
{
    class Enemy : Figure
    {
        public Enemy()
        {

        }
        public Enemy(float x, float y, float sizeX, float sizeY) : base(x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\Enemy.png");
        }

        public Enemy(string tag, float x, float y, float sizeX, float sizeY) : base(tag, x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\Enemy.png");
        }

        public override void SpawnYRandom()
        {
            Random rnd = new Random();
            Y = rnd.Next(50, 330);
        }
        public override void Move()
        {
            X -= 6;
        }
    }
}
