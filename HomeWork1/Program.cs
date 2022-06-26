namespace HelloWorld
{
    class Program
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. (a = 5; b = 7 -> max = 7) (a = 2 b = 10 -> max = 10) (a = -9 b = -3 -> max = -3)
        static void Main(string[] args)
        {
            Console.WriteLine ("Привет, эта программа пожет тебе сравнить 2 числа и найти наибольшее");
            Console.WriteLine ("Введи пожалуйста первое число");
            // 1. Блок ввода входных данных
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Введи пожалуйста второе число");
            double number2 = Convert.ToInt32(Console.ReadLine());
            // 2. Блок сравнения
            double max = number1;
            if (number1 > number2)
            {
                Console.WriteLine (max);
            }
            else
            {
                max = number2;
                Console.WriteLine ($"Наибольшее число: {max}");
            }
        }
    }
}
