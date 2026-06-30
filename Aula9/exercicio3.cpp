#include <iostream>
#include <list>
#include <ctime>
using namespace std;
int main(){
    list<int>numeros;
    for(int i = 0; i < 101; i++){
        srand(time(NULL));
        numeros[i] = rand()%101;
    }
}