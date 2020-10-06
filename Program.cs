using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            string num=Console.ReadLine();
            int num1 = Int32.Parse(num);
            Console.WriteLine(num1);
            int num2 = Convert.ToInt32(num);
            Console.WriteLine(num2);
            string s = "123lk";
            bool res;
            int num3;
            res=int.TryParse(s,out num3);
            Console.WriteLine(res);
            Console.WriteLine(num3);
            Console.ReadLine();
        }
    }
}
