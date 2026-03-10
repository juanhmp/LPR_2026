#include <iostream>
#include <iomanip> 

using namespace std; 

int main() {
    setlocale(LC_ALL, "Portuguese"); 
    cout << "Me fale o seu número de funcionário: ";
    int numeroFuncionario;
    cin >> numeroFuncionario;
    cout << "Me fale o número de horas trabalhadas: ";
    int horasTrabalhadas;
    cin >> horasTrabalhadas;
    cout << "Me fale o valor da hora trabalhada: ";
    float valorHora;
    cin >> valorHora;
    float salario = horasTrabalhadas * valorHora;
    std::cout << std::fixed << std::setprecision(2) << salario << std::endl;
    cout << "O funcionário de número " << numeroFuncionario << " tem um salário de U$ " << salario << endl;
    
    return 0; 
}