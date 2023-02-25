/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


void FillArray(int[,,] array)  // Метод заполнение массива рандомными целыми числами
{
    int number = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = number++;
        }
    }
}

void PrintArrayAndPosition(int[,,] array) // Метод вывод значений 3-мерного массива и позиции значения в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
        }
    }
}


Console.Clear();
Console.Write("Введите размер 3-мерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("Значения введены некорректные!\nВведите размер 3-мерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] ThreeArray = new int[size[0], size[1], size[2]]; // Инициализация пустого 3-мерного массива
FillArray(ThreeArray); // Заполнение массива 2-значными числами
PrintArrayAndPosition(ThreeArray); // Вывод значений массива и позиций в консоль