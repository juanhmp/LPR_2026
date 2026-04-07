#include <iostream>
using namespace std;
void funcao1(){
    int n1, nInvertido = 0, resto;
    cout <<"Digite um numero inteiro qualquer: ";
    cin >> n1;
    while(n1!=0){
        resto = n1%10;
        nInvertido = nInvertido * 10 + resto;
        n1/= 10;
    }
    cout <<"Numero invretido: " <<nInvertido<<endl;
}
int main(){
    funcao1();
}