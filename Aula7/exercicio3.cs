int[] numeros = new int[10];

Console.WriteLine("Digite 10 números inteiros:");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Número " + (i + 1) + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nDigite o número que deseja pesquisar: ");
int pesquisa = int.Parse(Console.ReadLine());

int ocorrencias = 0;

Console.WriteLine("\nPosições encontradas:");

for (int j = 0; j < numeros.Length; j++)
{
    if (numeros[j] == pesquisa)
    {
        Console.WriteLine("Posição: " + j);
        ocorrencias++;
    }
}

if (ocorrencias > 0)
{
    Console.WriteLine("\nO número apareceu " + ocorrencias + " vez(es).");
}
else
{
    Console.WriteLine("\nO número não foi encontrado no vetor.");
}