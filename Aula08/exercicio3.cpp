#include <iostream>
using namespace std;
struct Livro{
        string Titulo;
        string Autor;
        int AnoPublicacao;
        int NumeroPaginas;
        float Preco;
    };
int main(){
    int mediapg = 0;
    int pt = 0;
    int pg = 0;
    Livro livros[3];
    for (int i = 0; i < 3; i++){
    cout<<"Titulo Livro "<<i+1<<": "<<endl;
    cin>> livros[i].Titulo;
    cout<<"Autor Livro "<<i+1<<": "<<endl;
    cin>> livros[i].Autor;
    cout<<"Ano de Publicacao Livro "<<i+1<<": "<<endl;
    cin>> livros[i].AnoPublicacao;
    cout<<"Numero de Paginas Livro "<<i+1<<": "<<endl;
    cin>> livros[i].NumeroPaginas;
    cout<<"Preco Livro "<<i+1<<": "<<endl;
    cin>> livros[i].Preco;
    pt += livros[i].Preco;
    pg += livros[i].NumeroPaginas;
    }
    mediapg = pg / 3;
    cout<<"Media de paginas: "<<mediapg<<endl;
    cout<<"Valor total dos livros: "<<pt<<endl;
}