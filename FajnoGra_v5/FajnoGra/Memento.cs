using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajnoGra
{
    class Memento
    {
        private Tuple<int,int,int,int,int,int,ulong> stanGry;
        public Memento(int liczbaChatkaDrwala, int liczbaTartak, int liczbaKamieniolom, int liczbaHawierniaZlota, int liczbaMennica, int lacznyPrzychod, ulong zloto)
        {
            stanGry = new Tuple<int, int, int, int, int, int, ulong>(liczbaChatkaDrwala, liczbaTartak, liczbaKamieniolom, liczbaHawierniaZlota, liczbaMennica, lacznyPrzychod, zloto);
        }

        public Memento(Tuple<int, int, int, int, int, int, ulong> stanGry)
        {
            this.stanGry = stanGry;
        }

        public Tuple<int, int, int, int, int, int, ulong> getState()
        {
            return stanGry;
        }
    }
}
