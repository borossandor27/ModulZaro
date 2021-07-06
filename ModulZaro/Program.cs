using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModulZaro
{
    static class Program
    {
        public static List<Szamitogep> szamitogepek = new List<Szamitogep>();
        public static int Kivalasztott_szgep_index;
        static void Main()
        {
            if(File.Exists("szamitogepek.csv") && File.Exists("alkatreszek.csv"))
            {
                using (StreamReader sr = new StreamReader("szamitogepek.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        szamitogepek.Add(new Szamitogep(sor[0], (Oprendszer)int.Parse(sor[1]), sor[2], bool.Parse(sor[3])));
                    };
                }               
                using (StreamReader sr = new StreamReader("alkatreszek.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        szamitogepek.Find(a => a.Konfig.Equals(sor[0])).Alkatreszek.Add(new Alkatresz(sor[1],sor[2],int.Parse(sor[3]),int.Parse(sor[4])));
                    };
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
