// Задать двумерный массив из целых чисел. Найти среднее арифметическое элементов в каждом столбце.
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
        for (int j = 0; j < n; j ++)
        {
            Console.Write($"{matr[i, j]}");
        }
    }
}
int [,] matr = new int [m, n];
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое в каждом столбце");
for (int j = 0; j < matr.GetLength(1); j ++)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        sum += matr [i, j];
    }
    Console.Write(Math.Round(sum/matr.GetLength(0), 1) + " ");
}
