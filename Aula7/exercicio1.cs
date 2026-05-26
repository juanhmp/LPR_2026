int[] par = new int [5];
int[] impar = new int[5];
int[] entradas = new int[10];
Console.WriteLine("Digite 10 numeros inteiros e direi se eles sao pares ou impares: ");
for(int i = 0; i<entradas.Length; i++)
{
    Console.ReadLine("Número " + i +": ") = entradas[i];
}
for(int j = 0; j<entradas.Length; j++)
{
    if (entradas[j] % 2 = 0)
    {
        entradas[j] = par[];
    }
    else
    {
        entradas[j] = impar[];
    }
}
for(int k = 0; k<par.Length; k++){
Console.WriteLine("Numeros pares: " +par[k]);
}
for (int l = 0; l<impar.Length; l++)
{
    Console.WriteLine("Nuneros impares: " +impar[l]);
}