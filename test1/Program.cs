using System;
using System.Linq;

namespace test1
{
    public struct Data
    {
        public int Value { get; set; }
    }

    
    public static class Program
    {
        public static Data Scale(ref Data d, int s)
        {
            d.Value *= s;
            return d;
        }
        // private static DateTime dt;
        static void Main(string[] args)
        {
            //int result = new object[] { 2, null, 1, "4", 3, 6, 7.7, (dt == null ? 10 : 9) }
            //.Select(Convert.ToInt32)
            //.Where(x => (x % 2) == 0)
            //.Concat(new[] { 0, 1, 2 })
            //.Sum();
            //Console.WriteLine(result);
            //Console.ReadLine();
            var d1 = new Data { Value = 2 };
            var d2 = d1;
            d2.Value = 3;
            var d3 = Scale(ref d2, 10);
            Scale(ref d3, 10);
            Console.WriteLine(d1.Value + "  " + d2.Value + " " + d3.Value);
            Console.ReadLine();
        }
    }
}
