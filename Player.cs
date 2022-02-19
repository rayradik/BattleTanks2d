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
        public Player(float x, float y, float sizeX, float sizeY) : base(x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\Tank1.png");
            Alive = true;
            Score = 0;
        }
        public void MoveUpDown(bool up, bool down)
        {
            if (up)
            {
                Y -= 4;
            }
            if (down)
            {
                Y += 4;
            }
        }
        public bool Collide(Figure let)
        {
            float x = (X + SizeX / 2) - (let.X + let.SizeX / 2); //Расстояние между шаром и препятсвием по Х
            float y = (X + SizeY / 2) - (let.Y + let.SizeY / 2); //Расстояние между шаром и препятсвием по У
            if (Math.Abs(X) <= SizeX / 2 + let.SizeX / 2 - 5)
            {
                if (Math.Abs(Y) <= SizeY / 2 + let.SizeY / 2 - 10)
                {
                    return true;   //В данном случае произойдет столкновения
                }
            }
            return false;
        }
    }
}
