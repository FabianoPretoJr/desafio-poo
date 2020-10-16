using System;
using System.Collections.Generic;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);

            Console.WriteLine("\nLista antes da verificação: \n");
            p1.ListarPessoas(pessoas);

            p1.ExcluirMenores(pessoas);

            Console.WriteLine("\nLista depois da verificação: \n");
            p1.ListarPessoas(pessoas);
        }
    }
}
