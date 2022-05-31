using System;

namespace GuessingGameThreeTr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(1, 11);
            int count = 1;
            Console.WriteLine("Try guess random number!");
            Console.WriteLine("Enter the number:");
            int k = Convert.ToInt32(Console.ReadLine());
            while (count <= 3)
            {

                if (i == k)
                {
                    Console.WriteLine("Yes!You WIN! Random number is " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("You did not guess right :( . Random number is " + i + "!");
                        break;
                    }
                    Console.WriteLine("Not, it is not number " + k + "! Attempt number " + count + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}
