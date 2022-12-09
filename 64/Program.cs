/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
int numberN = ReadInt("Введите N: ");
Console.Write($"N = {numberN} -> ");
NumberMaxMin(numberN);

void NumberMaxMin(int numberN)
{
if (numberN < 0)
{
Console.Write($"{numberN} не натуральное число");
}
if (numberN == 0)
return;
Console.Write("{0,4}", numberN);
NumberMaxMin(numberN - 1);
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}