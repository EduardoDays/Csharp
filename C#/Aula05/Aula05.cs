//existem alguns operadores para efetuar alguns tipos de contas, adição, multiplicação, divisão e assim por diante. aqui estão alguns desses operadores e suas funções. 

using System;

class Aula05{
    static void Main(){
        int res=(10+5)*2; //adição e multiplicação, o programa da prioridade para os valores dentr o de ().
        Console.WriteLine(res);

        bool res2=10>5; //Bool serve para exibir resultado verdadeiro ou falso. 
        Console.WriteLine(res2);

        int num=10; 
        num=num+1; //adição de valor dentro de uma variavel.
        //ou num+=1;
        Console.WriteLine(num);

        // & = AND / E --> reconhece os valores como true se todos forem verdadeiros.
        // | = OR / OU --> reconhece os valores como false se todos forem falsos.
        bool res3=(5>3)&(10<5);
        Console.WriteLine(res3);
    }
}