// Задайте произвольный массив. Выведите его элементы, начиная с конца
// Использовать рекурсию, не использовать циклы.


void Main()
{
    int[] array = {1, 3, 545, 28, 53} ;
    ReverseArray(array, array.Length - 1);
}

void ReverseArray(int[] array, int i)
{
    if(i < 0) return;
    System.Console.Write(array[i]);
    if(i > 0)System.Console.Write(", ");
    ReverseArray(array, i - 1);
}

Main();