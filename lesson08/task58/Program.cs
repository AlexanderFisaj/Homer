/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB) // Метод перемножения массивов
{
  int aRows = matrixA.GetLength(0); 
  int aCols = matrixA.GetLength(1);
  int bRows = matrixB.GetLength(0); 
  int bCols = matrixB.GetLength(1);
  int[,] result = new int[aRows, bCols];
  
    for (int i = 0; i < aRows; ++i) // каждая строка A
        for (int j = 0; j < bCols; ++j) // каждый столбец B
            for (int k = 0; k < aCols; ++k)
                result[i, j] += matrixA[i, k] * matrixB[k, j]; // перемножение по правилам математики
    
  return result;
}


Console.Clear(); // Очистка консоли
int n = new Random().Next(2, 4); // Задается рандомно количество строк/столбцов в массиве
int[,] firstArray = new int[n, n]; // Инициализация 2-мерного массива заданного размера
int[,] secondArray = new int[n, n]; // Инициализация 2-мерного массива заданного размера

FillArray(firstArray);
Console.WriteLine("Первый массив: ");
PrintDualArray(firstArray); // Вывод в терминале первого массива
Console.WriteLine();

FillArray(secondArray);
Console.WriteLine("Первый массив: ");
PrintDualArray(secondArray); // Вывод в терминале первого массива
Console.WriteLine();

Console.WriteLine("Результат умножения:");
int[,] newArray = MatrixProduct(firstArray, secondArray);
PrintDualArray(newArray);