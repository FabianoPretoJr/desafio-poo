using System;

namespace exercicio1
{
    public class Veiculo
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
        
        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        
        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        
        private float km;
        public float Km
        {
            get { return km; }
            set { km = value; }
        }
        
        private bool isligado;
        public bool IsLigado
        {
            get { return isligado; }
            set { isligado = value; }
        }
        
        private int litrosCombustivel;
        public int LitrosCombustivel
        {
            get { return litrosCombustivel; }
            set { litrosCombustivel = value; }
        }
        
        private int velocidade;
        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        

        public void Acelerar()
        {
            if (IsLigado)
            {
                this.Velocidade = this.Velocidade + 20;

                Console.WriteLine("Velocidade = " + this.Velocidade);
            }
            else
            {
                Console.WriteLine("O veículo está desligado, ligueo para acelerar");
            }
            
        }

        public void Abastecer(int combustivel)
        {
            if (this.LitrosCombustivel + combustivel > 60)
            {
                Console.WriteLine("Quantidade ultrapassa limite de 60 litros!");
            }
            else
            {
                this.LitrosCombustivel = this.LitrosCombustivel + combustivel;

                Console.WriteLine("Tem " + this.LitrosCombustivel + " litros no tanque de combustivel");
            }            
        }

        public void Frear()
        {
            if (this.Velocidade > 0){
                this.Velocidade = this.Velocidade - 20;

                Console.WriteLine("Velocidade = " + this.Velocidade);
            }
            else
            {
                Console.WriteLine("Veículo está parado");
            }
        }

        public void Pintar(string cor)
        {
            this.Cor = cor;

            Console.WriteLine("O veículo foi pintado de " + this.Cor);
        }

        public void Ligar()
        {
            if (!IsLigado)
            {
                this.IsLigado = true;

                Console.WriteLine("Veículo ligado!");
            }           
        }

        public void Desligar()
        {
            if (IsLigado && this.Velocidade == 0)
            {
                this.IsLigado = false;

                Console.WriteLine("Veículo desligado!");
            }
            else
            {
                Console.WriteLine("Veículo já está desligado ou está em movimento");
            }
        }
    }
}