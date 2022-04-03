using System;

namespace Delegate_DoubleArr_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Product = new double[] { 15.2, 25, 34.6, 54, 67.99, 78 };

            Action<double[]> actcount = GetCount;            
            Action<double[]> acttotal = GetTotal;



            actcount += acttotal;
            actcount(Product);

        }

        public static void GetCount(double[] arr)
        {
            foreach (var num in arr.Length.ToString())
            {
                Console.WriteLine($"ProductCount: {num}");
            }
        }

        public static void GetTotal(double[] arr)
        {
            double total=0;
            foreach (var item in arr)
            {
                total += item;
                
            }
            Console.WriteLine($"ProductTotal: {total}");
        }
        
    }
}
