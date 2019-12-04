using algorithm;
using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { 9.54f, 8.45f, 7.45f, 6.45f, 5.45f, 5.45f, 4.45f, 3.45f, 2, 1, 1 };
            QSort<double> qSort = new QSort<double>(arr);
            DateTime beforDT = DateTime.Now;

            qSort.Sort();
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            DateTime afterDT = DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);

            
           
            Console.Read();
        }
    }
}
