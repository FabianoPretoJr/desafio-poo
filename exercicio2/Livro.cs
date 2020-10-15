using System;

namespace exercicio2
{
    public class Livro
    {
        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        private string tema;
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        
        private int qtdPag;
        public int QtdPag
        {
            get { return qtdPag; }
            set { qtdPag = value; }
        }
        
        public void Livro()
        {

        }

        public void Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            
        }
    }
}