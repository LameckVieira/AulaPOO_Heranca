using System;
using classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();

            // Atribuimos um valor para a propriaedade disponivel 
            pf.nome = "Lameck";

            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();

            // Mostramos no console o método de saudação
            Console.WriteLine( pf.DarBoasVindas( pf.nome ) );

            Console.WriteLine( pf.validarCPF(pf.cpf));
        }
    }
}
