#include <iostream>
#include <iomanip> 

using namespace std; 

int main() {
    setlocale(LC_ALL, "Portuguese"); 
    cout << "Me fale o codigo dessa peça: ";
    int codigoPeca;
    cin >> codigoPeca;
    cout << "Me fale o número de peças desejadas: ";
    int numeroPecas;
    cin >> numeroPecas;
    cout << "Me fale o valor da peça: ";
    float valorPeca;
    cin >> valorPeca;
    float preco = numeroPecas * valorPeca;
    cout << "Valor a pagar do código " << codigoPeca << " é de R$ " << preco << endl;
    cout << "Me fale o codigo dessa outra peça: ";
    int codigoPeca2;
    cin >> codigoPeca2;
    cout << "Me fale o número de peças desejadas: ";
    int numeroPecas2;
    cin >> numeroPecas2;
    cout << "Me fale o valor da peça: ";
    float valorPeca2;
    cin >> valorPeca2;
    float preco2 = numeroPecas2 * valorPeca2;
    cout << "Valor a pagar do código " << codigoPeca2 << " é de R$ " << preco2 << endl;
    float valorTotal = preco + preco2;
    cout << "Valor total a pagar é de R$ " << valorTotal << endl;
    return 0; 
}