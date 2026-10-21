using System;

struct Heroi
{
    public string nome;
    public string poder;
    public int pontuacao;
}

class Program
{
    Heroi[] herois = new Heroi[5];
    Heroi[] equipe = new Heroi[3];
    int pontuacaoTotal = 0;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.MenuPrincipal();
    }

    void CadastrarHeroi()
    {
        for (int i = 0; i < herois.Length; i++)
        {
            Console.WriteLine("Digite o nome do herói:");
            herois[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o poder do herói:");
            herois[i].poder = Console.ReadLine();
            Console.WriteLine("Digite a pontuação do herói em pontos:");
            herois[i].pontuacao = int.Parse(Console.ReadLine());
            Console.WriteLine($"Herói cadastrado: {herois[i].nome}, Poder: {herois[i].poder}, Pontuação: {herois[i].pontuacao}");
            Console.WriteLine();
        }
    }
    void SelecionarEquipe()
    {
        Console.WriteLine("Selecione três dos heróis cadastrados:");
        for (int i = 0; i < herois.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {herois[i].nome} - Poder: {herois[i].poder}");
        }
        Console.WriteLine("Digite o número do primeiro herói:");
        int heroi1 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Digite o número do segundo herói:");
        int heroi2 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Digite o número do terceiro herói:");
        int heroi3 = int.Parse(Console.ReadLine()) - 1;
        equipe[0] = herois[heroi1];
        equipe[1] = herois[heroi2];
        equipe[2] = herois[heroi3];
        Console.WriteLine($"Equipe selecionada: {equipe[0].nome}, {equipe[1].nome}, {equipe[2].nome}");
    }
    void CalcularPontuacaoTotal()
    {
        pontuacaoTotal = equipe[0].pontuacao + equipe[1].pontuacao + equipe[2].pontuacao;
        Console.WriteLine($"Pontuação total da equipe: {pontuacaoTotal}");
    }
     void ExibirEquipe()
    {
        Console.WriteLine("Heróis selecionados para a equipe:");
        for (int i = 0; i < equipe.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {equipe[i].nome} - Poder: {equipe[i].poder}");
        }
        Console.WriteLine($"Pontuação total da equipe: {pontuacaoTotal}");
    }
    void MenuPrincipal()
    {
        int opcao = 0;
        while (opcao != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao sistema de cadastro de heróis!");
            Console.WriteLine("1. Cadastrar heróis");
            Console.WriteLine("2. Selecionar equipe");
            Console.WriteLine("3. Calcular pontuação total");
            Console.WriteLine("4. Exibir equipe");
            Console.WriteLine("5. Sair");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                CadastrarHeroi();
            }
            else if (opcao == 2)
            {
                SelecionarEquipe();
            }
            else if (opcao == 3)
            {
                CalcularPontuacaoTotal();
            }
            else if (opcao == 4)
            {
                ExibirEquipe();
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Saindo do sistema. Até mais!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}