// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNatNumbers(int M, int N)
{
    int number = M + 1;
    if (number > N) return;
    Console.Write(M + " ");
    PrintNatNumbers(M + 1, N);

}

void Main()
{
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    PrintNatNumbers(M, N);
}
Main();