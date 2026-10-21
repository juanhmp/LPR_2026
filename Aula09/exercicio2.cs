using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        Console.Write("Digite a quantidade de nomes que deseja cadastrar: ");
        int quantidadeNomes = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeNomes; i++)
        {
            Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
            string nome = Console.ReadLine();

            nomes.Add(nome);
        }

        nomes.Sort((a, b) => a.Length.CompareTo(b.Length));

        List<List<string>> linhas = new List<List<string>>();

        foreach (string nome in nomes)
        {
            bool adicionado = false;

            foreach (List<string> linha in linhas)
            {
                bool mesmoTamanho = false;

                foreach (string nomeLinha in linha)
                {
                    if (nomeLinha.Length == nome.Length)
                    {
                        mesmoTamanho = true;
                        break;
                    }
                }

                if (!mesmoTamanho)
                {
                    linha.Add(nome);
                    adicionado = true;
                    break;
                }
            }

            if (!adicionado)
            {
                List<string> novaLinha = new List<string>();
                novaLinha.Add(nome);
                linhas.Add(novaLinha);
            }
        }

        Console.WriteLine("\nNomes organizados:");

        foreach (List<string> linha in linhas)
        {
            foreach (string nome in linha)
            {
                Console.Write(nome + " ");
            }

            Console.WriteLine();
        }
    }
}