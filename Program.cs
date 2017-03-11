using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number into The Reverser: ");
            //I only barely understand this, so I wanted to give it an ominous name.
            var number = int.Parse(Console.ReadLine());
            var Reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                //This essentially yields the "ones" digit of the inputted number.
                Reverse = (Reverse * 10) + remainder;
                //The math here tripped me up for a while. I was wanting to multiply
                //the remainder by 10 because I had forgotten it's an INTEGER.
                number = number / 10;
                //This is the number that recycles through the while loop.
            }
            Console.WriteLine("The Reverser gives you: " + Reverse);
            //There is an issue with numbers ending in 0. 
            //The Reverser drops the 0. I need to convert Reverse
            //to a string, but don't know where in the program to do this.
            //Will address before day one of class.
        }
    }
}
