using System;
namespace EnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 8 >> 5;
            Console.WriteLine(i);

            int? j = i > 0 ? i : null;
            if (!j.HasValue) Console.WriteLine("j is null");
            else Console.WriteLine(j);

            var a = j ?? int.MinValue;
            Console.WriteLine(a.ToString());

        }
    }
}