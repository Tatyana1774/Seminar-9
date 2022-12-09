    /*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29 */
    int m = ReadInt("Введите значение m ");
    int n = ReadInt("Введите значение n ");
    Console.Write($"m = {m}, n = {n} -> A(m,n) = ");
    Ackerman(m, n);

    void Ackerman(int m, int n)
    {
    Console.Write(ack(m, n));
    }

    int ack(int m, int n)
    {
    if (m == 0)
    {
    return n + 1;
    }
    else if (n == 0 && m > 0)
    {
    return ack(m - 1, 1);
    }
    else
    {
    return ack(m - 1, ack(m, n - 1));
    }
    }

    int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }

