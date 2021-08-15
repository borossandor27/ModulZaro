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
            Class_Szamitogep szg = (Class_Szamitogep)Program.form_nyito.listBox_Szamitogepek.SelectedItem;
            textBox_Konfig.Text = szg.Konfig;
            comboBox_OperaciosRendszer.SelectedIndex = (int)szg.Oprendszer;
            textBox_Tulajdonos.Text = szg.Tulajdonos;
            checkBox_Gamer.Checked = szg.Gamer;
            foreach (Class_Alkatresz item in szg.Alkatreszek)
            {
                listBox_Alkatreszek.Items.Add(item);
            }
            textBox_Ar.Text = szg.Ar().ToString("#,##0");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
        }

        private void button_Alkatreszek_Click(object sender, EventArgs e)
        {
            Form_Alkatresz form_Alkatresz = new Form_Alkatresz("new");
            form_Alkatresz.Show();
        }
    }
}
