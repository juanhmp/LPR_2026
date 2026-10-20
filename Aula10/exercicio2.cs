using System;
class Funcionarios
{
    public string nome;
    public double salario;
    public double imposto;

    public Funcionarios(string n, double s){
        nome = n;
        salario = s;
    }

    public void calcAumentarSalario(){
        if (salario <= 2000){
            imposto = 0.1;
        } else if (salario > 2000 && salario <= 3000){
            imposto = 0.15;
        } else {
            imposto = 0.2;
        }
        double aumento = salario + (salario * imposto);
        Console.WriteLine("Aumento: " + aumento);
    }
    public void mostrarDados(){
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário: " + salario);
    }
}

class Program
{
    static void Main()
    {
         //mostrar os dados do funcionário e aumentar o salário cin base em porcentagens de imposto
         Console.WriteLine("Digite o nome e o salário do funcionário:");
         Funcionarios meuFuncionario = new Funcionarios(Console.ReadLine(), double.Parse(Console.ReadLine()));
         meuFuncionario.mostrarDados();
         meuFuncionario.calcAumentarSalario();
    }
}