using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "apple", "orange", "pineapple" };
            string[] arr2 = { "apple", "orange", "Pineapple" };

            //Console.WriteLine(arr1 == arr2);
            //Console.WriteLine(arr1.Equals(arr2));
            var arrayEq = (IStructuralEquatable)arr1;
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structEqual);
        }
    }
}
