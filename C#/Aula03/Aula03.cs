using System;
class Aula03{
    static void Main(){
        byte n1=10; //0 e 255  
        int num1, num2, res; //numeros podendo ser negativos
        num1=10; //definindo o valor da primeira variavel podendo também defini-los na declaração de nomes 
        num2=2; //definindo o valor da segunda variavel podendo também defini-los na declaração de nomes 
        res = num1 * num2; //cauculo simples de numeros inteiros para exibição dos mesmos 

        char letra='8'; //caractere
        float valor=5.2f; //valores em deciaml
        string nome="Eduardo"; //textos

        var aux=nome; //tem o tipo de variavel definida de acordo com o valor inserido, neste caso o tipo de variavel é STRING

        Console.WriteLine("Valor da variavel: " + aux); //aqui, o valor de "aux" foi definido como string, recebendo assim o valor da string declarada como nome=Eduardo 
        Console.Write("Idade de " + aux + " é igual a: " + res); //exemplo da concatenação de uma variavel com um texto exibindo outra variavel diferente
    }
}