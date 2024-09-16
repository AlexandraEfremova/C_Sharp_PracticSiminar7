// Напишите программу вычисления функции
// Аккрмана с помощью рекурсии. Даны два неотрицательных числа m и n


void Main()
{
    int M = ReadInt("Введите первое положительное число: ");
    int N = ReadInt("Введите второе положительное число: ");
    int res = PrintAkkerman(M, N);
    System.Console.WriteLine(res);
}

int PrintAkkerman(int M, int N)
{
    if(M == 0) return N + 1;
    else
        if(M > 0 && N == 0) return PrintAkkerman(M - 1, 1);
    else
        if(M > 0 && N > 0) return PrintAkkerman(M - 1, PrintAkkerman(M, N - 1));   
    return 0;
}

// метод для ввода числа пользователем
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();