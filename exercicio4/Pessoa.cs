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
    }
}