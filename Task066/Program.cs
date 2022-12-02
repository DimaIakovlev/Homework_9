// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine());

Console.Write("Введите M: ");
int numberM = int.Parse(Console.ReadLine());

SumNumbers(numberN, numberM);

void SumNumbers(int begin, int end)
{
    int sum = 0;
    int start = begin;
    while (begin <= end)
    {
        sum += begin;
        begin ++; 
    }
    
    Console.Write($"Сумма чисел в промежутке {start} - {end} равна {sum}" );
}