//escopo de variaveis, até onde ela pode ser visivel.
//até onde uma variavel pode ser acessada de onde ela foi declarada.

using System;

class Aula04{
    static int num=10; //esta é uma variavel global, pois ela pode ser acessada no código todo, independente do metodo onde ela for mencionada. 
    static void Main(){ 
        int num2=0; //esta é uma variavel local do metodo Main, pois ela só pode ser acessada nos limites de chave do mesmo.
        Console.WriteLine(num);
    } 

}

