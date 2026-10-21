
using System;

class Kratos
{
    public int vidaKratos;
    public int ataqueKratos;
    public int defesaKratos;

    public Kratos(int v, int a, int d)
    {
        vidaKratos = v;
        ataqueKratos = a;
        defesaKratos = d;
    }

    public void mostrarDados()
    {
        Console.WriteLine("\nVida: " + vidaKratos);
        Console.WriteLine("Ataque: " + ataqueKratos);
        Console.WriteLine("Defesa: " + defesaKratos);
    }

    public void atacar(Baldur baldur)
    {
        if (ataqueKratos > 20)
        {
            Console.WriteLine("Kratos atacou com força total!");
            baldur.vidaBaldur -= ataqueKratos;
            ataqueKratos -= 4;
        }
        else if (ataqueKratos > 10)
        {
            Console.WriteLine("Kratos atacou com força média.");
            baldur.vidaBaldur -= ataqueKratos;
            ataqueKratos -= 2;
        }
        else if (ataqueKratos > 5)
        {
            Console.WriteLine("Kratos atacou com força fraca.");
            baldur.vidaBaldur -= ataqueKratos;
            ataqueKratos -= 1;
        }
        else
        {
            Console.WriteLine("Kratos não tem força suficiente para atacar.");
        }

        if (baldur.vidaBaldur < 0)
        {
            baldur.vidaBaldur = 0;
        }

        mostrarDados();
        baldur.mostrarDados();
    }

    public void defender(Baldur baldur)
    {
        if (defesaKratos > 15)
        {
            Console.WriteLine("Kratos defendeu com força total!");
            defesaKratos -= 3;
        }
        else if (defesaKratos > 8)
        {
            Console.WriteLine("Kratos defendeu com força média.");
            defesaKratos -= 2;
        }
        else if (defesaKratos > 3)
        {
            Console.WriteLine("Kratos defendeu com força fraca.");
            defesaKratos -= 1;
        }
        else
        {
            Console.WriteLine("Kratos não conseguiu defender!");
            vidaKratos -= baldur.ataqueBaldur;
        }

        if (vidaKratos < 0)
        {
            vidaKratos = 0;
        }

        mostrarDados();
    }

    public void desviar()
    {
        Console.WriteLine("Kratos desviou!");
        ataqueKratos += 2;
        defesaKratos += 1;
        mostrarDados();
    }
}

class Atreus
{
    public int vidaAtreus;
    public int ataqueAtreus;
    public int defesaAtreus;

    public Atreus(int v, int a, int d)
    {
        vidaAtreus = v;
        ataqueAtreus = a;
        defesaAtreus = d;
    }

    public void mostrarDados()
    {
        Console.WriteLine("\nVida: " + vidaAtreus);
        Console.WriteLine("Ataque: " + ataqueAtreus);
        Console.WriteLine("Defesa: " + defesaAtreus);
    }

    public void atacar(Baldur baldur)
    {
        if (ataqueAtreus > 10)
        {
            Console.WriteLine("Atreus ajudou Kratos com uma flecha!");
            baldur.vidaBaldur -= ataqueAtreus;
            ataqueAtreus -= 2;
        }
        else if (ataqueAtreus > 5)
        {
            Console.WriteLine("Atreus atacou com uma flecha fraca.");
            baldur.vidaBaldur -= ataqueAtreus;
            ataqueAtreus -= 1;
        }
        else
        {
            Console.WriteLine("Atreus não tem força suficiente para atacar.");
        }

        if (baldur.vidaBaldur < 0)
        {
            baldur.vidaBaldur = 0;
        }

        mostrarDados();
        baldur.mostrarDados();
    }

    public void defender(Baldur baldur)
    {
        if (defesaAtreus > 8)
        {
            Console.WriteLine("Atreus se defendeu!");
            defesaAtreus -= 2;
        }
        else if (defesaAtreus > 3)
        {
            Console.WriteLine("Atreus defendeu com pouca força.");
            defesaAtreus -= 1;
        }
        else
        {
            Console.WriteLine("Atreus não conseguiu defender!");
            vidaAtreus -= baldur.ataqueBaldur;
        }

        if (vidaAtreus < 0)
        {
            vidaAtreus = 0;
        }

        mostrarDados();
    }

