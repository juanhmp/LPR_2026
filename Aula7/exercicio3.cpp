#include <iostream>
using namespace std;
int main(){
    int cidade[4][4] = {{0, 520, 521, 882},
                        {524, 0, 434, 586},
                        {521, 434, 0, 429},
                        {882, 586, 429, 0}};
    int i;
    cout<<"Fale em qual cidade vc esta: Vitoria(0), Belo Horizonte(1), Rio de Janeiro(2), Sao Paulo(3): "<<endl;
    cin >> i;
    cout<<"Me informe a cidade de destino (com os mesmos numeros):"<<endl;
    int j;
    cin >> j;
    if(i==j){
        cout<<"Programa encerrado, as cidades sao iguais"<<endl;
    }    else{
        cout<<"A distancia entre as cidades e: "<<cidade[i][j]<<" km"<<endl;
    }
    return 0;
}