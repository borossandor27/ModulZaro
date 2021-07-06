using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulZaro
{
    public partial class Form_Szamitogep : Form
    {
        public Form_Szamitogep()
        {
            InitializeComponent();
        }

        private void Form_Szamitogep_Load(object sender, EventArgs e)
        {
            comboBox_OperaciosRendszer.SelectedIndex = 0;
        }
    }
}
