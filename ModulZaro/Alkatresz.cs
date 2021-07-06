using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulZaro
{
    enum Oprendszer { Windows, Linux, MacOS };
    class Alkatresz
    {
        readonly string megnevezes;
        readonly string gyarto;
        readonly int ar;
        int darab;

        public Alkatresz(string megnevezes, string gyarto, int ar, int darab=1)
        {
            this.megnevezes = megnevezes;
            this.gyarto = gyarto;
            this.ar = ar;
            this.darab = darab;
        }

        public string Megnevezes => megnevezes;

        public string Gyarto => gyarto;

        public int Ar => ar;

        public int Darab { get => darab; set => darab = value; }

        public int Ertek()
        {
            return ar * darab;
        }

        public override string ToString()
        {
            return megnevezes;
        }
    }
}
