using System;

namespace TriangleApp
{
    public class Triangle
    {
        public Point p1, p2, p3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Triangle(Point[] points)
        {
            p1 = points[0];
            p2 = points[1];
            p3 = points[2];
        }
        

        public double GetPerimeter()
        {
            Edge edge1 = new Edge(p1, p2);
            Edge edge2 = new Edge(p1, p3);
            Edge edge3 = new Edge(p2, p3);

            double p = edge1.GetLenght() + edge2.GetLenght() + edge3.GetLenght();

            return p;
        }

        public double GetSquare()
        {
            Edge edge1 = new Edge(p1, p2);
            Edge edge2 = new Edge(p1, p3);
            Edge edge3 = new Edge(p2, p3);

            double a = edge1.GetLenght();
            double b = edge2.GetLenght();
            double c = edge3.GetLenght();

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return S;
        }

        public bool IsRight()
        {
            Edge edge1 = new Edge(p1, p2);
            Edge edge2 = new Edge(p1, p3);
            Edge edge3 = new Edge(p2, p3);

            double a = edge1.GetLenght();
            double b = edge2.GetLenght();
            double c = edge3.GetLenght();

            return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);
        }

        public bool IsIsosceles()
        {
            Edge edge1 = new Edge(p1, p2);
            Edge edge2 = new Edge(p1, p3);
            Edge edge3 = new Edge(p2, p3);

            double a = edge1.GetLenght();
            double b = edge2.GetLenght();
            double c = edge3.GetLenght();

            return a == b || a == c || b == c;
        }
    }
}
