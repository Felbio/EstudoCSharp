using System;

namespace _13Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFis pf = new PessoaFis();
            pf.taxaEmprest(1000);

            PssoaJur pj = new PssoaJur();
            pj.taxaEmprest(1000);
        }
    }
}
