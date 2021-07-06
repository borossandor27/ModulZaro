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
    public partial class Form_Szamitogep_Update : Form
    {
        public Form_Szamitogep_Update()
        {
            InitializeComponent();
        }

        private void Form_Szamitogep_Load(object sender, EventArgs e)
        {
            comboBox_OperaciosRendszer.SelectedIndex = 0;
            Szamitogep szg = Program.szamitogepek[Program.Kivalasztott_szgep_index];
            textBox_Konfig.Text = szg.Konfig;
            comboBox_OperaciosRendszer.SelectedIndex = (int)szg.Oprendszer;
            textBox_Tulajdonos.Text = szg.Tulajdonos;
            checkBox_Gamer.Checked = szg.Gamer;
            foreach (Alkatresz item in szg.Alkatreszek)
            {
                listBox_Alkatreszek.Items.Add(item);
            }
            textBox_Ar.Text = szg.Ar().ToString("#,##0");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Program.szamitogepek[Program.Kivalasztott_szgep_index].Oprendszer = (Oprendszer) comboBox_OperaciosRendszer.SelectedIndex;
            Program.szamitogepek[Program.Kivalasztott_szgep_index].Tulajdonos = textBox_Tulajdonos.Text;
            Program.szamitogepek[Program.Kivalasztott_szgep_index].Gamer = checkBox_Gamer.Checked;
            this.Close();
        }
    }
}
