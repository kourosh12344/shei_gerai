

using System;
namespace Project
{
    class test1
    {
        private double a;
        private double b;
        private double alfa;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
            }

        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
            }
        }
        public double Alfa
        {
            get { return alfa; }
            set
            {
                if (value > 0)
                    alfa = value;
            }
        }

        public test1() { }//mokhareb
        public test1(double in1, double in2, double in3)
        {
            A = in1;
            B = in2;
            Alfa = in3;

        }
        public double show()
        {
            double result;
            result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(alfa)));
            return result;
        }
        class test2
        {
            public static void Main()
            {
                Console.WriteLine("enter a:");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter b:");
                double B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter alfa:");
                double alfa = Convert.ToDouble(Console.ReadLine());
                test1 ts = new test1(A, B, alfa);
                double res = ts.show();
                Console.WriteLine(res);


            }
        }


    }
}









