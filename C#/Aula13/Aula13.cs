//uso de IF ELSE
using System;
class Aula13{
    static void Main(){
        
    int n1,n2,n3,n4;
    int res=0;
    string resultado;
    n1=n2=n3=n4=0;

    Console.WriteLine("Digite suas notas: ");
    Console.WriteLine("Nota 1: ");
    n1=int.Parse(Console.ReadLine());
    Console.WriteLine("Nota 2: ");
    n2=int.Parse(Console.ReadLine());
    Console.WriteLine("Nota 3: ");
    n3=int.Parse(Console.ReadLine());
    Console.WriteLine("Nota 4: ");
    n4=int.Parse(Console.ReadLine());

    res=n1+n2+n3+n4;

    // res < 40 = reprovado
    // res < 59 = recuperação 
    // res >= 60 = aprovado
    if(res < 40){ //diferente do IF, o IF ELSE é capaz de definir o valor de uma variavel caso o mesmo seja difente do proposto a ele.
        resultado="reprovado"; 
    }
    else if(res < 59){ 
        resultado="recuperação";//neste caso, como a variavel está acimad e 40 pontos, o else if define que 'resultado=recuperação' não precisando de definição da variavel no inicio do programa.
    }
    else{
        resultado="aprovado";//aqui também e alterada a variavel com o valor final sendo maior ou igual a 60.
    }
        Console.WriteLine("Nota: {0}, resultado: {1}",res, resultado);

    }
}
