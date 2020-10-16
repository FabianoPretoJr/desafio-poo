using System;
using System.Collections.Generic;

namespace exercicio4
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.nome = "";
            this.idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public void ListarPessoas(List<Pessoa> pessoas)
        {
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