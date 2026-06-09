int[] nome = new int[x];
int[] nota = new int[y];
int[] situação = new int[z];
int media = 0;
Console.WriteLine("Digite o nome e a nota de 10 alunos:");
for (int i = 0; i < nome.Length; i++)
{
    Console.Write("Nome do aluno " + (i + 1) + ": ");
    nome[i] = Console.ReadLine();
    Console.Write("Nota do aluno " + (i + 1) + ": ");
    nota[i] = int.Parse(Console.ReadLine());
if (nota[i] >= 85)
{
    situação[i] = "Aprovado";
}
else if (nota[i] >= 72 && nota[i] < 85)
{
    situação[i] = "Recuperação";
}
else
{
    situação[i] = "Reprovado";
}
}