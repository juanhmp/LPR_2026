#include <iostream>
using namespace std;
struct Chamado{
    int Numero;
    string Solicitante;
    string Setor;
    int Prioridade;
    string Status;
    int Descricao;
};
Chamado chamados[10];
void cadastrarChamado(){
    int i = 0;
    if (i >= 10)
    {
        cout << "Limite de chamados atingido." << endl;
        return;
    }
    cout << "Cadastro de Chamados" << endl;
    cout << "Digite o numero do chamado: ";
    cin >> chamados[i].Numero;
    cout << "Digite o nome do solicitante: ";
    cin >> chamados[i].Solicitante;
    cout << "Digite o setor: ";
    cin >> chamados[i].Setor;
    cout << "Digite a prioridade (1 a 3): ";
    cin >> chamados[i].Prioridade;
    cout << "Digite a descricao: ";
    cin >> chamados[i].Descricao;
    chamados[i].Status = 1;
    i++;
    return;
}
void listarChamados(){
    for (int i = 0; i < 10; i++)
    {        
        cout << "Chamado " << chamados[i].Numero << endl;
        cout << "Solicitante: " << chamados[i].Solicitante << endl;
        cout << "Setor: " << chamados[i].Setor << endl;
        cout << "Prioridade: " << chamados[i].Prioridade << endl;
        cout << "Status: " << chamados[i].Status << endl;
        cout << "Descricao: " << chamados[i].Descricao << endl;
    }
}
void atualizarStatus(){
    int numero = 0;
    cout << "Qual o numero do chamado que voce deseja alterar o status?" << endl;
    cin  >> numero;
    for (int i=0; i<10; i++){
        if (numero= chamados[i].Numero){
            if(chamados[i].Status == "1"){
                chamados[i].Status = "aberto";
            }
            if(chamados[i].Status == "2"){
                chamados[i].Status = "em andamento";
            }
            if(chamados[i].Status == "3"){
                chamados[i].Status = "resolvido";
            }
            if(chamados[i].Status == "4"){
                chamados[i].Status = "cancelado";
            }
            cout << "O status dessa chamada esta " <<chamados[i].Status<< ". Para qual voce gostaria de mudar?(Use numeros de 1 a 4. 1: Aberto || 2: Em andamento || 3: Resolvido || 4: Cancelado)";
            cin >> chamados[i].Status;
        } 
    }
}
void classificarPrioridade(){
    for(int i = 0; i<10; i++){
        cout << "A chamada " << chamados[i].Numero << "tem prioridade ";
        if(chamados[i].Prioridade == 1){
            cout << "baixa" << endl;
        }
        if(chamados[i].Prioridade == 2){
            cout << "media" << endl;
        }
        if(chamados[i].Prioridade == 3){
            cout << "alta" << endl;
        }
    }
}
void estatisticas(){
    for(int i = 0; i<10; i++){
        int a = 0, ea = 0, r = 0, c = 0;
        if (chamados[i].Status == "1"){
            a++;
        }
        if (chamados[i].Status == "2"){
            ea++;
        }
        if (chamados[i].Status == "3"){
            r++;
        }
        if (chamados[i].Status == "4"){
            c++;
        }
         cout << "O numero de chamados abertos eh de: " << a << endl;
         cout << "O numero de chamados em andamento eh de: " << ea << endl;
         cout << "O numero de chamados resolvidos eh de: " << r << endl;
         cout << "O numero de chamados cancelados eh de: " << c << endl;

    }
}
int main(){
    int opcao;
    cout << "Sistema de Chamados" << endl;
    cout << "1. Cadastrar Chamado" << endl;
    cout << "2. Listar Chamados" << endl;
    cout << "3. Atualizar Status" << endl;
    cout << "4. Classificar Prioridade" << endl;
    cout << "5. Estatisticas" << endl;
    cin >> opcao;
    if (opcao == 1)
    {
        cadastrarChamado();
    }
    else if (opcao == 2)
    {
        listarChamados();
    }
    else if (opcao == 3)
    {
        atualizarStatus();
    }
    else if (opcao == 4)
    {
        classificarPrioridade();
    }
    else if (opcao == 5)
    {
        estatisticas();
    }
    return 0;
}