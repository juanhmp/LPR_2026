using System;
using System.Linq;
 struct Produto {
    string nome;
    int codigo;
    float preco;
    int quantidade;
};

class Program {
    static void Main(string[] args) {
        int valorTotal = 0;
        Produto[] produtos = new Produto[3];
        Console.WriteLine("Digite os detalhes de 3 produtos:");
        for(int i = 0; i < produtos.Length; i++) {
            Console.WriteLine($"Produto {i + 1}:");
    Console.Write("Nome: ");
    produtos[i].nome = Console.Read();
    Console.Write("| Código: ");
    produtos[i].codigo = int.Parse(Console.Read());
    Console.Write("| Preço: ");
    produtos[i].preco = float.Parse(Console.Read());
    Console.Write("| Quantidade: ");
    produtos[i].quantidade = int.Parse(Console.ReadLine());
    valorTotal += (int)(produtos[i].preco * produtos[i].quantidade);
}
Console.WriteLine($"Valor total do estoque: {valorTotal}");
}
}