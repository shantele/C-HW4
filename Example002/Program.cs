// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        int remainder = number % 10;         // остаток от деления
        number /= 10;
        result += remainder;
    }
    return result;
}
Console.WriteLine($"Сумма цифр в числе {num}: {GetSumNumbers(num)}");