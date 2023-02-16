// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int numsRowFromNumtoOne(int num)
{
    if(num>0)
    {
    Console.Write($" {num} ");
    return numsRowFromNumtoOne(num-1);
    }
    else return 0;
}


int GetNumber()
{
    Console.Write($"Введите значение числа: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}
Console.WriteLine($"Щас выведу все натуральные числа в промежутке от N до 1");
numsRowFromNumtoOne(GetNumber());
