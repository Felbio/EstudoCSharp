using System;
class PessoaFis : Padrao
{
// metodo obrigatorio
public override void taxaEmprest(double valor)
{
        Console.WriteLine("Taxa de empréstimo para pessoa física R$ " + (valor * 0.1));
    }
}