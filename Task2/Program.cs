// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());

while (num < 0)
{
    if (num < 0)
    {
        Console.Write("Введите ПОЛОЖИТЕЛЬНОЕ число: ");
        num = int.Parse(Console.ReadLine());
    }
}

int GetSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
        // Console.WriteLine(sum);
    }
    return sum;
}

Console.WriteLine($"{num} -> {GetSum(num)}");

