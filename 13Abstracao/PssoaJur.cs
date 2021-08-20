using System;
class PssoaJur : Padrao

{
    public override void taxaEmprest(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para pessoa jurídica R$ " + (valor * 0.2));
    }
}
