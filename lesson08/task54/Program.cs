/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

void FillArray(int[,] array)  // Метод заполнение массива рандомными целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10); // [1, 10)
    }
}

void PrintDualArray(int[,] array) // Метод вывод 2-мерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}


void DownSortRowsArray(int[,] array) // Метод сортировки строк массива по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear(); // Очистка консоли
int m = new Random().Next(2, 6); // Задается рандомно количество строк в массиве
int n = new Random().Next(2, 6); // Задается рандомно количество столбцов в массиве
int[,] dualArray = new int[m, n]; // Инициализация 2-мерного массива заданного размера


FillArray(dualArray); // Заполнение массива рандомными целыми числами
Console.WriteLine("Задан массив:");
PrintDualArray(dualArray); // Вывод 2-мерного массива в консоль
Console.WriteLine();

DownSortRowsArray(dualArray); // Массив передан методу на сортировку

Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
PrintDualArray(dualArray); // Вывод массива результатов сортировки
