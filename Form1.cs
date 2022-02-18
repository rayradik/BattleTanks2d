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
            tank = new Player(12,223,60,50);
            this.Text = "Flappy ball Score: 0";
            timer1.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(tank.FigureImage, tank.X, tank.Y, tank.SizeX, tank.SizeY);
        }
        private void Update(object sender, EventArgs e)
        {
            tank.X += 3;
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
