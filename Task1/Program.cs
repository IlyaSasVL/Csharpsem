// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


void PrintNatNumbers(int M, int N)
{
    if (M > N) return;
    Console.Write(M + " ");
    PrintNatNumbers(M + 1, N);
}

void Main()
{
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    if (M <= 0) Console.WriteLine("Число M не натуральное");
    else
    {
        Console.WriteLine("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNatNumbers(M, N);
    }
}
Main();