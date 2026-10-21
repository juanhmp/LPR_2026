#include <iostream>
using namespace std;
struct Filme{
        string Titulo;
        string Diretor;
        int AnoLancamento;
    };
    int main(){
        int maiorvalor=2027;
        int filmevelho = 0;
    Filme filmes[3];
    for (int i = 0; i < 3; i++){
    cout<<"Digite o titulo do filme "<<i+1<<": "<<endl;
    cin>> filmes[i].Titulo;
    cout<<"Digite o nome do diretor do filme "<<i+1<<": "<<endl;
    cin>> filmes[i].Diretor;
    cout<<"Digite o ano de lancamento do filme "<<i+1<<": "<<endl;
    cin>> filmes[i].AnoLancamento;
    if (filmes[i].AnoLancamento < maiorvalor){
        maiorvalor = filmes[i].AnoLancamento;
        filmevelho = i;
    }
}
cout<<"Os filmes digitados foram: "<<endl;
for (int i = 0; i < 3; i++){
    cout<<i+1<<". Titulo: "<<filmes[i].Titulo<<"|Diretor: "<<filmes[i].Diretor<<"|Ano de lancamento: "<<filmes[i].AnoLancamento<<endl;
}
cout<<"O filme mais antigo e: "<<filmes[filmevelho].Titulo<<"|Ano de lancamento: "<<filmes[filmevelho].AnoLancamento<<endl;
}