using algorithm;
using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 9.54f, 8.45f, 7.45f, 6.45f, 5.45f, 5.45f, 4.45f, 3.45f, 2, 1, 1 };
            QSort<float> qSort = new QSort<float>(arr);
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
