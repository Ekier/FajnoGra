using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajnoGra
{
    class Gra
    {
        private int liczbaChatkaDrwala;
        private int liczbaTartak;
        private int liczbaKamieniolom;
        private int liczbaHawierniaZlota;
        private int liczbaMennica;

        private int lacznyPrzychod;

        private ulong zloto;

        private Tuple<int, int, int, int, int, int, ulong> stanGry;

        public int LiczbaChatkaDrwala { get => liczbaChatkaDrwala; set => liczbaChatkaDrwala = value; }
        public int LiczbaTartak { get => liczbaTartak; set => liczbaTartak = value; }
        public int LiczbaKamieniolom { get => liczbaKamieniolom; set => liczbaKamieniolom = value; }
        public int LiczbaHawierniaZlota { get => liczbaHawierniaZlota; set => liczbaHawierniaZlota = value; }
        public int LiczbaMennica { get => liczbaMennica; set => liczbaMennica = value; }
        public ulong Zloto { get => zloto; set => zloto = value; }
        public int LacznyPrzychod { get => lacznyPrzychod; set => lacznyPrzychod = value; }
        public Tuple<int, int, int, int, int, int, ulong> StanGry { get => stanGry; set => stanGry = value; }

        public Gra()
        {
            LiczbaChatkaDrwala = 0;
            LiczbaTartak = 0;
            LiczbaKamieniolom = 0;
            LiczbaHawierniaZlota = 0;
            LiczbaMennica = 0;
            zloto = 2000;
            lacznyPrzychod = 0;
        }

        public void setState(Tuple<int, int, int, int, int, int, ulong> stanGry)
        {
            this.StanGry = stanGry;
        }

        public Tuple<int, int, int, int, int, int, ulong> getState()
        {
            return StanGry;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(StanGry);
        }

        public void getStateFromMemento(Memento memento)
        {
            StanGry = memento.getState();
        }
    }
}
