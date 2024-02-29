using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DrawStar
{
    internal class Star
    {
        public int pointNumber;
        public int penDifference;
        public PointF[] pointList;
        public SolidBrush brush;
        public Pen pen;

        public int objectScaleOut;
        public int objectScaleIn;
        public PointF objectAxis;
        public int starSpeed = 1;

        Random random = new Random();


        double time = 0;
        double rotation = 0;
        double orbitRotation = 0;
        PointF orbit;
        double radiusFromCentre;
        double originalAngle;
        public Star(int _pointNumber, int _objectScaleIn, int _objectScaleOut, int _penDifference, int _starSpeed, PointF _objectAxis, PointF _orbit)
        {
            pointNumber = _pointNumber;
            penDifference = _penDifference;
            objectScaleOut = _objectScaleOut;
            objectScaleIn = _objectScaleIn;
            penDifference = _penDifference;

            Color randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            brush = new SolidBrush(randomColor);
            randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            pen = new Pen(randomColor);

            orbit = _orbit;
            originalAngle = Math.Atan((orbit.Y - objectAxis.Y) / (orbit.X - objectAxis.X));

            pointList = new PointF[_pointNumber * 2];
            objectAxis = _objectAxis;
            starSpeed = _starSpeed;
        }

        public void Flicker()
        {
            time += 0.1 + (2 / (radiusFromCentre + 0.1));
            objectScaleOut += (int)(Math.Sin(time) * 5);
            objectScaleIn += (int)(Math.Cos(time) * 5);

        }
        public void FindStarPoints()
        {
            for (int i = 0; i < pointList.Length; i++)
            {
                int inOrOut = objectScaleOut;
                if ((i % 2) != 0)
                {
                    inOrOut = objectScaleIn;
                }
                pointList[i] = GeneratePoint(((2 * Math.PI / pointList.Length) * (i)) + rotation, inOrOut);
            }
        }
        PointF GeneratePoint(double theta, double radius)
        {
            float pointx = (float)((radius * Math.Cos(theta)) + objectAxis.X);
            float pointy = (float)((radius * Math.Sin(theta)) + objectAxis.Y);
            return (new PointF(pointx, pointy));
        }

        public void RotateStar()
        {
            rotation += 0.01;
        }

        public void OrbitStar()
        {
            radiusFromCentre = Math.Sqrt(((orbit.X - objectAxis.X) * (orbit.X - objectAxis.X)) + ((orbit.Y - objectAxis.Y) * (orbit.Y - objectAxis.Y)));
            orbitRotation -= (2 / (radiusFromCentre + 0.1));
            float xChange = (float)(radiusFromCentre * Math.Cos(orbitRotation + originalAngle));
            float yChange = (float)(radiusFromCentre * Math.Sin(orbitRotation + originalAngle));

            objectAxis = new PointF(xChange + orbit.X, yChange + orbit.Y);
        }
    }
}
