Dictionary<string, string> jogos = new();
 Console.WriteLine("Digite o nome e o genero de 5 jogos");
 for (int i = 0; i < 5; i++)
{
    Console.Write("Jogo " + (i + 1) + ": ");
    string nomeJogo = Console.ReadLine();
    Console.Write("Genero do jogo " + (i + 1) + ": ");
    string generoJogo = Console.ReadLine();
    jogos.Add(nomeJogo, generoJogo);
}
Console.WriteLine("Me de o nome de um jogo para ver seu gênero: ");
string nomeBusca = Console.ReadLine();
if (jogos.ContainsKey(nomeBusca))
{
    Console.WriteLine("O gênero do jogo " + nomeBusca + " é: " + jogos[nomeBusca]);
}
else
{
    Console.WriteLine("Jogo não encontrado.");
}