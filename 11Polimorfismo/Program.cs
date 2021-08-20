using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo poli = varios, morfos = formas;

            //instanciar Estagiario
            Console.WriteLine("Estagiário");
            Imposto objE = new Imposto();
            objE.valeAlimentacao(1000);
            objE.valeTransporte(1000);
            Console.WriteLine("=======================");
            //instanciar Gerente
            Console.WriteLine("Gerente");
            Imposto objG = new Gerente();
            objG.valeAlimentacao(5000);
            objG.valeTransporte(5000);
            Console.WriteLine("=======================");
            //instanciar Atendente
            Console.WriteLine("Atendente");
            Imposto objA = new Atendente();
            objA.valeAlimentacao(2000);
            objA.valeTransporte(2000);
        }
    }
}
