using System;
abstract class Padrao
{
    // metodo obrigatório
    public abstract void taxaEmprest(double valor);


    //Opcional
    public void calculoPoup(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
    }





}