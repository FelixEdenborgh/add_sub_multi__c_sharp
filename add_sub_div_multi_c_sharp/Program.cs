using System;

namespace add_sub_div_multi_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, add, sub, div, multi;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter secound number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have enterd the numbers :" + num1 + " " + num2 + " " +num3);

            add = num1 + num2 + num3;
            sub = num1 - num2 - num3;
            div = num1 / num2 / num3;
            multi = num1 * num2 * num3;

            Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " = " + add);
            Console.WriteLine(num1 + " - " + num2 + " - " + num3 + " = " + sub);
            Console.WriteLine(num1 + " / " + num2 + " / " + num3 + " = " + div);
            Console.WriteLine(num1 + " * " + num2 + " * " + num3 + " = " + multi);
        }
    }
}
