using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    public class CustomEventArgs : EventArgs
    {
        public string Elozo_nev { get; private set; }
        public string Jelen_nev { get; private set; }
        public CustomEventArgs(string el_nev, string jel_nev)
        {
            Elozo_nev = el_nev;
            Jelen_nev = jel_nev;
        }

    }
}
