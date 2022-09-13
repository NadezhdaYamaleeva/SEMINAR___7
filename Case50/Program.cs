// Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
void FillArray(int [,] matr)
{
    for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {
            matr [i, j] = new Random().Next(0, 101);
        }
    }
}
void PrintArray(int [,] matr)
{
    for (int i = 0; i < m; i ++)
    {
        Console.WriteLine();
        for (int j= 0; j < n; j ++)
        {
            Console.Write($"{matr[i, j]}");
        }
    }
}
int [,] matr = new int [m, n];
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;
for (int i = 0; i < matr.GetLength(0); i ++)
{
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        if (matr [i, j] == a)
        {
            b = 1;
        }
    }
}
if (b == 1)
{
    Console.WriteLine("Такое число есть в массиве");
}
else
{
    Console.WriteLine("Такого числа нет в массиве");
}
