using System; //neste exercicio é possivel ver como o uso de enumerador pode ser feito dentro de um código.
class Aula10{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
    static void Main(){
        int ds=(int)DiasSemana.Sexta;
        Console.WriteLine(ds);
    }
}