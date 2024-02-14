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
        int POINT_NUMBER = 27;
        const int PEN_DIFFERENCE = 1;
        PointF[] pointList;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        Pen blackPen;

        int OBJECT_SCALE_OUT = 70;
        int OBJECT_SCALE_IN = 30;
        PointF objectAxis;

        double rotation = 0;
        public Form1()
        {
            InitializeComponent();
            PositionStar();
            blackPen = new Pen(Color.Black, PEN_DIFFERENCE);
        }

        void PositionStar()
        {
            objectAxis = new PointF(OBJECT_SCALE_OUT + PEN_DIFFERENCE, OBJECT_SCALE_OUT + PEN_DIFFERENCE);
            pointList = new PointF[POINT_NUMBER * 2];
        }

        PointF GeneratePoint(double theta, double radius)
        {
            float pointx = (float)((radius * Math.Cos(theta)) + objectAxis.X);
            float pointy = (float)((radius * Math.Sin(theta)) + objectAxis.Y);
            return (new PointF(pointx, pointy));
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            FindStarPoints();
            RotateStar();
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillPolygon(redBrush, pointList);
            e.Graphics.DrawPolygon(blackPen, pointList);
        }

        private void buildStarButton_Click(object sender, EventArgs e)
        {
            POINT_NUMBER = IntFromTextbox(pointNumberTextBox.Text, POINT_NUMBER);
            OBJECT_SCALE_OUT = IntFromTextbox(outsideRadiusTextBox.Text, OBJECT_SCALE_OUT);
            OBJECT_SCALE_IN = IntFromTextbox(insideRadiusTextBox.Text, OBJECT_SCALE_IN);
            PositionStar();
        }

        int IntFromTextbox(string text, int intStorage)
        {
            if (text != "")
            {
                return (Convert.ToInt32(text));
            }
            else return (intStorage);
        }

        void RotateStar()
        {
            rotation += 0.01;
        }

        void FindStarPoints()
        {
            for (int i = 0; i < pointList.Length; i++)
            {
                int inOrOut = OBJECT_SCALE_OUT;
                if ((i % 2) != 0)
                {
                    inOrOut = OBJECT_SCALE_IN;
                }
                pointList[i] = GeneratePoint(((2 * Math.PI / pointList.Length) * (i)) + rotation, inOrOut);
            }
        }
    }
}
