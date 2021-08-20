
namespace ModulZaro
{
    partial class Form_Nyito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.listBox_Szamitogepek = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.számítógépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Konfig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Tulajdonos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Gamer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Alkatreszek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Ar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Oprendszer = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Szamitogepek
            // 
            this.listBox_Szamitogepek.FormattingEnabled = true;
            this.listBox_Szamitogepek.Location = new System.Drawing.Point(13, 40);
            this.listBox_Szamitogepek.Name = "listBox_Szamitogepek";
            this.listBox_Szamitogepek.Size = new System.Drawing.Size(159, 303);
            this.listBox_Szamitogepek.TabIndex = 0;
            this.listBox_Szamitogepek.SelectedIndexChanged += new System.EventHandler(this.listBox_Szamitogepek_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.számítógépToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // számítógépToolStripMenuItem
            // 
            this.számítógépToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.számítógépToolStripMenuItem.Name = "számítógépToolStripMenuItem";
            this.számítógépToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.számítógépToolStripMenuItem.Text = "Számítógép";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.újToolStripMenuItem.Text = "Új...";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás...";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // textBox_Konfig
            // 
            this.textBox_Konfig.Location = new System.Drawing.Point(128, 27);
            this.textBox_Konfig.Name = "textBox_Konfig";
            this.textBox_Konfig.ReadOnly = true;
            this.textBox_Konfig.Size = new System.Drawing.Size(150, 20);
            this.textBox_Konfig.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alkatrészek";
            // 
            // textBox_Tulajdonos
            // 
            this.textBox_Tulajdonos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Tulajdonos.Location = new System.Drawing.Point(128, 89);
            this.textBox_Tulajdonos.Name = "textBox_Tulajdonos";
            this.textBox_Tulajdonos.ReadOnly = true;
            this.textBox_Tulajdonos.Size = new System.Drawing.Size(150, 20);
            this.textBox_Tulajdonos.TabIndex = 8;
            this.textBox_Tulajdonos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tulajdonos neve";
            // 
            // checkBox_Gamer
            // 
            this.checkBox_Gamer.AutoSize = true;
            this.checkBox_Gamer.Enabled = false;
            this.checkBox_Gamer.Location = new System.Drawing.Point(146, 120);
            this.checkBox_Gamer.Name = "checkBox_Gamer";
            this.checkBox_Gamer.Size = new System.Drawing.Size(118, 17);
            this.checkBox_Gamer.TabIndex = 9;
            this.checkBox_Gamer.Text = "Gamer konfiguráció";
            this.checkBox_Gamer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operációs rendszer";
            // 
            // listBox_Alkatreszek
            // 
            this.listBox_Alkatreszek.ForeColor = System.Drawing.SystemColors.GrayText;
            this.listBox_Alkatreszek.FormattingEnabled = true;
            this.listBox_Alkatreszek.Location = new System.Drawing.Point(128, 151);
            this.listBox_Alkatreszek.Name = "listBox_Alkatreszek";
            this.listBox_Alkatreszek.Size = new System.Drawing.Size(150, 147);
            this.listBox_Alkatreszek.Sorted = true;
            this.listBox_Alkatreszek.TabIndex = 10;
            this.listBox_Alkatreszek.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konfiguráció neve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ár";
            // 
            // textBox_Ar
            // 
            this.textBox_Ar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Ar.Location = new System.Drawing.Point(128, 309);
            this.textBox_Ar.Name = "textBox_Ar";
            this.textBox_Ar.ReadOnly = true;
            this.textBox_Ar.Size = new System.Drawing.Size(150, 20);
            this.textBox_Ar.TabIndex = 12;
            this.textBox_Ar.TabStop = false;
            this.textBox_Ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ft";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(239)))), ((int)(((byte)(206)))));
            this.groupBox1.Controls.Add(this.comboBox_Oprendszer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Ar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox_Alkatreszek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox_Gamer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Tulajdonos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Konfig);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(200, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 339);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott számítógép";
            // 
            // comboBox_Oprendszer
            // 
            this.comboBox_Oprendszer.Enabled = false;
            this.comboBox_Oprendszer.FormattingEnabled = true;
            this.comboBox_Oprendszer.Location = new System.Drawing.Point(128, 58);
            this.comboBox_Oprendszer.Name = "comboBox_Oprendszer";
            this.comboBox_Oprendszer.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Oprendszer.TabIndex = 14;
            this.comboBox_Oprendszer.TabStop = false;
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Szamitogepek);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "Számítógépek";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_Szamitogepek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem számítógépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Konfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Tulajdonos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Gamer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Alkatreszek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Ar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Oprendszer;
    }
}

