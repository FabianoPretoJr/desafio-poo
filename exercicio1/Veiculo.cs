using System;

namespace exercicio1
{
    public class Veiculo
    {       
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public float Km { get; set; }

        public bool IsLigado { get; set; }

        public int LitrosCombustivel { get; set; }

        public int Velocidade { get; set; }

        public double Preco { get; set; }

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