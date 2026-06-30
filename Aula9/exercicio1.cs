List<int>notas = new List<int>();
int maior = 0;
int menor = 100;
int total = 0;
Console.WriteLine("Me de o valor das notas de 5 alunos.");
for(int i =0; i<5; i++){
notas.Add(int.Parse(Console.ReadLine()));
total += notas[i];
}
Console.WriteLine("Todas as notas cadastradas: ");
foreach(var elemento in notas)
{
    Console.WriteLine(elemento);
}
for(int i = 0; i<4; i++)
{
    if (notas[i] < notas[i+1] && notas[i+1] > maior){
        maior = notas[i+1];
    }
    if(notas[i] < notas[i+1] && menor > notas[i])
    {
        menor = notas[i];
    }
}
float media = total / 5;
Console.WriteLine("A maior nota é: "+maior);
Console.WriteLine("A menor nota é: "+menor);
Console.WriteLine("A média de notas é: "+media);