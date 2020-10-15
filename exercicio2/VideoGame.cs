using System;

namespace exercicio2
{
    public class VideoGame
    {
        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        
        private bool isUsado;
        public bool IsUsado
        {
            get { return isUsado; }
            set { isUsado = value; }
        }
        
        public void Videogame()
        {

        }

        public void Videogame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            
        }
    }
}