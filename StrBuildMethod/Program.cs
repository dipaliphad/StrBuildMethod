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
            Console.WriteLine("------string builder class-------");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            stringBuilder.Append("My name is dipali");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            Console.WriteLine("------string class------");
            string s1 = "hello to all";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());

            s1 = s1 + "this is sample code";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());
            //StringBuilder stringBuilder = new StringBuilder("hello to all");
            //float salary = 25000.00f;
            //Console.WriteLine(stringBuilder);

            //stringBuilder.Append("My name is dipali");
            //Console.WriteLine(stringBuilder);

            //stringBuilder.AppendFormat("my salary is {0:C}", salary);
            //Console.WriteLine(stringBuilder);

            //stringBuilder.Insert(10, "Hii");
            //Console.WriteLine(stringBuilder);

            //stringBuilder.Replace("dipali", "Dipu");
            //Console.WriteLine(stringBuilder);

            //stringBuilder.Remove(10, 5);
            //Console.WriteLine(stringBuilder);
        }
    }
}
