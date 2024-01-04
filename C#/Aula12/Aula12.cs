//uso do comando condicional IF
using System;
class Aula12{
    static async void Main(){
    int n1,n2,n3,n4;
    int res=0;
    string resultado="Reprovado";
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

    if(res >= 60){ //o IF é um condicional usado para fazer determinada ação SE um valor de uma variavel for atendido, como neste exemplo.
        resultado="Aprovado"; //se a variavel res for maior ou igual que 60, a variavel 'resultado' sera alterada para aprovado.
    }
        Console.WriteLine("Nota: {0}, resultado: {1}",res, resultado); //caso não seja atingida a nota minima para alteração da variavel, ela será exibida como foi predefinida.

    
    }
}