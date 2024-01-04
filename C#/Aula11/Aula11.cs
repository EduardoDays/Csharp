//quando não a a possibilidade de conversão inplicita de um tipo, é usado o typecast para converter o mesmo, como no exemplo a seguir.
using System;
class Aula11{
    static void Main(){
        double v1=10.5;
        int v2=(int)v1; //neste caso, é necessario fazer um typecast pois não é possivel converter de forma implicita os tipos 'double' em 'int' 

        Console.WriteLine(v2);

    }
}