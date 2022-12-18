using System;

namespace project_2
{
    class Program
    {
        public static int find_perfectnumbers(int input)
        {
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;

        }



        static void Main(string[] args)
        {


            Console.Write("please enter the first number : ");
            int firstnum = int.Parse(Console.ReadLine());

            Console.Write("please enter the second number : ");
            int secondnum = int.Parse(Console.ReadLine());

            for (int input = firstnum; input < secondnum; input++)
            {
                int result = find_perfectnumbers(input);
                if (input == result)
                {
                    Console.WriteLine(input + " is perfect number");

                }


            }


























        }
    }
}
