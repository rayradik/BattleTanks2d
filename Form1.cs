using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BattleTanks2d
{
    public partial class Form1 : Form
    {
        Player tank;
        Block[] blocks;
        Bullet bullet;
        BulletE[] bulletsE;
        Enemy[] enemies;
        bool up, down, space;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Tick += new EventHandler(Update);
            Init();
            Invalidate();
        }
        public void Init()
        {
            tank = new Player(12, 223, 70, 60);

            blocks = new Block[6];
            blocks[0] = new Block(70, 45, 65, 55);
            blocks[1] = new Block(70, 350, 65, 55);
            blocks[2] = new Block(480, 45, 65, 55);
            blocks[3] = new Block(480, 350, 65, 55);
            blocks[4] = new Block("blockM", 280, 185, 70, 65);
            blocks[5] = new Block("blockM", 720, 185, 70, 65);

            bullet = new Bullet("bulletP", 22, 18);
            bulletsE = new BulletE[2];
            bulletsE[0] = new BulletE("bulletE", 16, 11);
            bulletsE[1] = new BulletE("bulletE", 16, 11);

            enemies = new Enemy[2];
            enemies[0] = new Enemy(450, 45, 50, 45);
            enemies[1] = new Enemy(500, 350, 50, 45);

            this.Text = "Flappy ball Score: 0";
            AddBulletToEnemies(enemies);
            timer1.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(tank.FigureImage, tank.X, tank.Y, tank.SizeX, tank.SizeY);
            for (int i = 0; i < 6; i++)
            {
                graphics.DrawImage(blocks[i].FigureImage, blocks[i].X, blocks[i].Y, blocks[i].SizeX, blocks[i].SizeY);
            }
            if (fire == false && bullet.Active == true)
            {
                graphics.DrawImage(bullet.FigureImage, bullet.X, bullet.Y, bullet.SizeX, bullet.SizeY);
            }
            graphics.DrawImage(enemies[0].FigureImage, enemies[0].X, enemies[0].Y, enemies[0].SizeX, enemies[0].SizeY);
            graphics.DrawImage(enemies[1].FigureImage, enemies[1].X, enemies[1].Y, enemies[1].SizeX, enemies[1].SizeY);

            graphics.DrawImage(bulletsE[0].FigureImage, bulletsE[0].X, bulletsE[0].Y, bulletsE[0].SizeX, bulletsE[0].SizeY);
            graphics.DrawImage(bulletsE[1].FigureImage, bulletsE[1].X, bulletsE[1].Y, bulletsE[1].SizeX, bulletsE[1].SizeY);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Down:
                    down = false;
                    break;
                case Keys.Space:
                    space = false;
                    break;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    up = true;
                    break;
                case Keys.Down:
                    down = true;
                    break;
                case Keys.Space:
                    space = true;
                    break;
            }
        }
        bool fire = true;
        private void Update(object sender, EventArgs e)
        {
            if (tank.Collide(blocks[0]))
            {
                timer1.Stop();
            }
            if (space && fire == true)
            {
                bullet.AddBulletToPlayerTank(tank, bullet);
                bullet.Active = true;
                fire = false;
            }
            if (fire == false && bullet.Active == true)
            {
                if (bullet.X > 350)
                {
                    bullet.Active = false;
                    fire = true;
                }
                bullet.Move();
            }

            tank.MoveUpDown(up, down);
            MoveBlocks(blocks);
            MoveEnemies(enemies);
            MoveEnemiesBullets(bulletsE);
            AddBulletToEnemies(enemies);
            Invalidate();
        }

        private void MoveBlocks(Block[] blocks)
        {
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i].Move();
                if (blocks[i].X < -65)
                {
                    if (blocks[i].Tag == "blockM")
                    {
                        blocks[i].SpawnX();
                        blocks[i].SpawnYRandom();
                    }
                    else
                    {
                        blocks[i].SpawnX();
                    }
                }
            }
        }
        private void MoveEnemies(Enemy[] enemies)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Move();
                if (enemies[i].X < -65)
                {
                    enemies[i].SpawnX();
                    enemies[i].SpawnYRandom();
                }
            }
        }
        private void AddBulletToEnemies(Enemy[] enemies)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (bulletsE[i].Tag == "bulletE")
                {
                    if(bulletsE[i].X < -18)
                    {
                        bulletsE[i].AddBulletToTank(enemies[i], bulletsE[i]);
                    }
                }
            }
        }
        private void MoveEnemiesBullets(BulletE[] bulletsE)
        {
            for (int i = 0; i < bulletsE.Length; i++)
            {
                if (bulletsE[i].Tag == "bulletE")
                {
                    bulletsE[i].Move();
                }
            }
        }
    }
}
