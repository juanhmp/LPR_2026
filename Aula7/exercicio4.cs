using System;
using System.Linq;
string[] nome = new string[10];
int[] nota = new int[10];
string[] situação = new string[10];
float media = 0;
int aprovados = 0, recup = 0, reprovados = 0;
Console.WriteLine("Digite o nome e a nota dos alunos:");
for (int i = 0; i < nome.Length; i++)
{
    Console.Write("Nome do aluno " + (i + 1) + ": ");
    nome[i] = Console.ReadLine();
    Console.Write("Nota do aluno " + (i + 1) + ": ");
    nota[i] = int.Parse(Console.ReadLine());
}
ClassificarAluno();

void ClassificarAluno()
{
    for (int j = 0; j < nota.Length; j++)
    {
    if (nota[j] >= 80)
    {
        situação[j] = "Aprovado";
        aprovados++;
    }
    else if (nota[j] >= 60 && nota[j] < 80)
    {
        situação[j] = "Recuperação";
        recup++;
    }
    else
    {
        situação[j] = "Reprovado";
        reprovados++;
    }
}
media = (float)nota.Sum() / nota.Length;
for (int k = 0; k < nome.Length; k++)
{
Console.WriteLine(nome[k] + " - " + nota[k] + " - " + situação[k]);
}
Console.WriteLine("Aprovados: " + aprovados);
Console.WriteLine("Recuperação: " + recup);
Console.WriteLine("Reprovados: " + reprovados);
Console.WriteLine("Média da turma: " + media);
}