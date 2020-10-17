using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace exercicio6
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

        public void VerificarJessica(List<Pessoa> pessoas)
        {
            bool aux = true;

            for(int i = 0; i < pessoas.Count; i++)
            {
                Pessoa p = pessoas[i];

                if (p.Nome == "Jessica")
                {
                    Console.WriteLine("Jessica existe, e sua idade é: " + p.Idade);  
                    aux = false;
                    break;                 
                }            
            }
            if (aux)
            {
                Console.WriteLine("Jessica não está na lista");
            }
        }
    }
}