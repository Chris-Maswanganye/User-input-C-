using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string Name;

            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have entered:Name: " + Name + " Age: " + Age);

        }
    }
}
