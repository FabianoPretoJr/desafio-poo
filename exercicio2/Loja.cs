using System;

namespace exercicio2
{
    public class Loja
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private string cnpj;
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        
        private List<Livro> livros;
        public List<Livro> Livros
        {
            get { return livros; }
            set { livros = value; }
        }
        
        private List<VideoGame> videoGames;
        public List<VideoGame> VideoGames
        {
            get { return videoGames; }
            set { videoGames = value; }
        }
        
        public void Loja()
        {

        }

        public void Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames)
        {

        }

        public double listaLivros()
        {
            return 0.0;
        }

        public void listaVideoGames()
        {

        }

        public void listaVideoGames()
        {

        }

        public double calculaPatrimonio()
        {
            return 0.0;
        }
    }
}