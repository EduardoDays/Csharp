using System;
class Aula08{
    static void Main(){
        int v1,v2,soma; //criei 2 variaveis para incerir valores por meio do teclado e não atribui nenhum valor a elas.

        Console.WriteLine("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine()); //aqui é o lugar onde a variavel recebe o valor do teclado, usa-se (Console.ReadLine).
                                          // mas o valor chega no tipo string, sendo assim, é preciso converte-lo para o tipo da variavel (int), usei aqui este tipo de conversão (int.Parse).
        Console.WriteLine("Digite o segundo valor: "); 
        v2=Convert.ToInt32(Console.ReadLine()); //aqui também houve a necessidade de conversão, usei um metodo um pouco diferente, porém o resultado é o mesmo (Convert.ToInt32).

        soma = v1+v2; //Local onde fiz a operação e atribui os valores somados a variavel soma.

        Console.WriteLine("A soma de {0} com {1} é igual a: {2}", v1,v2,soma); //exibindo em uma string utilizando o metodo de indice.
    } 
}