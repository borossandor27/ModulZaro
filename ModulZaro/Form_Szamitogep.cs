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
            Class_Szamitogep szamitogep = (Class_Szamitogep)Program.form_nyito.listBox_Szamitogepek.SelectedItem;
            textBox_Konfig.Text = szamitogep.Konfig;
            textBox_Konfig.TabStop = false;
            textBox_Konfig.ReadOnly = true;
            comboBox_OperaciosRendszer.SelectedIndex = (int)szamitogep.Oprendszer;
            textBox_Tulajdonos.Text = szamitogep.Tulajdonos;
            checkBox_Gamer.Checked = szamitogep.Gamer;
            listBox_Alkatreszek.Items.Clear();
            foreach (Class_Alkatresz item in szamitogep.Alkatreszek)
            {
                listBox_Alkatreszek.Items.Add(item);
            }
            listBox_Alkatreszek.Enabled = true;
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
            button_Muvelet.Text = "Konfiguráció rögzítése a listába";
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
            if (listBox_Alkatreszek.Items.Count >=10)
            {
                MessageBox.Show("A konfigurációban maximum 10 alkatrészt lehet tárolni!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_Alkatresz form_Alkatresz = new Form_Alkatresz("new");
            form_Alkatresz.ShowDialog();
        }

        private void button_Muvelet_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "new":
                    szamitogep_new_feldozgoz();
                    break;
                case "update":
                    szamitogep_update_feldozgoz();
                    break;
                case "delete":
                    szamitogep_delete_feldozgoz();
                    break;
                default:
                    break;
            }
        }

        private void szamitogep_delete_feldozgoz()
        {
            throw new NotImplementedException();
        }

        private void szamitogep_update_feldozgoz()
        {
            throw new NotImplementedException();
        }

        private void szamitogep_new_feldozgoz()
        {
            if (string.IsNullOrEmpty(textBox_Konfig.Text))
            {
                MessageBox.Show("Adjon nevet a konfigurációnak!");
                return;
            }
            if (comboBox_OperaciosRendszer.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon operációs rendszert!");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Tulajdonos.Text))
            {
                MessageBox.Show("Adja meg a tulajdonos nevét!");
            }
        }

        private void buttonalkatresz_update_Click(object sender, EventArgs e)
        {
            if (listBox_Alkatreszek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott alkatrész!");
            }
            Form_Alkatresz form_Alkatresz = new Form_Alkatresz("update");
            form_Alkatresz.ShowDialog();
        }
    }
}
