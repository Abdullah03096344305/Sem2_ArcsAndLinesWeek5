using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcsAndLinesWeek5.BL
{
    public class MyPoint
    {
        public int x;
        public int y;

        public MyPoint()
        {
            x = 0;
            y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceWithCords(int x, int y)
        {
            int xDiff = this.x - x;
            int yDiff = this.y - y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        public double DistanceWithObject(MyPoint another)
        {
            int xDiff = this.x - another.x;
            int yDiff = this.y - another.y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        public double DistanceFromZero()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    public class MyLine
    {
        public MyPoint beginPoint;
        public MyPoint endPoint;

        public MyLine(int x1, int y1, int x2, int y2)
        {
            beginPoint = new MyPoint(x1, y1);
            endPoint = new MyPoint(x2, y2);
        }

        public double Length()
        {
            return beginPoint.DistanceWithObject(endPoint);
        }

        public double Gradient()
        {
            int xDiff = endPoint.x - beginPoint.x;
            int yDiff = endPoint.y - beginPoint.y;
            return (double)yDiff / xDiff;
        }
    }
}
