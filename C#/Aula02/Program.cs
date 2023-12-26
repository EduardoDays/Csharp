using System; //biblioteca de entrada e saida padrão 

namespace Aula02 //organização dos objetos e classes, elementos deste programa
{
    class Program //por ser orientado a objeto, aqui esta um arquivo exercendo função de classe sendo o nome desta classe 'Program'
    {
        static void Main(string[] args) //metodo principal desta classe usando o padrão de argumentos de entrada com (string[] args)
        {
            Console.WriteLine("Valor inserido igual a: "); //imprime a frase escrita entre ("") 
            if(args.GetLength(0)>0){ //usando laço if para que o programa não trave no inicio de sua execução se não houverem argumentos de entrada maiores do que zero
                Console.Write(args.GetValue(0)); //neste caso, args.GetValue existe para obter os argumentos de entrada indica a posição do parametro captado em args para fazer a exibição do mesmo
            }            
        }
    }
}