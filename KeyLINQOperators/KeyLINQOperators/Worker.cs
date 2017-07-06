using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLINQOperators
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var listOfInt = new List<int>
            {2, 7, 3, 13, 5, 18, 16};

            var listOfInt2 = new List<int>();

            bool hasAny = listOfInt.Any();
            bool hasAny2 = listOfInt2.Any();
            bool has3 = listOfInt.Any(x => x == 3);
            bool has12 = listOfInt.Any(x => x == 12);

            Console.WriteLine($"Any...");
            Console.WriteLine($"hasAny = {hasAny}");
            Console.WriteLine($"hasAny2 = {hasAny2}");
            Console.WriteLine($"listOfInt has 3 {has3}");
            Console.WriteLine($"listOfInt has 12 {has12}");


        }
    }
}
