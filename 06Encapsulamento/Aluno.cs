using System.ComponentModel;
using System;

class Aluno
{
    //Atributos
    private double nota1, nota2;

    //Media
    private double Media()
    {
        return (nota1 + nota2) / 2;
    }
    //Mensagem
    public void Mensagem()
    {
        Console.WriteLine("informe a primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A media é " + Media());

    }
}
