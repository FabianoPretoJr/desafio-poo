using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();

            v.Ligar();
            v.Pintar("Vermelho");
            v.Abastecer(20);
            v.Abastecer(40);
            v.Abastecer(10);
            v.Acelerar();
            v.Acelerar();
            v.Acelerar();
            v.Frear();
            v.Frear();
            v.Frear();
            v.Desligar();
        }
    }
}
