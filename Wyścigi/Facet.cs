﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    class Facet
    {
        public string Imie;
        public int Gotowka;
        public Zaklad MojZaklad;
        
   
        public RadioButton MojRadioButton;
        public Label MojLabel;

        

        public void Odswiez()
        {
            MojRadioButton.Text = Imie + " ma " + Gotowka + " zł";
            if (MojZaklad==null)
            {
                MojLabel.Text = Imie + " nie zawarł zakładu";
            }
            else
            {
                MojLabel.Text = Imie + " stawia " + MojZaklad.Stawka + " zł na chrta numer " + MojZaklad.NrPsa;
            }
        }
        public void WyczyscZaklad()
        {
            MojZaklad = null;
        }
        
        public bool PostawZaklad(int stawka, int pies)
        {
            
            this.MojZaklad = new Zaklad();

            if (stawka <= this.Gotowka)
            {
               this.MojZaklad.Stawka = stawka;
               this.MojZaklad.NrPsa = pies;
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Inkasuj(int piesZwyciesca)
        {
            int WygranyPies = piesZwyciesca;
            this.Gotowka += this.MojZaklad.Wyplac(WygranyPies);
            this.Odswiez();
            this.MojZaklad = null;
            
        }


    }
}
