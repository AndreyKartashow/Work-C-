/* namespace Game
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
                // PrintList(listNumber);
            }

            int[,] arrayUnic = new int[str, row];
            int k = 0;                                                  // текущий элемент коллекции
            int i = 0;                                                  
            int j = 0;

            int m = 0;                                                  // количество заполненых строк
            int n = 0;                                                  // количество заполненых столбиков

            int positionLastStringRow = arrayUnic.GetUpperBound(0) - m; // индекс крайней строки        3=3-0
            int positionLastRow = arrayUnic.GetUpperBound(1) - n;       // индекс крайнего столбика     3=3-0

            int lengthString = arrayUnic.GetLength(1);                  // длина строки                 4
            int lengthRow = arrayUnic.GetLength(0);                     // длина столбика               4

            int currentLengthString = lengthString - n;                 // текущая длина строки         4=4-0
            int currentLengthRow = lengthRow - m;                       // тукущая длина столбика       4=4-0

            int firstString = lengthString - currentLengthString;       // индекс первой строки         0=4-4
            int firstRow = lengthRow - currentLengthRow;                // индекс первого столбика      0=4-4 

            while (k != sizeList)
            {

                while (j < currentLengthString)
                {
                    arrayUnic[firstString, firstRow + j] = listNumber[k];
                    j++;
                    k++;
                }
                m++;                                                    // заполненых строк             1
                currentLengthRow = lengthRow - m;                       // текащая длина столбика       3=4-1


                while (i < currentLengthRow)
                {
                    arrayUnic[currentLengthRow + i, positionLastRow] = listNumber[k];
                    i++;
                    k++;
                }
                n++;                                                    // заполненых столбиков         1
                currentLengthString = lengthString - n;                 // текущая длина строки         3=4-1


                while (j < currentLengthString)
                {
                    arrayUnic[currentLengthRow, currentLengthString - 1 - j] = listNumber[k];
                    j++;
                    k++;
                }
                m++;                                                    // заполненых строк             2
                currentLengthRow = lengthRow - m;                       // текущая длина столбика       2=4-2


                while (i < currentLengthRow)
                {
                    arrayUnic[lengthString - i,  currentLengthRow          ] = listNumber[k];
                    i++;
                    k++;
                }
                j++;
                currentSizeString = sizeString - j;


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
} */