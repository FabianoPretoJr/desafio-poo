using System;

namespace exercicio2
{
    public class Produto
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        
        public void Produto()
        {

        }

        public void Produto(string nome, double preco, int qtd)
        {
            
        }
    }
}