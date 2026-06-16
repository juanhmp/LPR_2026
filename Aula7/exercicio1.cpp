#include <iostream>
using namespace std;
int main(){
    int num [5];
    int aux = 0;
    int aux2 = 0;
    for(int i = 0; i < 5; i++){
        cout<<"Digite um numero: "<<endl;
        cin >> num[i];
    }
    for(int j = 0; j < 5; j++){
        if(num[j] > aux){
            aux = num[j];
            aux2 = j + 1;
        }   
    }
    cout<<"O maior numero digitado foi: "<< aux <<endl;
    cout<<"Ele estava na posicao: "<< aux2 <<endl;
    return 0;   
}