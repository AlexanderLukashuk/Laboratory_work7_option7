using System;

namespace Task7v7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            string input;
            int step = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                while(numbers[i] == numbers[i + step])
                {
                    
                }
            }
        }
    }
}
