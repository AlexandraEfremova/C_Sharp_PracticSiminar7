// Задайте значения M и N. Напишите программу, 
// которая будет выводить все натуральные числа
//  в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System.Globalization;

void Main()
{
    int M = ReadInt("Введите первое число: ");
    int N = ReadInt("Введите второе число: ");
    PrintNumbers(M, N);
}
void PrintNumbers(int M, int N)
{
    if(M > N) return;
    System.Console.Write(M);
    if (M < N)
        System.Console.Write(", ");
    PrintNumbers(M + 1, N);
}

// метод для ввода числа пользователем
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();