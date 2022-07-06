namespace GeekBrains
{
    class Program
    {
        // Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
        static void Main(string[] args)
        {
            Resume name = new Resume();           
            Console.WriteLine($"Привет {name.nameUser}");
            Console.WriteLine("Сейчас "  + DateTime.Now);
            for ( ; ; )
            {
            Console.WriteLine ("Эта программа предназначенна для определения суммы элементов в введеном числе");
            Console.WriteLine ("Пожалуйста, введите число");
            int summ = ForeachNumberSumm();
            Console.WriteLine($"Сумма элементов числа составляет {summ}"); 
            Console.WriteLine ("Для выхода из программы зажмите клавиши <Ctrl>+<C>");
            }
        }
        // Метод перебора числа и определения суммы его элементов
        static int ForeachNumberSumm ()
        {
            string collection = Console.ReadLine();
            int result = 0;
            foreach (char number in collection)
            {
                // Преобразование символа "number" в строку и затем в число
                int numberToInt = int.Parse(Convert.ToString(number));
                result = result + numberToInt;
            }
            return result; 
        }
    }
    class Resume
    {
        public string nameUser = "User";
    }
}
