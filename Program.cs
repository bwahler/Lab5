using System;

namespace Lab_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number from 1 to 20:");
                long userNum = long.Parse(Console.ReadLine());
                long result = userNum;
                long i;

                for (i = userNum - 1; i > 1; i--)
                {
                    userNum *= i;
                }

                Console.WriteLine(userNum);
                Console.WriteLine("Would you like to continue (y/n):");

                string valid = Console.ReadLine();

                if (valid == "y")
                {
                    continue;
                }
                if (valid == "n")
                {
                    break;
                }
            }
        }
    }
}
