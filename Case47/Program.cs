// Задать двумерный массив размером m*n, заполненный случайными вещественными числами
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
void FillArray(double [,] matr)
{
    for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {
            matr [i, j] = new Random().Next(-10, 11);
        }
    }
}
void PrintArray(double [,] matr)
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
double [,] matr = new double [m, n];
FillArray(matr);
PrintArray(matr);
