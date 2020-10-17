using System;

namespace exercicio3
{
    public class Personagem
    {
        public Personagem()
        {
            this.nome = "";
            this.vida = 0;
            this.mana = 0;
            this.xp = 0;
            this.inteligencia = 0;
            this.forca = 0;
            this.level = 0;
        }

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            this.nome = nome;
            this.vida = vida;
            this.mana = mana;
            this.xp = xp;
            this.inteligencia = inteligencia;
            this.forca = forca;
            this.level = level;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private int vida;
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        
        private int mana;
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        
        private float xp;
        public float Xp
        {
            get { return xp; }
            set { xp = value; }
        }
        
        private int inteligencia;
        public int Inteligencia
        {
            get { return inteligencia; }
            set { inteligencia = value; }
        }
        
        private int forca;
        public int Forca
        {
            get { return forca; }
            set { forca = value; }
        }
        
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        
        public void lvlUp()
        {
            
        }
    }
}