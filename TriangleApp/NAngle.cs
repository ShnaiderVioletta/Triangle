namespace TriangleApp
{
    public class NAngle
    {
        public Point[] Points;

        public NAngle(Point[] points)
        {
            Points = points;
        }

        public double GetPerimeter()
        {
            int n = Points.Length;

            Edge[] edges = new Edge[n];

            for (int i = 0; i < n; i++)
            {
                Edge edge = new Edge(Points[i], i != n-1 ? Points[i + 1] : Points[0]);
                edges[i] = edge;
            }

            double p = 0;

            for (int i = 0; i < n; i++)
            {
                p += edges[i].GetLenght();
            }

            return p;
        }
    }
}
