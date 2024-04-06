// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

int[] genArray(int i)
{
    int[] array = new int[i];
    Random rnd = new Random();
    for (int num = 0; num < i; num++)
        array[num] = rnd.Next();
    return array;
}
void PrintGeneratedArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

}

void PrintArrReversе(int[] arr, int i)
{

    if (i < 0) return;
    Console.Write(arr[i] + "  ");
    PrintArrReversе(arr, i - 1);
}
void Main()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int[] arr = genArray(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Исходный массив:");
    PrintGeneratedArr(arr);
    Console.WriteLine();
    Console.WriteLine("Результат задачи:");
    PrintArrReversе(arr, arr.Length - 1);
}
Main();

