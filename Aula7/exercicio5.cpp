#include <iostream>
using namespace std;
int main(){
    int matriz[3][3];
    int soma = 0;
    cout<<"Digite os numeros da matriz 3x3: "<<endl;
    for(int i=0; i<3; i++){
        for(int j=0; j<3; j++){
            cin >> matriz[i][j];
        }
    }
    cout<<"Matriz digitada: "<<endl;
    for(int i=0; i<3; i++){
        for(int j=0; j<3; j++){
            cout << matriz[i][j] << " ";
            soma += matriz[i][j];
        }
        cout << endl;
    }
    cout << "Soma dos elementos: " << soma << endl;
    return 0;
}