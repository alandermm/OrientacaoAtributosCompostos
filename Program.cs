using System;

namespace atributoComposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Alander";
            p1.idade = 28;
            p1.endereco = new Endereco();
            p1.endereco.rua = "Rua João Martins";
            p1.endereco.numero = 687;
            p1.endereco.bairro = "Jardim Adhemar";

            //Console.WriteLine(p1.nome + " " + p1.idade + " " + p1.endereco.rua + ", " + p1.endereco.numero + " " + p1.endereco);

            //p1.mostrarDados();

            Console.WriteLine(p1);
        }
    }
}