using System;

namespace TriangleApp
{
    class Program
    {
        static Triangle[] ReadTriangles(int n)
        {
            Triangle[] triangles = new Triangle[n];
            for (int i = 0; i < n; i++)
            {
                Point[] points = new Point[3];
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write("X{0} = ", j+1);
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Y{0} = ", j+1);
                    int y = int.Parse(Console.ReadLine());

                    points[j] = new Point(x, y);
                }

                triangles[i] = new Triangle(points);
            }
            return triangles;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Кол-во треугольников = ");
            int n = int.Parse(Console.ReadLine());

            Triangle[] triangles = ReadTriangles(n);

            double sum_perimeter = 0;
            int count_right = 0;

            double sum_area = 0;
            int count_isosceles = 0;

            for (int i = 0; i < n; i++)
            {
                if (triangles[i].IsRight())
                {
                    count_right++;
                    sum_perimeter += triangles[i].GetPerimeter();
                }

                if (triangles[i].IsIsosceles())
                {
                    count_isosceles++;
                    sum_area += triangles[i].GetSquare();
                }
            }

            double sred_perimetr = count_right == 0 ? 0 : sum_perimeter / count_right;
            double sred_area = count_isosceles == 0 ? 0 : sum_area / count_isosceles;

            Console.WriteLine("Средний периметр всех прямоугольных треугольников = {0}", sred_perimetr);
            Console.WriteLine("Cредняя площадь всех равнобедренных треугольников = {0}", sred_area);

            Console.ReadKey();
        }
    }
}
