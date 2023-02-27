/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int SummRange (int firstNumber, int secondNumber) // Метод расчет сумы чисел заданного диапазона
{
    int summ = firstNumber;    
    if (secondNumber > firstNumber) summ += SummRange(firstNumber+1, secondNumber) ;
    return summ;
}

Console.Clear();

Console.Write("Введите начальное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) // Если пользователь ввел числа не по возрастанию, меняем местами
    {
        int temp = m;
        m = n;
        n = temp;
    }

Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} = {SummRange(firstNumber: m, secondNumber: n)}"); // Вывод результата расчета в консоль
