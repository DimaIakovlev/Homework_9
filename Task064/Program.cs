// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine());

PrintNumbers(number, 1);

void PrintNumbers(int begin, int end)
{
    Console.Write($"{begin} ");
    if (begin == end) return;
    PrintNumbers(begin - 1, end);
}