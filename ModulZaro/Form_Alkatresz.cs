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
    public partial class Form_Alkatresz : Form
    {
        string muvelet;
        Class_Alkatresz kivalasztott_alkatresz = null;
        public Form_Alkatresz(string mod)
        {
            InitializeComponent();
            muvelet = mod;
        }

        private void Form_Alkatresz_Load(object sender, EventArgs e)
        {
            listbox_update();
            textBox_konfiguracio.Text = Program.form_Szamitogep.textBox_Konfig.Text;
            switch (muvelet)
            {
                case "new":
                    alkatresz_new();
                    break;
                case "update":
                    alkatresz_update();
                    break;
                case "delete":
                    alkatresz_delete();
                    break;
                default:
                    break;
            }
        }

        private void alkatresz_delete()
        {
            throw new NotImplementedException();
        }

        private void alkatresz_update()
        {
            if (Program.form_Szamitogep.listBox_Alkatreszek.SelectedIndex < 0)
            {
                return;
            }
            this.BackColor = Color.FromArgb(255, 235, 156);
            this.ForeColor = Color.FromArgb(156, 87, 0);
            this.Text = "Alkatrész darabszámának a módosítása";
            button_new.Text = "Alkatrész darabszámának a módosítása";
            Class_Alkatresz alkatresz = (Class_Alkatresz)Program.form_Szamitogep.listBox_Alkatreszek.SelectedItem;
            textBox_konfiguracio.TabStop = true;
            textBox_konfiguracio.ReadOnly = true;
            textBox_Gyarto.Text = alkatresz.Gyarto;
            textBox_Gyarto.TabStop = true;
            textBox_Gyarto.ReadOnly = true;
            textBox_Megnevezes.Text = alkatresz.Megnevezes;
            textBox_Megnevezes.ReadOnly = true;
            textBox_Megnevezes.TabStop = true;
            numericUpDown_Ar.Value = alkatresz.Ar;
            numericUpDown_Ar.Enabled = false;
            numericUpDown_Darab.Value = alkatresz.Darab;
            groupBox1.Visible = false;
        }

        private void alkatresz_new()
        {
            this.Text = "Új alkatrész hozzáadása a konfigurációhoz";
            button_new.Text = "Új alkatrész hozzáadása a konfigurációhoz";
            this.BackColor = Color.FromArgb(198, 239, 206);
            this.ForeColor = Color.FromArgb(0, 97, 0);
        }

        void listbox_update()
        {
            listBox_All_alkatreszek.Items.Clear();
            foreach (Class_Szamitogep szg in Program.form_nyito.listBox_Szamitogepek.Items)
            {
                foreach (Class_Alkatresz alkatresz in szg.Alkatreszek)
                {
                    bool tarolt = false;
                        foreach (Class_Alkatresz item in listBox_All_alkatreszek.Items)
                        {
                        if (item.Megnevezes.Equals(alkatresz.Megnevezes) && item.Gyarto.Equals(alkatresz.Gyarto) && item.Ar==alkatresz.Ar)
                        {
                            tarolt = true;
                            break;
                        }
                        }
                    if (!tarolt)
                    {
                        listBox_All_alkatreszek.Items.Add(alkatresz);
                    }
                }
                //listBox_All_alkatreszek.Items.
            }
        }

        private void listBox_Alkatreszek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_All_alkatreszek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott alkatrész!");
            }
            kivalasztott_alkatresz = (Class_Alkatresz)listBox_All_alkatreszek.SelectedItem;
            textBox_Gyarto.Text = kivalasztott_alkatresz.Gyarto;
            textBox_Megnevezes.Text = kivalasztott_alkatresz.Megnevezes;
            numericUpDown_Ar.Value = kivalasztott_alkatresz.Ar;
            numericUpDown_Darab.Value = kivalasztott_alkatresz.Darab;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (kivalasztott_alkatresz==null)
            {
                MessageBox.Show("Nincs kiválasztott alkatrész!");
            }
            Class_Alkatresz alkatresz = (Class_Alkatresz)listBox_All_alkatreszek.SelectedItem;
            if (!kivalasztott_alkatresz.Gyarto.Equals(textBox_Gyarto.Text))
            {
                MessageBox.Show("Az alkatrész gyártója nem változtatható!");
                return;
            }            
            if (!kivalasztott_alkatresz.Megnevezes.Equals(textBox_Megnevezes.Text))
            {
                MessageBox.Show("Az alkatrész neve nem változtatható!");
                return;
            }
            if (!kivalasztott_alkatresz.Ar.Equals(numericUpDown_Ar.Value.ToString()))
            {
                MessageBox.Show("Az alkatrész ára nem változtatható!");
                return;
            }

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            //-- adatok ellenőrzése --------------------
            if (String.IsNullOrEmpty(textBox_konfiguracio.Text))
            {
                MessageBox.Show("Adja meg a konfiguráció nevét!");
                return;
            }
            if (String.IsNullOrEmpty(textBox_Gyarto.Text))
            {
                MessageBox.Show("Adja meg a gyártó nevét!");
                return;
            }
            if (String.IsNullOrEmpty(textBox_Megnevezes.Text))
            {
                MessageBox.Show("Adja meg az alkatrész megnevezését!");
                return;
            }

            //-- adatok feldolgozása -------------------
            Class_Alkatresz uj = new Class_Alkatresz(textBox_Megnevezes.Text, textBox_Gyarto.Text, (int)numericUpDown_Ar.Value, (int)numericUpDown_Darab.Value);
            int index = Program.form_Szamitogep.listBox_Alkatreszek.SelectedIndex;
            switch (muvelet)
            {
                case "new":
                    if (Program.form_Szamitogep.listBox_Alkatreszek.Items.Contains(uj))
                    {
                        MessageBox.Show("Már rögzítve van ez az alkatrész!");
                    }
                    else
                    {
                        Program.form_Szamitogep.listBox_Alkatreszek.Items.Add(uj);
                    }
                    this.Close();
                    break;
                case "update":
                    Program.form_Szamitogep.listBox_Alkatreszek.Items.RemoveAt(index);
                    Program.form_Szamitogep.listBox_Alkatreszek.Items.Insert(index, uj);
                    this.Close();
                    break;
                case "delete":
                    Program.form_Szamitogep.listBox_Alkatreszek.Items.RemoveAt(index);
                    break;
                default:
                    break;
            }
        }
    }
}
