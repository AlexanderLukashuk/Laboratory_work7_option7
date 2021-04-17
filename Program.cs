using System;

namespace Task7v7
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Ввести 20 чисел. Найти произведение тех чисел, порядковые номера которых четные.
            int[] numbers = new int[20];
            string input;
            int composition = 1;

            /*for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    composition *= numbers[i];
                }
            }

            Console.WriteLine($"Произведение чисел с четным порядковым номером = {composition}");*/

            //* 2. Написать программу, которая будет печатать:
            //* 10 тиын; ... 100 тиын. Числа вводятся от 1 до 10.

            int tenge = 0;
            while(tenge < 1 || tenge > 10)
            {
                Console.Write("Введите число от 1 до 10: ");
                input = Console.ReadLine();
                tenge = int.Parse(input);
                if (tenge < 1 || tenge > 10)
                {
                    Console.WriteLine("Введено неправильное число");
                }
            }

            Console.WriteLine($"{tenge} тенге = {tenge * 100} тиын");
        }
    }
}
