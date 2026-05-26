int[] par = new int[10];
int[] impar = new int[10];
int[] entradas = new int[10];

int indicePar = 0;
int indiceImpar = 0;

Console.WriteLine("Digite 10 números inteiros:");

for (int i = 0; i < entradas.Length; i++)
{
    Console.Write("Número " + (i + 1) + ": ");
    entradas[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < entradas.Length; j++)
{
    if (entradas[j] % 2 == 0)
    {
        if (indicePar < par.Length)
        {
            par[indicePar] = entradas[j];
            indicePar++;
        }
    }
    else
    {
        if (indiceImpar < impar.Length)
        {
            impar[indiceImpar] = entradas[j];
            indiceImpar++;
        }
    }
}

Console.WriteLine("\nNúmeros pares:");
for (int k = 0; k < indicePar; k++)
{
    Console.WriteLine(par[k]);
}

Console.WriteLine("\nNúmeros ímpares:");
for (int l = 0; l < indiceImpar; l++)
{
    Console.WriteLine(impar[l]);
}