    public void desviar()
    {
        Console.WriteLine("Atreus desviou!");
        defesaAtreus += 1;
        ataqueAtreus += 2;
        mostrarDados();
    }
}

class Baldur
{
    public int vidaBaldur;
    public int ataqueBaldur;
    public int defesaBaldur;

    public Baldur(int v, int a, int d)
    {
        vidaBaldur = v;
        ataqueBaldur = a;
        defesaBaldur = d;
    }

    public void mostrarDados()
    {
        Console.WriteLine("\nVida: " + vidaBaldur);
        Console.WriteLine("Ataque: " + ataqueBaldur);
        Console.WriteLine("Defesa: " + defesaBaldur);
    }

    public void atacar(Kratos kratos)
    {
        Console.WriteLine("Baldur atacou Kratos!");

        if (kratos.defesaKratos > 0)
        {
            int dano = ataqueBaldur - kratos.defesaKratos / 2;

            if (dano < 1)
            {
                dano = 1;
            }

            kratos.vidaKratos -= dano;
            Console.WriteLine("Kratos recebeu " + dano + " de dano.");
        }
        else
        {
            kratos.vidaKratos -= ataqueBaldur;
            Console.WriteLine("Kratos recebeu " + ataqueBaldur + " de dano.");
        }

        if (kratos.vidaKratos < 0)
        {
            kratos.vidaKratos = 0;
        }

        kratos.mostrarDados();
    }

    public void defender()
    {
        Console.WriteLine("Baldur defendeu!");
        defesaBaldur += 2;
    }

    public void desviar()
    {
        Console.WriteLine("Baldur desviou!");
        defesaBaldur += 1;
    }
}

class Program
{
    static void Main()
    {
        Kratos kratos = new Kratos(100, 25, 20);
        Atreus atreus = new Atreus(60, 12, 10);
        Baldur baldur = new Baldur(150, 15, 10);

        int opcao;

        Console.WriteLine("=== GOD OF WAR ===");
        Console.WriteLine("Kratos e Atreus contra Baldur!");

        while (kratos.vidaKratos > 0 && baldur.vidaBaldur > 0)
        {
            Console.WriteLine("\nEscolha uma ação:");
            Console.WriteLine("1 - Kratos atacar");
            Console.WriteLine("2 - Kratos defender");
            Console.WriteLine("3 - Kratos desviar");
            Console.WriteLine("4 - Atreus ajudar");
            Console.WriteLine("5 - Mostrar dados");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite um número válido!");
                continue;
            }

            if (opcao == 1)
            {
                kratos.atacar(baldur);
            }
            else if (opcao == 2)
            {
                kratos.defender(baldur);
            }
            else if (opcao == 3)
            {
                kratos.desviar();
            }
            else if (opcao == 4)
            {
                atreus.atacar(baldur);
            }
            else if (opcao == 5)
            {
                Console.WriteLine("\n--- KRATOS ---");
                kratos.mostrarDados();

                Console.WriteLine("\n--- ATREUS ---");
                atreus.mostrarDados();

                Console.WriteLine("\n--- BALDUR ---");
                baldur.mostrarDados();

                continue;
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Você saiu do jogo.");
                return;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            if (baldur.vidaBaldur <= 0)
            {
                break;
            }

            baldur.atacar(kratos);
        }

        if (kratos.vidaKratos <= 0)
        {
            Console.WriteLine("\nKratos foi derrotado!");
            Console.WriteLine("Baldur venceu a batalha!");
        }
        else if (baldur.vidaBaldur <= 0)
        {
            Console.WriteLine("\nKratos e Atreus venceram!");
            Console.WriteLine("Baldur foi derrotado!");
        }
    }
}
