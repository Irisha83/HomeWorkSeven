// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.


// double[,] CreateDoubleRandom2dArray()
// {
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число стобцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int minVal = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int maxVal = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = Math.Round(new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 1);
//     return array;
// }

// PrintArray(CreateDoubleRandom2dArray);

// 2. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

string StockIndex2dArray(int[,] array, int row, int column)
{
    return array.GetLength(0) <= row && array.GetLength(1) <= column ? "No this element in this 2d array" :
                                                                       $"Yes this element [{row}, {column}] 2d array stock in and have value - {array[row, column]}";
}

int[,] array = CreateRandom2dArray();

Console.WriteLine(StockIndex2dArray(array, 5, 5));


// // 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// double[] AverageNumber(int[,] array)
// {
//     double[] doubleArray = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int count = 0;
//         for (int j = 0; j < array.GetLength(0); j++, count++)
//           doubleArray[i] += array[j, i];
//         doubleArray[i] /= count;
//     }
//     return doubleArray;
// }

// int[,] array = CreateRandom2dArray();

// Show2dArray(array);

// ShowArray(AverageNumber(array));



// void ShowArray(double[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// void Show2dArrayDouble(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minVal = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxVal = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minVal, maxVal + 1);
//     return array;
// }

// int [,] arr = new int [3, 4];
// for (int m = 0; m < arr.GetLength(0); m++)
// {
//     for (int n = 0; n < arr.GetLength(0); n++)
//     {
//         arr [m, n] = (m + n) / n;
//         Console.Write($"{arr [m,n]}");  
//     }
//     Console.WriteLine();
// }