using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulZaro
{
    class Class_Alkatresz
    {
        readonly string megnevezes;
        readonly string gyarto;
        readonly int ar;
        int darab;

        public Class_Alkatresz(string megnevezes, string gyarto, int ar, int darab)
        {
            if (ar < 100) {
                throw new ArgumentOutOfRangeException("ar", "Alkatrész ára nem lehet 100 Ft-nál kisebb!"); } 
            else {
                this.ar = ar;
            }
            this.megnevezes = megnevezes ?? throw new ArgumentNullException(nameof(megnevezes));
            this.gyarto = gyarto ?? throw new ArgumentNullException(nameof(gyarto));
            Darab = darab;
        }

        public string Megnevezes => megnevezes;

        public string Gyarto => gyarto;

        public int Ar => ar;

        public int Darab { get => darab;
            set {
                if (value < 1) throw new ArgumentOutOfRangeException("darab", "Darabszám nem lehet 1-nél kisebb!");
                darab = value;
            }
        }

        public int Ertek()
        {
            return ar * darab;
        }

        public override string ToString()
        {
            return $"{megnevezes} ({gyarto}, {ar.ToString("# ##0")} Ft)";
        }
    }
}
