using System;
class Alunos
{
    public string nome;
    public int matricula;
    public double notaProva1;
    public double notaProva2;
    public double notaTrabalho;
    public double media;
    public double notaFinal;


    public Alunos(int m, string n, double p1, double p2, double t){
        matricula = m;
        nome = n;
        notaProva1 = p1;
        notaProva2 = p2;
        notaTrabalho = t;
    }

    public void calcMedia(){
        media = ((notaProva1*2.5) + (notaProva2*2.5) + (notaTrabalho*2)) / 7;
    }

    public void calcNotaFinal(){
        if (media < 60){
            notaFinal = 60 - media;
        }
        else{
            notaFinal = 0;
        }
    }

    public void mostrarDados(){
        Console.WriteLine("Matrícula: " + matricula);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Nota Prova 1: " + notaProva1);
        Console.WriteLine("Nota Prova 2: " + notaProva2);
        Console.WriteLine("Nota Trabalho: " + notaTrabalho);
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Nota que precisa na final: " + notaFinal);
    }
}

class Program
{
    static void Main()
    {
         //mostrar a matricula, nome, 2 notas de prova e 1 de trabalho de um aluno e calcular a media e quanto ele precisa na prova final
         Console.WriteLine("Digite a matricula, o nome, e as notas do aluno:");
         Alunos meuAluno = new Alunos(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
         meuAluno.calcMedia();
         meuAluno.calcNotaFinal();
         meuAluno.mostrarDados();
    }
}