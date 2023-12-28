Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Random random = new Random();
int[,] matrix = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = random.Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
double result = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        result += Math.Pow(matrix[i, j], 2) * Math.Pow(2, i + j);
    }
}

result = Math.Sqrt(result);
Console.WriteLine($"Результат: {result:F2}");