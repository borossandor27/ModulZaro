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
        public static Form_Nyito form_nyito = null;
        public static Form_Szamitogep form_Szamitogep = null;
        public static List<Class_Alkatresz> alkatresz_all = new List<Class_Alkatresz>();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_nyito = new Form_Nyito();
            //form_Szamitogep = new Form_Szamitogep();
            Application.Run(form_nyito);
        }
    }
}
