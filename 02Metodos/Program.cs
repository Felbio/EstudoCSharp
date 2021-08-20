using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.apresentar();
            p.apresentar("Felipe");
            p.apresentar("Felipe", 35);
        }
    }
}
