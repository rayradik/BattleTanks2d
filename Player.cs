using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleTanks2d
{
    class Player : Figure
    {

        //Property structure
        public bool Alive { get; set; }
        public int Score { get; set; }
        //Constructor
        public Player()
        {

        }
        public Player(float x, float y, float sizeX, float sizeY) : base(x,y,sizeX,sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\Tank1.png");
            Alive = true;
            Score = 0;
        }
    }
}
