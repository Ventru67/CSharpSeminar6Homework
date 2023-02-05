// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
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
void ChangeArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                matr[i, j] = matr[i, j] * matr[i, j];
            }
        }
    }
}

Console.Write("Введите высоту массива = ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите длинну массива = ");
int y = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[x, y];

FillArray(matrix);
PrintArray(matrix);
ChangeArray(matrix);
Console.WriteLine();
PrintArray(matrix);
