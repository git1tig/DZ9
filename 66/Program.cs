// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int getSumFromMtoN(int m, int n)
{
    int sum = 0;
    if (n < m)
    {
        Console.WriteLine($"{n} вообще-то < {m}, я c такими данными не работаю!");
        return -1;
    }
    for (int i=m;i<=n;i++) sum=sum+i;
    return sum;
    
}
int GetNumber(string name)
{
    Console.Write($"Введите значение {name}: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

Console.WriteLine("Выдам сумму чисел от M до N совершенно бесплатно!");
int myM = GetNumber("M");
int myN = GetNumber("N");
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {myM} до {myN} равна {getSumFromMtoN(myM, myN)}");


