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


void DownSortRowsArray (int[,] array, int numberCall) // Метод сортировки
{    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[numberCall, i] < array[numberCall, j])
            {
                int tmp = array[numberCall, i];
                array[numberCall, i] = array[numberCall, j];
                array[numberCall, j] = tmp;
                break;
            }
        }        
    }    
}

void Maxim (int[,] array, int positionA, int positionB)
{
    int maximum = array[positionA, positionB]
    for (i = 0; i < array.GetLength(1); i++)
    {
            if(array[i, positionB] > maximum)
        {
            maximum = Maxim(array, positionA, i + 1);            
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

for (int k = 0; k < dualArray.GetLength(0); k++)
{
    DownSortRowsArray(array: dualArray, numberCall: k);
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
PrintDualArray(dualArray); // Вывод массива результатов сортировки
