using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace ProcP.WHobjects
{
    class PathCalculator
    {
        Point StartPoint;
        Point EndPoint;
        List<Point> myPointList;

        // constructor with the start point and endpoint of the path
        public PathCalculator(Point st, Point en)
        {
            StartPoint = st;
            EndPoint = en;
            myPointList = new List<Point>();
        }

        // add every point that needs to be reached to the point list
        public void CalculatePath()
        {
            int count = 0;
            int i = StartPoint.X;
            int j = StartPoint.Y;
            int x = EndPoint.X;
            int y = EndPoint.Y;
            while ( i != x || j != y)
            {
                if (i < x) i++;
                if (i > x) i--;
                if (j < y) j++;
                if (j > y) j--;
                myPointList.Add(new Point(i, j));
            }
            //foreach (var item in myPointList)
            //{
            //    Debug.WriteLine(item.X + " " + item.Y);
            //}
        }

        public List<Point> GetPointList()
        {
            return myPointList;
        }

    }
}

