#include <iostream>
#include <map>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

int main() {
    map<int, int> numeros;
    vector<int> listaNumeros;

    for (int i = 0; i < 100; ++i) {
        int numeroAleatorio = rand() % 100 + 1;
        listaNumeros.push_back(numeroAleatorio);
        numeros[numeroAleatorio]++;
    }

    sort(listaNumeros.begin(), listaNumeros.end());

    cout << "Lista de números em ordem crescente:\n";
    for (const auto& numero : listaNumeros) {
        cout << numero << " ";
    }
    cout << endl;

    listaNumeros.erase(remove_if(listaNumeros.begin(), listaNumeros.end(),
                                  [](int num) { return num % 2 == 0; }),
                       listaNumeros.end());

    cout << "Lista após remover os números pares:\n";
    for (const auto& numero : listaNumeros) {
        cout << numero << " ";
    }
    cout << endl;

    cout << "Números que se repetem:\n";
    bool encontrouRepetidos = false;

    for (const auto& par : numeros) {
        if (par.second > 1) {
            cout << par.first << " aparece " << par.second << " vezes.\n";
            encontrouRepetidos = true;
        }
    }
    
    if (!encontrouRepetidos) {
        cout << "Não há números repetidos.\n";
    }

    return 0;
}