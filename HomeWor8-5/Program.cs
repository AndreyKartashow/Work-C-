namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк уникального массива");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов уникального массива");
            int row = Convert.ToInt32(Console.ReadLine());
            int sizeList = str * row;
            List<int> listNumber = new List<int>();

            while (listNumber.Count != sizeList)
            {
                listNumber.Add(new Random().Next(1, sizeList + 1));
                listNumber = listNumber.Distinct().OrderBy(n => n).ToList();
                PrintList(listNumber);
            }

            int[,] arrayUnic = new int[str, row];
            int k = 0;                                                  // текущий элемент коллекции
            int i = 0;                                                  
            int j = 0;

            int m = 0;                                                  // количество заполненых строк
            int n = 0;                                                  // количество заполненых столбиков

            int lengthString = arrayUnic.GetLength(1);                  // длина строки                 4
            int lengthRow = arrayUnic.GetLength(0);                     // длина столбика               4
            PrintArray(arrayUnic);
            Console.WriteLine();

            while (k != sizeList)
            {
                for (j = 0; j < lengthString; j++)
                {
                    arrayUnic[m, n + j] = listNumber[k];
                    k++;
                }
                m++;                                                    // заполненых строк             1   

                for (i = 0; i < lengthRow - m; i++)
                {
                    arrayUnic[m + i, lengthString - m] = listNumber[k];
                    k++;
                }
                n++;                                                    // заполненых столбиков         1
                k++;

                for (j = 0; j < lengthString - n; j++)   
                {
                    arrayUnic[lengthRow - m, lengthString - j - n - 1] = listNumber[k-1];
                    k++;
                }
                m++;                                                    // заполненых строк             2
                

                for (i = 0; i < lengthRow - m; i++)
                {
                    arrayUnic[lengthRow - m - i, n - 1] = listNumber[k-1];
                    k++;
                }
                n++;

            }

            Console.WriteLine();
            PrintArray(arrayUnic);

        }


        static void PrintList(List<int> collection)
        {
            foreach (int position in collection)
            {
                Console.Write($"\t {position}");
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"\t{array[i, j]} {(i, j)} ");


                }
                Console.WriteLine();
            }
        }

    } 
}