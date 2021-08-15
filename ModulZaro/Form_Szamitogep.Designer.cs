
namespace ModulZaro
{
    partial class Form_Szamitogep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Szamitogep));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Gamer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Tulajdonos = new System.Windows.Forms.TextBox();
            this.textBox_Konfig = new System.Windows.Forms.TextBox();
            this.button_Muvelet = new System.Windows.Forms.Button();
            this.comboBox_OperaciosRendszer = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Ar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_New_alkatresz = new System.Windows.Forms.Button();
            this.button_Alkatresz_remove = new System.Windows.Forms.Button();
            this.listBox_Alkatreszek = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ár";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Konfiguráció neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Operációs rendszer";
            // 
            // checkBox_Gamer
            // 
            this.checkBox_Gamer.AutoSize = true;
            this.checkBox_Gamer.Location = new System.Drawing.Point(149, 114);
            this.checkBox_Gamer.Name = "checkBox_Gamer";
            this.checkBox_Gamer.Size = new System.Drawing.Size(118, 17);
            this.checkBox_Gamer.TabIndex = 33;
            this.checkBox_Gamer.Text = "Gamer konfiguráció";
            this.checkBox_Gamer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tulajdonos neve";
            // 
            // textBox_Tulajdonos
            // 
            this.textBox_Tulajdonos.Location = new System.Drawing.Point(149, 83);
            this.textBox_Tulajdonos.Name = "textBox_Tulajdonos";
            this.textBox_Tulajdonos.Size = new System.Drawing.Size(214, 20);
            this.textBox_Tulajdonos.TabIndex = 32;
            // 
            // textBox_Konfig
            // 
            this.textBox_Konfig.Location = new System.Drawing.Point(149, 21);
            this.textBox_Konfig.Name = "textBox_Konfig";
            this.textBox_Konfig.ReadOnly = true;
            this.textBox_Konfig.Size = new System.Drawing.Size(214, 20);
            this.textBox_Konfig.TabIndex = 30;
            // 
            // button_Muvelet
            // 
            this.button_Muvelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Muvelet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_Muvelet.Location = new System.Drawing.Point(22, 407);
            this.button_Muvelet.Name = "button_Muvelet";
            this.button_Muvelet.Size = new System.Drawing.Size(353, 26);
            this.button_Muvelet.TabIndex = 38;
            this.button_Muvelet.Text = "Új számítógép konfiguráció rögzítése";
            this.button_Muvelet.UseVisualStyleBackColor = false;
            // 
            // comboBox_OperaciosRendszer
            // 
            this.comboBox_OperaciosRendszer.FormattingEnabled = true;
            this.comboBox_OperaciosRendszer.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "MacOS"});
            this.comboBox_OperaciosRendszer.Location = new System.Drawing.Point(149, 49);
            this.comboBox_OperaciosRendszer.Name = "comboBox_OperaciosRendszer";
            this.comboBox_OperaciosRendszer.Size = new System.Drawing.Size(214, 21);
            this.comboBox_OperaciosRendszer.TabIndex = 39;
            // 
            // numericUpDown_Ar
            // 
            this.numericUpDown_Ar.Location = new System.Drawing.Point(149, 144);
            this.numericUpDown_Ar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Ar.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Ar.Name = "numericUpDown_Ar";
            this.numericUpDown_Ar.Size = new System.Drawing.Size(187, 20);
            this.numericUpDown_Ar.TabIndex = 40;
            this.numericUpDown_Ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Ar.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_New_alkatresz);
            this.groupBox1.Controls.Add(this.button_Alkatresz_remove);
            this.groupBox1.Controls.Add(this.listBox_Alkatreszek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 204);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A konfiguráció elemei";
            // 
            // button_New_alkatresz
            // 
            this.button_New_alkatresz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_New_alkatresz.Location = new System.Drawing.Point(20, 130);
            this.button_New_alkatresz.Name = "button_New_alkatresz";
            this.button_New_alkatresz.Size = new System.Drawing.Size(331, 26);
            this.button_New_alkatresz.TabIndex = 47;
            this.button_New_alkatresz.Text = "Új alkatrész ";
            this.button_New_alkatresz.UseVisualStyleBackColor = true;
            this.button_New_alkatresz.Click += new System.EventHandler(this.button_New_alkatresz_Click);
            // 
            // button_Alkatresz_remove
            // 
            this.button_Alkatresz_remove.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Alkatresz_remove.Location = new System.Drawing.Point(20, 162);
            this.button_Alkatresz_remove.Name = "button_Alkatresz_remove";
            this.button_Alkatresz_remove.Size = new System.Drawing.Size(331, 26);
            this.button_Alkatresz_remove.TabIndex = 48;
            this.button_Alkatresz_remove.Text = "Alkatrész eltávolítása";
            this.button_Alkatresz_remove.UseVisualStyleBackColor = true;
            // 
            // listBox_Alkatreszek
            // 
            this.listBox_Alkatreszek.Enabled = false;
            this.listBox_Alkatreszek.FormattingEnabled = true;
            this.listBox_Alkatreszek.Location = new System.Drawing.Point(52, 13);
            this.listBox_Alkatreszek.Name = "listBox_Alkatreszek";
            this.listBox_Alkatreszek.Size = new System.Drawing.Size(299, 108);
            this.listBox_Alkatreszek.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-59, -37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Alkatrészei";
            // 
            // Form_Szamitogep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown_Ar);
            this.Controls.Add(this.comboBox_OperaciosRendszer);
            this.Controls.Add(this.button_Muvelet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_Gamer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Tulajdonos);
            this.Controls.Add(this.textBox_Konfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Szamitogep";
            this.Text = "Kiválasztott számítógép adatai";
            this.Load += new System.EventHandler(this.Form_Szamitogep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Gamer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Tulajdonos;
        private System.Windows.Forms.TextBox textBox_Konfig;
        private System.Windows.Forms.Button button_Muvelet;
        private System.Windows.Forms.ComboBox comboBox_OperaciosRendszer;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_New_alkatresz;
        private System.Windows.Forms.Button button_Alkatresz_remove;
        public System.Windows.Forms.ListBox listBox_Alkatreszek;
        private System.Windows.Forms.Label label5;
    }
}