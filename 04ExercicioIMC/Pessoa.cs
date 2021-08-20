using System;

class Pessoa
{
    public double altura, peso;

//calculo
    public double Calculo()
    {
        return peso / (altura * altura);

    }
    //situacao
public string Situacao(double imc)
{
        string retorno;
        if (imc < 18.5)
    {
            retorno = "Abaixo do peso!";
        }
    else if (imc < 25)
        {
            retorno = "Peso normal!";
        }
    else if (imc < 30)
        {
            retorno = "Acima do peso!";
        }

    else if (imc < 40)
        {
            retorno = "Obesidade I";
        }

    else if (imc < 45)
        {
            retorno = "Obesidade II";
        }
    else
        {
            retorno = "Obesidade III";
        }
        return retorno;

    }
    // Mensagem
    public void Mensagem()
    {
        // Obter Calculo
        double obterCalculo = Calculo();
        //Obter situação
        string obterSituacao = Situacao(obterCalculo);

        //Exibir mensagem
        Console.WriteLine("Seu IMC é de " + obterCalculo.ToString("F2"));
        Console.WriteLine("Sua situação é " + obterSituacao);
    }




}
