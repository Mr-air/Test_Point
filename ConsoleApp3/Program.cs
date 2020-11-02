using System;


namespace ConsoleApp3
{
    class Point
    {
        int x, y, z;
        public Point(int x=1, int y=1, int z=1)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetZ()
        {
            return this.z;
        }
    }





    class Program
    {
       static double DistancePoint(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.GetX()-p1.GetX(),2) + Math.Pow(p2.GetY() - p1.GetY(), 2)+ Math.Pow(p2.GetZ() - p1.GetZ(), 2));
        
        }
        static void Main(string[] args)
        {
            Point a = new Point();
            Point b = new Point(2, 2, 2);
            Console.WriteLine("Растояние между точками = " + DistancePoint(a, b));
            Console.ReadKey(true);




        }
    }
}
