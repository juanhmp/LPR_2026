Console.WriteLine("Digite quatro números inteiro, que te direi a diferença do produto do primeiro e do segundo pelo produto do terceiro pelo quarto: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int p1 = num1 * num2;
int p2 = num3 * num4;
int diferenca = p1 - p2;
Console.WriteLine($"A diferença do produto do primeiro e do segundo pelo produto do terceiro pelo quarto é: {diferenca}");