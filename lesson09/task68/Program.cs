/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int fAccermana (int firstNumber, int secondNumber) // Метод расчета функции Аккермана
{
    int result = 0;
    if(firstNumber == 0) result = secondNumber + 1;
    else if (secondNumber == 0) result = fAccermana(firstNumber - 1, 1);
    else result = fAccermana(firstNumber - 1, fAccermana(firstNumber, secondNumber-1));
    return result;
}


Console.Clear();
Console.Write("Введите аргументы функции Аккермана разделив значения пробелом: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int m = size[0];
int n = size[1];

Console.Write($"Результат вычисления функции Аккермана: {fAccermana(firstNumber: m, secondNumber: n)}");