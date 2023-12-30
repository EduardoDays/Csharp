//sobre Bitwise 

using System;
class Aula09{
    static void Main(){
        int num=10;

        num=num<<1; //basicamente, Bitwise dobra o valor atribuido a variavel x número de vezes quando digitado assim << e divide ao meio x número de vezes quando digitado assim >>.

        Console.WriteLine("o valor de num com o Bitwise aplicado é de: {0}", num); //no caso, o numero exibido no executavel deve ser 20. 

    }
}