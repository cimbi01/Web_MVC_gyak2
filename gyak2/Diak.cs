using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    public class Diak
    {
        public delegate void OnChangeDel(object sender, CustomEventArgs nev);
        public event OnChangeDel ONChangeEvent;
        private string nev;
        public string Nev
        {
            get { return this.nev; }
            set
            {
                ONChangeEvent?.Invoke(this, new CustomEventArgs(this.nev, value));
                this.nev = value;
            }
        }

    }
}
