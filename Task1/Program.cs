// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int GetExpo(int result)
{
    result = 1;
    for (int i = 0; i < number2; i++)
    {
       result = result *number1;
    }
    return result;
}

Console.WriteLine($"Число {number1} в степени {number2} равно {GetExpo(number1)}");