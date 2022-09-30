using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrBuildMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("hello to all");
            float salary = 25000.00f;
            Console.WriteLine(stringBuilder);

            stringBuilder.Append("My name is dipali");
            Console.WriteLine(stringBuilder);

            stringBuilder.AppendFormat("my salary is {0:C}", salary);
            Console.WriteLine(stringBuilder);

            stringBuilder.Insert(10, "Hii");
            Console.WriteLine(stringBuilder);

            stringBuilder.Replace("dipali", "Dipu");
            Console.WriteLine(stringBuilder);

            stringBuilder.Remove(10, 5);
            Console.WriteLine(stringBuilder);
        }
    }
}
