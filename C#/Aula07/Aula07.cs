using System;

class Aula07{

    static void Main(){

        const string nome="Edu"; //quando definido o tipo da variavel como sendo constante, não é possivel fazer a alteração da mesma variavel no programa, pois o valor dela é fixo. 
        const double pi=3.1415;

        //nome="Oliveira"; --> neste caso, a tentativa de atribuir um novo valor a variavel seria erronia, pois a variavel nome é do tipo const string, sendo de valor fixo.

        Console.WriteLine("O nome do usuário é: {0}, e o seu numero da sorte é: {1}" , nome, pi);
    }
}