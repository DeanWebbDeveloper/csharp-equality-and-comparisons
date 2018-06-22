using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Operator: " + AreIntsEqualOp(3, 3));
            Console.Write("Method: " + AreIntsEqualMethod(3, 3));
        }

        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y;
        }

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y);
        }
    }
}
