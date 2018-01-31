using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajnoGra
{
    class BudynekB : Budynek
    {
       public BudynekB(int koszt, int przychod)
            : base(koszt, przychod)
        {

        }
        protected override bool BudujB(int liczbaChatkaDrwala, int liczbaTartak, int liczbaKamieniolom)
        {
            if (liczbaChatkaDrwala < 1 || liczbaTartak < 1 || liczbaKamieniolom < 1)
            {
                System.Windows.MessageBox.Show("Najprzod wybuduj chatkę drwala, tartak i kamieniołom!");
                return false;
            }
            else
                return true;
        }
    }
}
