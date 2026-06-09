#include <iostream>
using namespace std;
int lugares[6][8] = {{0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0},};
int main(){
    int opcao = 0;
for(int i=0; i<6; i++){
    for(int j=0; j<8; j++){
        cout << "Digite 3 para consultar o assento " << i+1 << "-" << j+1 << " ou 1 para reservar ou 2 para cancelar: " << endl;
        cin >> opcao;
        if(opcao == 3){
            ConsultarAssento(i, j);
        } else if(opcao == 1){
            if(lugares[i][j] == 0){
                lugares[i][j] = 1;
                cout << "Assento " << i+1 << "-" << j+1 << " reservado com sucesso." << endl;
            } else {
                cout << "Assento " << i+1 << "-" << j+1 << " ja esta reservado." << endl;
            }
        }
            else if(opcao == 2){
                cout << "Reserva cancelada" << endl;
                lugares[i][j] = 0;
                return 0;
            }
    }
}
}
void ConsultarAssento(int i, int j){
    if(lugares[i][j] == 0){
        cout << "O assento " << i+1 << "-" << j+1 << " esta disponivel." << endl;
    } else {
        cout << "O assento " << i+1 << "-" << j+1 << " esta reservado." << endl;
    }
}