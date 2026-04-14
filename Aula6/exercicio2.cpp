#include <iostream>
using namespace std;
void funcao1() {
    int i = 0;
    int acumulador = 0;
    int quantidade;
    int pares = 0;
    std::cout << "Quantos numeros serao digitados?" << std::endl;
    std::cin >> quantidade;
    while (i < quantidade) {
        std::cout << "Digite o " << (i+1) << "º numero: " << std::endl;
        int numero;
        std::cin >> numero;
     if (numero % 2 == 0) {
        acumulador += numero;
        pares++;
        }
    i++;
    }
    if (pares > 0) {
     double media = (double)acumulador / pares;
     std::cout << "A media dos pares e: " << media << std::endl;
    } else {
        std::cout << "Nenhum numero par foi digitado." << std::endl;
    }

    
} void funcao2(){
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos numeros eh: " << soma << endl;

    
} void funcao3()
    {
        cout << "Digite um número: " << endl;
        int numero;
        cin >> numero;
        int quadrado = numero * numero;
        int soma = 0;

        int temp = quadrado;

        while (temp > 0)
        {
            soma += temp % 10; 
            temp /= 10;        
        }

        cout << "Quadrado: " << quadrado << endl;
        cout << "Soma dos dígitos: " << soma << endl;
    } int main(){
        cout << "Me fale se voce quer executar a funcao 1, 2 ou 3:" << endl;
        int funcao;
        cin >> funcao;
        if (funcao == 1){
            funcao1();
        }
        else if (funcao == 2){
            funcao2();
        }
        else if (funcao == 3){
            funcao3();
        }
        else{
            cout << "Digite um valor válido" << endl;
        }

    }
