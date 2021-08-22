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
using System.IO;

namespace ModulZaro
{
    public partial class Form_Nyito : Form
    {
        public int Kivalasztott_szgep_index;

        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List_szamitogep_update();
            foreach (var item in Enum.GetValues(typeof(Oprendszer)))
            {
                    comboBox_Oprendszer.Items.Add((Oprendszer)item);
            }
            textBox_Konfig.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox_Tulajdonos.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox_Ar.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
 

        public void List_szamitogep_update()
        {
            listBox_Szamitogepek.Items.Clear();

            if (File.Exists("szamitogepek.csv") && File.Exists("alkatreszek.csv"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader("szamitogepek.csv"))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] sor = sr.ReadLine().Split(';');
                            listBox_Szamitogepek.Items.Add(new Class_Szamitogep(sor[0], (Oprendszer)int.Parse(sor[1]), sor[2], bool.Parse(sor[3])));
                        }
                    }
                    using (StreamReader sr = new StreamReader("alkatreszek.csv"))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] sor = sr.ReadLine().Split(';');
                            foreach (Class_Szamitogep item in listBox_Szamitogepek.Items)
                            {
                                if (item.Konfig.Equals(sor[0]))
                                {
                                    Class_Alkatresz uj = new Class_Alkatresz(sor[1], sor[2], int.Parse(sor[3]), int.Parse(sor[4]));
                                    item.Alkatreszek.Add(uj);
                                    foreach (Class_Alkatresz alkatresz in item.Alkatreszek)
                                    {
                                        if (!taroltAlkatresz(alkatresz))
                                        {
                                            Program.alkatresz_all.Add(uj);
                                        }
                                    }
                                    
                    
                                }
                            }
                            
                        };
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool taroltAlkatresz(Class_Alkatresz alkatresz)
        {
            bool tarolt = false;
            if (Program.alkatresz_all.Any(a => a.Gyarto.Equals(alkatresz.Gyarto) && a.Megnevezes.Equals(alkatresz.Megnevezes) && a.Ar == alkatresz.Ar))
            {
                tarolt = true;
            }
            return tarolt;
        }

        private void listBox_Szamitogepek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Szamitogepek.SelectedIndex < 0)
            {
                return;
            }
            Class_Szamitogep item =(Class_Szamitogep) listBox_Szamitogepek.SelectedItem;
            Kivalasztott_szgep_index = listBox_Szamitogepek.SelectedIndex;

            textBox_Konfig.Text = item.Konfig;
            //textBox_oprendszer.Text = item.Oprendszer.ToString();
            comboBox_Oprendszer.SelectedIndex = (int)item.Oprendszer;
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

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Szamitogep = new Form_Szamitogep("new");
            Program.form_Szamitogep.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Szamitogep = new Form_Szamitogep("update");
            Program.form_Szamitogep.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Szamitogep = new Form_Szamitogep("delete");
            Program.form_Szamitogep.ShowDialog();
        }
    }
}
