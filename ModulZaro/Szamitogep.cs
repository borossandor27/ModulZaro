using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulZaro
{
    class Szamitogep
    {
        readonly string konfig;
        Oprendszer oprendszer;
        string tulajdonos;
        bool gamer;
        List<Alkatresz> alkatreszek = new List<Alkatresz>();

        public string Konfig => konfig;

        public string Tulajdonos { get => tulajdonos; set => tulajdonos = value; }
        public bool Gamer { get => gamer; set => gamer = value; }
        internal Oprendszer Oprendszer { get => oprendszer; set => oprendszer = value; }
        internal List<Alkatresz> Alkatreszek { get => alkatreszek; set => alkatreszek = value; }

        public Szamitogep(string konfig, string tulajdonos, bool gamer, Oprendszer oprendszer, List<Alkatresz> alkatreszek)
        {
            this.konfig = konfig;
            Tulajdonos = tulajdonos;
            Gamer = gamer;
            Oprendszer = oprendszer;
            Alkatreszek = alkatreszek;
        }

        public Szamitogep(string konfig, Oprendszer oprendszer, string tulajdonos, bool gamer)
        {
            this.konfig = konfig;
            Oprendszer = oprendszer;
            Tulajdonos = tulajdonos;
            Gamer = gamer;
        }

        public int Ar()
        {
            double sum = 0;
            foreach (var item in alkatreszek)
            {
                sum += item.Ertek();
            }
            if (gamer)
            {
                sum *= 1.3;
            }
            if (oprendszer==Oprendszer.Windows)
            {
                sum += 40000;
            }
            else if (oprendszer == Oprendszer.MacOS)
            {
                sum += 100000;
            }
            return (int)sum;
        }
        public override string ToString()
        {
            return konfig;
        }
    }
}
