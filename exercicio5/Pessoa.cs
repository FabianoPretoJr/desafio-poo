using System;
using System.Collections.Generic;

namespace exercicio5
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

        public void ExcluirMenores(List<Pessoa> pessoas)
        {

            for(int i = 0; i < pessoas.Count; i++)
            {
                Pessoa p = pessoas[i];

                if (p.Idade < 18)
                {
                    pessoas.Remove(pessoas[i]);
                }
            }
        }

        public void ListarPessoas(List<Pessoa> pessoas)
        {
            for(int i = 0; i < pessoas.Count; i++)
            {
                Pessoa p = pessoas[i];

                Console.WriteLine("\nNome: " + p.Nome);
                Console.WriteLine("Idade: " + p.Idade);
            }
        }
    }
}