/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */


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

int MinSummRowsElement(int[,] array) // Метод определение позиции строки с наименьшей суммой
{
    int minRow = 0;
    int sumRowPosition = 0;
    int minRowPosition = sumRowPosition;
    for (int i = 0; i < array.GetLength(1); i++)
        minRow += array[0, i];

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        sumRowPosition = i;
        if (minRow > sumRow)
        {
            minRow = sumRow;
            minRowPosition = sumRowPosition;
        }
            
    }
    return minRowPosition;
}


Console.Clear(); // Очистка консоли
int m = new Random().Next(3, 6); // Задается рандомно количество строк в массиве
int n = new Random().Next(3, 6); // Задается рандомно количество столбцов в массиве
int[,] dualArray = new int[m, n]; // Инициализация 2-мерного массива заданного размера

FillArray(dualArray);
Console.WriteLine("Задан массив: ");
PrintDualArray(dualArray); // Вывод созданного массива в терминал
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSummRowsElement(dualArray)+1} строка.");