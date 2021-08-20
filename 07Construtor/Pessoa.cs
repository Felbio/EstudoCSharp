using System;

class Pessoa
{
//construtor
    public Pessoa()
    {
        Console.WriteLine("Construtor executado!");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Olá " + nome+".");
    }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + " tua idade é " + idade+".");
    }


}