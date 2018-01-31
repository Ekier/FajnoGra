using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajnoGra
{
    class Zapis
    {
        private List<Memento> mementoList = new List<Memento>();
        public static int licznikZapisow;

        public void add(Memento state)
        {
            mementoList.Add(state);
            ++licznikZapisow;
        }

        public Memento get(int index)
        {
            return mementoList[index];
        }
    }
}
