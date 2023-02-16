// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int akkerman(int m, int n)
{
    if (m == 0) return (n + 1);

    if (m > 0 && n == 0) return akkerman(m - 1, 1);

    return(akkerman((m - 1), akkerman(m, n - 1)));
}

int GetNumber(string name)
{
    Console.Write($"Введите значение {name}: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

Console.WriteLine("Посчитаю Аккермана для чисел M и N...");
int myM = GetNumber("M");
int myN = GetNumber("N");
Console.WriteLine();
Console.WriteLine($"Функция Аккермана для {myM} и {myN} равна {akkerman(myM, myN)}");

