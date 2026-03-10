Console.Write("Digite o valor do raio do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(raio, 2);
Console.WriteLine($"A área do círculo é: {area:F4}");