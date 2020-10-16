using System;
using System.Collections.Generic;

namespace exercicio4
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

            int maisVelho = 0;
            string nomeMaisVelho = "";

            for(int i = 0; i < pessoas.Count; i++)
            {
                Pessoa p = pessoas[i];

                if (p.Idade > maisVelho)
                {
                    maisVelho = p.Idade;
                    nomeMaisVelho = p.Nome;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomeMaisVelho);
        }
    }
}
