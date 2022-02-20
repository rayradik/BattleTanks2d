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
        public void MoveUpDown(bool up, bool down, int speed)
        {
            if (up)
            {
                Y -= 4 + speed;
            }
            if (down)
            {
                Y += 4 + speed;
            }
        }
        public bool Pop(Timer timer1)
        {
            Alive = false;
            timer1.Stop();

            Form form1 = Application.OpenForms["Form1"];
            Form form2 = Application.OpenForms["Start"];

            DialogResult vibor2 = MessageBox.Show("Счет: " + Score + "\nХотите начать заново?", "Вы проиграли!", MessageBoxButtons.YesNo);
            if (vibor2 == DialogResult.No)
            {
                form1.Close();
                form2.Show();
                return false;
            }
            else
                return true;
        }
    }
}
