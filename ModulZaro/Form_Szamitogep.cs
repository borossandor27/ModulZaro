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
        string muvelet;
        public Form_Szamitogep(string mod)
        {
            InitializeComponent();
            muvelet = mod;
        }

        private void Form_Szamitogep_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "new":
                    szamitogep_new();
                    break;
                case "update":
                    szamitogep_update();
                    break;
                case "delete":
                    szamitogep_delete();
                    break;
                default:
                    break;
            }
            comboBox_OperaciosRendszer.SelectedIndex = 0;
        }

        private void szamitogep_delete()
        {
            this.Text = "Konfiguráció törlése";
            button_Muvelet.Text = "Kiválasztott konfiguráció törlése";
            this.BackColor = Color.FromArgb(255, 199, 206);
            this.ForeColor = Color.FromArgb(156, 0, 6);
        }

        private void szamitogep_update()
        {
            this.Text = "Konfiguráció adatainak módosítása";
            button_Muvelet.Text = "Kiválasztott konfiguráció adatinak a módosítása";
            this.BackColor = Color.FromArgb(255, 235, 156);
            this.ForeColor = Color.FromArgb(156, 87, 0);

        }

        private void szamitogep_new()
        {
            this.Text = "Új konfiguráció megadása";
            button_Muvelet.Text = "Kiválasztott konfiguráció törlése";
            this.BackColor = Color.FromArgb(198, 239, 206);
            this.ForeColor = Color.FromArgb(0, 97, 0);
            textBox_Konfig.ReadOnly = false;
            textBox_Konfig.Text = "";
            comboBox_OperaciosRendszer.SelectedIndex = -1;
            textBox_Tulajdonos.Text = "";
            numericUpDown_Ar.Value = 100;
            checkBox_Gamer.Checked = false;
            listBox_Alkatreszek.Items.Clear();
        }

        private void button_Alkatreszek_Click(object sender, EventArgs e)
        {
            Form_Alkatresz form_Alkatresz = new Form_Alkatresz("new");
            form_Alkatresz.ShowDialog();
        }

        private void listBox_Alkatreszek_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_New_alkatresz_Click(object sender, EventArgs e)
        {
            Form_Alkatresz form_Alkatresz = new Form_Alkatresz("new");
            form_Alkatresz.ShowDialog();
        }
    }
}
