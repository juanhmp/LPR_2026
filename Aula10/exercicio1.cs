using System;
class Retangulo
{
    public double altura;
    public double largura;

    public Retangulo(double a, double l){
        altura = a;
        largura = l;
    }

    public void calcArea(){
        double area = altura * largura;
        Console.WriteLine(area);
    }

    public void calcPerimetro(){
        double perimetro =  (2*altura)+(2*largura);
        Console.WriteLine(perimetro);
    }
}

class Program
{
    static void Main()
    {
         //ler altura e largura de um retangulo, calcular Area e Perimetro
         Console.WriteLine("Digite a altura e a largura do retangulo:");
         Retangulo meuRetangulo = new(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
         Console.WriteLine("Área do retângulo:");
         meuRetangulo.calcArea();
         Console.WriteLine("Perímetro do retângulo:");        
         meuRetangulo.calcPerimetro();
    }
}