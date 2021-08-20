using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Denis";
            a.nota1 = 8.0;
            a.nota2 = 6.0;
            a.Mensagem();
        }
    }
}
