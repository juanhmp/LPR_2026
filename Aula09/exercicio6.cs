Dictionary<string, int> pessoas = new();
pessoas.Add("João", 15);
pessoas.Add("Maria", 20);
pessoas.Add("Pedro", 60);
pessoas.Add("Ana", 25);
pessoas.Add("Lucas", 23);
int media = 0;
string nova = "";
string velha = "";
int idadeVelha = 0;
int idadeNova = 100;
foreach (var pessoa in pessoas)
{
    media += pessoa.Value;
}
media /= pessoas.Count;
Console.WriteLine("A média de idade das pessoas cadastradas é: " + media);
foreach (var pessoa in pessoas)
{
    if (pessoa.Value > media)
    {
        Console.WriteLine(pessoa.Key + " tem idade acima da média: " + pessoa.Value);
    }
}
for(int i = 0; i < pessoas.Count; i++)
{
    if (pessoas.ElementAt(i).Value < idadeNova)
    {
        nova = pessoas.ElementAt(i).Key;
        idadeNova = pessoas.ElementAt(i).Value;
    }
    else if (pessoas.ElementAt(i).Value > idadeVelha)
    {
        velha = pessoas.ElementAt(i).Key;
        idadeVelha = pessoas.ElementAt(i).Value;
    }
}
Console.WriteLine("A pessoa mais nova é: " + nova);
Console.WriteLine("A pessoa mais velha é: " + velha);
 
 Console.WriteLine("Me fale uma nova pessoa para adicionar ao programa: ");
 string nomeNova = Console.ReadLine();
 Console.WriteLine("Me fale a idade da nova pessoa: ");
 int idadeNovaPessoa = int.Parse(Console.ReadLine());
 pessoas.Add(nomeNova, idadeNovaPessoa);
 for(int i = 0; i < pessoas.Count; i++)
 {
    if (pessoas.ElementAt(i).Value == idadeNova)
    {
        pessoas.Remove(pessoas.ElementAt(i).Key);
    }
 }