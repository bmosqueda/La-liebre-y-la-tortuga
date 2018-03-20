using System;
using System.Windows.Forms;

namespace La_liebre_y_la_tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Corredor
        {
            public int Posicion { get { return posicion; } }
            private int posicion;
            protected static Random aleatorio;

            public Corredor()
            {
                posicion = 0;
                aleatorio = new Random();
            }

            protected abstract int getAvance();

            public void correr()
            {
                posicion += getAvance();
                //Si se resbala muchas veces no puede caer menos del inicio, 0
                if (posicion < 0)
                    posicion = 0;
            }
        }

        public class Tortuga : Corredor
        {
            protected override int getAvance()
            {
                int avance = aleatorio.Next(1, 11); 
                //rápido 50%    +3 pasos
                //resbalón 20%  -6 pasos
                //lento 30%     +1 paso
                switch(avance)
                {
                    case 1: case 2: case 3://lento
                        return 1;
                    case 4: case 5://rebalón
                        return -6;
                    default://rápido
                        return 3;
                }
            }

            public override string ToString()
            {
                return "Toruga está en la posición " + this.Posicion;
            }
        }

        public class Liebre : Corredor
        {
            protected override int getAvance()
            {
                int avance = aleatorio.Next(1, 11);
                //dormir 20%            0 pasos
                //salto grande 20%      9 pasos
                //resbalón grande 10%   -12 pasos
                //salto pequeño 30%     1 paso
                //resbalón pequeño 20% -2 pasos
                switch(avance)
                {
                    case 1: case 2: case 3:
                        return 1;//salto pequeño
                    case 4: case 5:
                        return 0;//dormir
                    case 6: case 7:
                        return 9;//salto grande
                    case 8: case 9:
                        return -2;//resbalón pequeño
                    default:
                        return -12;//resbalón grande
                        
                }
            }

            public override string ToString()
            {
                return "Liebre está en la posición " + this.Posicion;
            }
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            txtCarrera.Text = "";
            Tortuga tortuga = new Tortuga();
            Liebre liebre = new Liebre();

            //La pista mide 80 pasos
            while(tortuga.Posicion < 80 && liebre.Posicion < 80)
            {
                tortuga.correr();
                liebre.correr();

                txtCarrera.Text += tortuga.ToString() + "\n" + liebre.ToString() + "\n";
            }

            if (tortuga.Posicion >= 80 && liebre.Posicion >= 80)
                lblGanador.Text = "Empate";
            else
            {
                lblGanador.Text = "El ganador es " + (tortuga.Posicion > liebre.Posicion ? "Tortuga" : "Liebre");
            }
        }
    }
}
