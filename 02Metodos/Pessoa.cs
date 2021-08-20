using System;

class Pessoa 
{

    //Medodo 01
    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }
    //Medodo 02
    public void apresentar(string nome)
    {
Console.WriteLine("Olá " + nome);
    }
    //Medodo 03
    public void apresentar(string nome, int idade)
    {
Console.WriteLine("Olá " + nome + " voce tem " + idade + " anos!");
    }



}