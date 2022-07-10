﻿namespace GeekBrains
{
    class Program
    {
        // Задайте одномерный массив, заполненный случайными числами. 
        // Найдите сумму элементов, стоящих на нечётных позициях.
        static void Main(string[] args)
        {
            ConsoleKeyInfo esc = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine ("Эта програма поможет посчитать сумму элементов случайно сгененерированного массива, стоящих на нечетных позициях");
                Console.WriteLine ("Пожалуйста, введите целое число для формирования нижней границы случайной размерности массива");
                int minValyeSize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine ("Пожалуйста, введите целое число для формирования вверхней границы случайной размерности массива");
                int maxValyeSize = Convert.ToInt32(Console.ReadLine()) + 1;
                Console.WriteLine ("Пожалуйста, введите целое число для формирования нижней границы случайных значений массива");
                int minValyeNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine ("Пожалуйста, введите целое число для формирования вверхней границы случайных значений массива");
                int maxValyeNumber = Convert.ToInt32(Console.ReadLine()) + 1;
                int[] array = NewFillRandomArray(minValyeSize, maxValyeSize, minValyeNumber, maxValyeNumber);
                PrintArray(array);
                int result = SummElementOddPositionArray(array);
                Console.WriteLine ($"Сумма элементов массива, стоящих на нечетных позициях составляет: {result}");
                Console.WriteLine();
                Console.WriteLine ("Нажмите клавишу <Esc> для выхода или любую другую для продолжения");
                esc = Console.ReadKey();
                Console.Clear();
            }
            while (esc.Key != ConsoleKey.Escape);

        // Метод заполнения массива случайной размерности из случайных чисел в веденом жиапозоне
            int[] NewFillRandomArray(int minValyeSize, int maxValyeSize, int minValyeNumber, int maxValyeNumber)
            {              
                int[] arrayRandom = new int [new Random().Next(minValyeSize, maxValyeSize)];
                for (int i = 0; i < arrayRandom.Length; i++)
                {
                    arrayRandom[i] = new Random().Next(minValyeNumber, maxValyeNumber);
                }
                Console.WriteLine ("Ваш случайный массив сформирован");
                return arrayRandom;
            }
            
            // Метод печати массива
            void PrintArray(int[] array)
            {       
                Console.WriteLine ("Ваш массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
            
            // Метод определения суммы элементов, стоящих на нечетных позициях в массиве
            int SummElementOddPositionArray(int[] array)
            {       
                int summ = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int remainder = i % 2;
                    if (remainder != 0)
                    {
                        summ = summ + array[i];
                    }
                }
                return summ;
            }
        }     
    }
}