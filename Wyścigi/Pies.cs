using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Wyścigi
{
    public class Pies
    {
        public int PozycjaStartowa = 49;
        public int DlugoscTrasy = 760;
        public PictureBox MojObrazek;
        public int MojePolozenie = 0;
        public Random Losuj;
        private int Dystans;

        public bool Biegnij()
        {            
                Losuj = new Random();
                Dystans = 0;
                Dystans += Losuj.Next(1, 50);
                Point p = MojObrazek.Location;
                p.X += Dystans;
                MojObrazek.Location = p;
            Thread.Sleep(100);
                        
            if (MojObrazek.Location.X > DlugoscTrasy)
            {
                return true;
                
            }
            else
            {
                return false;
            }
            
        }
        public void WyzerujPozycje()
        {
            Point p = MojObrazek.Location;
            p.X = PozycjaStartowa;
            MojObrazek.Location = p;
            
        }
    }
}
