using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BattleTanks2d
{
    class BulletE : Bullet
    {
        public BulletE()
        {

        }
        public BulletE(string tag, float sizeX, float sizeY) : base(tag, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\bullet.png");
        }
        public BulletE(float x, float y, float sizeX, float sizeY) : base(x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\bullet.png");
        }
        public BulletE(string tag, float x, float y, float sizeX, float sizeY) : base(tag, x, y, sizeX, sizeY)
        {
            FigureImage = new Bitmap("C:\\laboratorki\\Tanks\\BattleTanks\\Resources\\bullet.png");
        }
        public override void Move()
        {
            X -= 9;
        }
        public void AddBulletToTank(Enemy tank, Bullet bullet)
        {
            bullet.X = tank.X - 15;
            bullet.Y = tank.Y + 16;
        }
    }
}
