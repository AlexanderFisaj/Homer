/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void PrintDualArray(int[,] array) // Метод вывод 2-мерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void FillArraySpiral (int[,] array) // Спиральное заполнение 2-мерного массива
{
    int number = 1;
    int i = 0;
    int j = 0;
    int sizeArray = array.GetLength(0);

    while (number <= sizeArray * sizeArray)
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < sizeArray - 1) j++;            
        else if (i < j && i + j >= sizeArray - 1) i++;            
        else if (i >= j && i + j > sizeArray - 1) j--;            
        else i--;
        number++;
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
FillArraySpiral(array);
PrintDualArray(array);