using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModulZaro;

namespace ModulZaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List_szamitogep_update();
        }
 

        public void List_szamitogep_update()
        {
            listBox_Szamitogepek.Items.Clear();
            foreach (var item in Program.szamitogepek)
            {
                listBox_Szamitogepek.Items.Add(item);
            }
        }

        private void listBox_Szamitogepek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Szamitogepek.SelectedIndex < 0)
            {
                return;
            }
            Szamitogep item =(Szamitogep) listBox_Szamitogepek.SelectedItem;
            Program.Kivalasztott_szgep_index = listBox_Szamitogepek.SelectedIndex;

            textBox_Konfig.Text = item.Konfig;
            textBox_oprendszer.Text = item.Oprendszer.ToString();
            textBox_Tulajdonos.Text = item.Tulajdonos;
            checkBox_Gamer.Checked = item.Gamer;
            listBox_Alkatreszek.Items.Clear();
            foreach (var alkatresz in item.Alkatreszek.OrderBy(a => a.Megnevezes))
            {
                listBox_Alkatreszek.Items.Add(alkatresz);
            }
            textBox_Ar.Text = item.Ar().ToString("# ##0");
        }

        private void button_Szamitogepet_modosit_Click(object sender, EventArgs e)
        {
            Form uj = new Form_Szamitogep_Update();
            uj.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBox_Szamitogepek_SelectedIndexChanged(sender, e);
        }
    }
}
