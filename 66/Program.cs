/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int M = ReadInt("Задайте значение M: ");
int N = ReadInt("Задайте значение N: ");

NumberSum(M, N, 0);
void NumberSum (int M, int N, int sum)
{
if (M > N)
{
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {sum}");
return;
}
sum = sum + (M++);
NumberSum(M, N, sum);
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}