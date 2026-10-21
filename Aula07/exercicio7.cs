int[,] matriz1 = new int[3, 3];
int[,] matriz2 = new int[3, 3];
int[,] resultado = new int[3, 3];
Console.WriteLine("Digite os elementos da primeira matriz (3x3):");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Elemento [{i},{j}]: ");
        matriz1[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Digite os elementos da segunda matriz (3x3):");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Elemento [{i},{j}]: ");
        matriz2[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Resultado da multiplicação das matrizes:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        resultado[i, j] = 0;
        for (int k = 0; k < 3; k++)
        {
            resultado[i, j] += matriz1[i, k] * matriz2[k, j];
        }
        Console.Write(resultado[i, j] + "\t");
    }
    Console.WriteLine();
}