// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] array = new int [8];
void FillArray (int [] array)
{
    int lengh = array.Length;
    int index = 0;
    while (index < lengh)
    {
        array [index] = new Random().Next (1,11);
        index ++;
    }
}

void PrintArray (int [] collection)
{
    int lengh = collection.Length;
    int position = 0;
    Console.Write("[");
    while (position < lengh-1)
    {
        Console.Write($"{collection[position]}, ");
        position ++;
    }
    Console.Write($"{collection[position]}");
    Console.Write("]");
}

FillArray(array);
PrintArray(array);