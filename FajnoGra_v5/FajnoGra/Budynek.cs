using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajnoGra
{
    abstract class Budynek
    {
        protected int koszt;
        protected int przychod;

        public Budynek()
        {
            koszt = 0;
            przychod = 0;
        }


        public Budynek(int koszt, int przychod)
        {
            this.koszt = koszt;
            this.przychod = przychod;
        }

        public int Koszt { get => koszt; set => koszt = value; }
        public int Przychod { get => przychod; set => przychod = value; }

        protected bool budujA(ulong zloto)
        {
            if (zloto >= (ulong)koszt)
            {
                return true;
            }
            else
                return false;
        }

        protected virtual bool BudujB(int liczbaChatkaDrwala, int liczbaTartak, int liczbaKamieniolom)
        {
            return true;
        }

        public bool buduj(ulong zloto, int liczbaChatkaDrwala, int liczbaTartak, int liczbaKamieniolom)
        {

            if (!budujA(zloto))
            {
                System.Windows.MessageBox.Show("Za mało złota!");
                return false;
            }
            return BudujB(liczbaChatkaDrwala, liczbaTartak, liczbaKamieniolom);
        }
    }
}
