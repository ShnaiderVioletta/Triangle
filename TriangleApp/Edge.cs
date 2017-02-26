using System;

namespace TriangleApp
{
    public class Edge
    {
        public Point p1;
        public Point p2;

        public Edge(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double GetLenght()
        {
            double a = Math.Sqrt(Math.Pow((p1.X + p2.X), 2.0) + Math.Pow(p1.Y + p2.Y, 2.0));
            return a;
        }
    }
}
