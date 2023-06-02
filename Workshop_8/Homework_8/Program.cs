// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        SortRowsDescending(array);

        // Вывод отсортированного массива
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    

    static void SortRowsDescending(int[,] array)
    {
        int rowCount = array.GetLength(0);

        // Сортируем каждую строку массива по убыванию
        for (int i = 0; i < rowCount; i++)
        {
            List<int> tempList = new List<int>();

            // Добавляем элементы строки во временный список
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempList.Add(array[i, j]);
            }

            // Сортируем временный список по убыванию
            tempList.Sort((x, y) => y.CompareTo(x));

            // Копируем отсортированные элементы обратно в строку массива
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = tempList[j];
            }
        }
    }


