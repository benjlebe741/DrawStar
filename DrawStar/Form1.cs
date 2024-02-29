using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        List<Star> starList = new List<Star>();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int randomStarAdd = random.Next(1, 20);
            if (randomStarAdd == 1)
            {
                createStar();
            }


            PointF orbit = new PointF(0,0);
            foreach (Star star in starList)
            {
                star.Flicker();
                star.FindStarPoints();
                star.RotateStar();
                star.OrbitStar();
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Star star in starList)
            {
                e.Graphics.FillPolygon(star.brush, star.pointList);
                e.Graphics.DrawPolygon(star.pen, star.pointList);
            }
        }

        void createStar()
        {
            int starIn = random.Next(2, 50);
            int starOut = starIn + random.Next(2, 50);
            Star newStar = new Star(random.Next(2, 30), starIn, starOut, 2, random.Next(1, 10), new PointF(random.Next(0, this.Width), random.Next(0, this.Height)), new PointF(this.Width / 2, this.Height / 2));
            starList.Add(newStar);
        }



        private void buildStarButton_Click(object sender, EventArgs e)
        {
        }
    }
}
