// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i+j;
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите высоту массива = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите длинну массива = ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
