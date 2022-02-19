using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleTanks2d
{
    class Block : Figure
    {
        public Block()
        {

        }
        public Block(float x, float y, float sizeX, float sizeY) : base(x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\block.png");
        }

        public Block(string tag, float x, float y, float sizeX, float sizeY) : base(tag, x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\block.png");
        }
    }
}
