using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public partial class Form1 : Form
    {
        Facet[] Faceci;
        Pies[] Psy;
        public int PiesZwycesca = 5;


        public Form1()
        {
            InitializeComponent();
            
            Faceci = new Facet[3];
            Psy = new Pies[4];

            Faceci[0] = new Facet { Imie = "Piotr", Gotowka = 10, MojLabel = PiotrLabel, MojRadioButton = PiotrRadioButton1 };
            Faceci[1] = new Facet { Imie = "Przemo", Gotowka = 100, MojLabel = PrzemoLabel, MojRadioButton = PrzemoRadioButton };
            Faceci[2] = new Facet { Imie = "Bob", Gotowka = 100, MojLabel = BobLabel, MojRadioButton = BobRadioButton };

            Psy[0] = new Pies { MojObrazek = pictureBox2 };
            Psy[1] = new Pies { MojObrazek = pictureBox3 };
            Psy[2] = new Pies { MojObrazek = pictureBox4 };
            Psy[3] = new Pies { MojObrazek = pictureBox5 };

            
            for (int i = 0; i < Faceci.Length; i++)
            {
                Faceci[i].Odswiez();
            }
            
            label3.Text = "Minimalny zakład: " + StawkaNumericUpDown1.Minimum + " zł";
        }

        private void StawiaButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Psy.Length; i++)
            {
                Psy[i].WyzerujPozycje();
            }
            for (int i = 0; i < Faceci.Length; i++)
            {
                if (Faceci[i].Imie == StawiaLabel.Text)
                {
                    Faceci[i].PostawZaklad((int)StawkaNumericUpDown1.Value, (int)PiesNumericUpDown1.Value);
                    Faceci[i].MojZaklad.PobierzZaklad();
                    Faceci[i].Odswiez();
                }
            }                
        }

        private void PiotrRadioButton1_Click(object sender, EventArgs e)
        {
            StawiaLabel.Text = Faceci[0].Imie;
            
        }

        private void PrzemoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StawiaLabel.Text = Faceci[1].Imie;
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StawiaLabel.Text = Faceci[2].Imie;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            PiesZwycesca = 5;
            while (PiesZwycesca == 5)
            {
                for (int i = 0; i < Psy.Length; i++)
                {
                    Psy[i].Biegnij();
                    if (Psy[i].Biegnij() == true)
                    {
                        MessageBox.Show("Mamy zwycięscę - chart numer " + (i + 1));
                        PiesZwycesca = i+1;
                        break;
                    }

                }
                
            }

            for (int i = 0; i < Faceci.Length; i++)
            {
                Faceci[i].Inkasuj(PiesZwycesca);
                Faceci[i].Odswiez();
            }
            
        }
    }
}
