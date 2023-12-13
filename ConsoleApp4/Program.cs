using System;

namespace Solution1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[,] RandomNumbers;
            int sum = 0;
            Random rnd = new Random();
            
            Console.Write("Введите количество строк: ");
            int hor = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int vert = int.Parse(Console.ReadLine());

            if (hor > 0 && vert > 0)
            {
                RandomNumbers = new int[hor, vert];

                // 1 задание
                Console.WriteLine("Матрица 1");
                for (int i = 0; i < vert; i++)
                {
                    for (int j = 0; j < hor; j++)
                    {
                        RandomNumbers[j, i] = rnd.Next(10);
                        Console.Write($"{RandomNumbers[j, i]} ");
                        sum += RandomNumbers[j, i];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine($"Сумма всех элементов {sum}");
                Console.WriteLine();
                Console.ReadKey();

                // 2 задание
                Console.WriteLine("Матрица 2");
                Console.WriteLine();
                int[,] RandomNumbersSecond = new int[RandomNumbers.GetLength(0), RandomNumbers.GetLength(1)];

                for (int i = 0; i < vert; i++)
                {
                    for (int j = 0; j < hor; j++)
                    {
                        RandomNumbersSecond[j, i] = rnd.Next(10);
                        Console.Write($"{RandomNumbersSecond[j, i]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //Сумма матриц
                int[,] MatrixSum = new int[RandomNumbers.GetLength(0), RandomNumbers.GetLength(1)];

                Console.WriteLine("Сумма матриц");
                Console.WriteLine();
                for (int i = 0; i < vert; i++)
                {
                    for (int j = 0; j < hor; j++)
                    {
                        MatrixSum[j, i] = RandomNumbers[j, i] + RandomNumbersSecond[j, i];
                        Console.Write($"{MatrixSum[j, i]} ");
                    }
                    Console.WriteLine();
                }
            }       
            else
            {
                Console.WriteLine("Данные введены неверно");
            }            
            Console.ReadKey();
        }
    }
}
