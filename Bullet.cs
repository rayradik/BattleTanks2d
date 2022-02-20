using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleTanks2d
{
    class Bullet : Figure
    {
        public bool Active { get; set; }
        public Bullet()
        {

        }
        public Bullet(string tag, float sizeX, float sizeY) : base(tag, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\bullet.png");
        }
        public Bullet(float x, float y, float sizeX, float sizeY) : base(x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\bullet.png");
        }
        public Bullet(string tag, float x, float y, float sizeX, float sizeY) : base(tag, x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\bullet.png");
        }
        public virtual void  AddBulletToPlayerTank(Player tank, Bullet bullet)
        {
            bullet.X = tank.X + 65;
            bullet.Y = tank.Y + 21;
        }
        public override void Move(int speedUp)
        {
            MoveSpeedUp = speedUp;
            X += 8 + MoveSpeedUp;
        }
    }
}
