using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleTanks2d
{
    class Wall : Figure
    {
        public Wall()
        {

        }
        public Wall(float x, float y, float sizeX, float sizeY) : base(x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\wall.png");
        }

        public Wall(string tag, float x, float y, float sizeX, float sizeY) : base(tag, x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\wall.png");
        }
    }
}
