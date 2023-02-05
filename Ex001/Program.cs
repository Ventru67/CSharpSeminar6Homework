// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double N = new Random().NextDouble() + new Random().Next(0,10);
            matr[i, j] = N;
        }
    }
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double N = Math.Round(matr[i, j], 2);
            Console.Write($"{N}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите высоту массива = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите длинну массива = ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);