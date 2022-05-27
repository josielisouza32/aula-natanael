using System;

namespace aula_natanael
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            //pessoa um
            string nomepessoaum = Console.ReadLine();
            string sobrenomepessoaum = Console.ReadLine();
            long IdadePessoa1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nomepessoaum} {sobrenomepessoaum}");

            // pessoa dois
            string nomepessoadois = Console.ReadLine();
            string sobrenomepessoadois = Console.ReadLine();
            long IdadePessoa2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nomepessoadois} {sobrenomepessoadois}");

            // pessoa tres 
            string nomepessoatres = Console.ReadLine();
            string sobrenomepessoatres = Console.ReadLine();
            long IdadePessoa3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nomepessoatres} {sobrenomepessoatres}");

            //pessoa quatro 
            pessoa pessoaquatro = new pessoa();

            pessoaquatro.nome = Console.ReadLine();
            pessoaquatro.sobrenome = Console.ReadLine();
            pessoaquatro.idade = int.Parse(Console.ReadLine());

            pessoaquatro.Exibirnomecompleto();

            pessoa pessoacinco = new pessoa();
            pessoacinco.nome = Console.ReadLine();
            pessoacinco.sobrenome = Console.ReadLine();
            pessoacinco.idade = int.Parse(Console.ReadLine();
                pessoacinco.Exibirnomecompleto();

           

            if (IdadePessoa1 >= 18)
                Console.WriteLine($"maio de idade");
            else
                Console.WriteLine("de menor");
        }
    }     
}

