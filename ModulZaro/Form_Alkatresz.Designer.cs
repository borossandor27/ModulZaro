
namespace ModulZaro
{
    partial class Form_Alkatresz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alkatresz));
            this.listBox_All_alkatreszek = new System.Windows.Forms.ListBox();
            this.button_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Kivalasztott_alkatresz = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_Ar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Darab = new System.Windows.Forms.NumericUpDown();
            this.textBox_Megnevezes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Gyarto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_konfiguracio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Kivalasztott_alkatresz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Darab)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_All_alkatreszek
            // 
            this.listBox_All_alkatreszek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_All_alkatreszek.FormattingEnabled = true;
            this.listBox_All_alkatreszek.Location = new System.Drawing.Point(3, 16);
            this.listBox_All_alkatreszek.Name = "listBox_All_alkatreszek";
            this.listBox_All_alkatreszek.Size = new System.Drawing.Size(257, 269);
            this.listBox_All_alkatreszek.Sorted = true;
            this.listBox_All_alkatreszek.TabIndex = 11;
            this.listBox_All_alkatreszek.SelectedIndexChanged += new System.EventHandler(this.listBox_Alkatreszek_SelectedIndexChanged);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(239)))), ((int)(((byte)(206)))));
            this.button_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.button_new.Location = new System.Drawing.Point(12, 263);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(353, 37);
            this.button_new.TabIndex = 12;
            this.button_new.Text = "Hozzáadja a konfigurációhoz";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_All_alkatreszek);
            this.groupBox1.Location = new System.Drawing.Point(387, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 288);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rögzített alkatrészek";
            // 
            // groupBox_Kivalasztott_alkatresz
            // 
            this.groupBox_Kivalasztott_alkatresz.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.label6);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.numericUpDown_Ar);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.numericUpDown_Darab);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.textBox_Megnevezes);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.label5);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.textBox_Gyarto);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.label4);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.label3);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.label2);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.textBox_konfiguracio);
            this.groupBox_Kivalasztott_alkatresz.Controls.Add(this.label1);
            this.groupBox_Kivalasztott_alkatresz.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Kivalasztott_alkatresz.Name = "groupBox_Kivalasztott_alkatresz";
            this.groupBox_Kivalasztott_alkatresz.Size = new System.Drawing.Size(353, 228);
            this.groupBox_Kivalasztott_alkatresz.TabIndex = 15;
            this.groupBox_Kivalasztott_alkatresz.TabStop = false;
            this.groupBox_Kivalasztott_alkatresz.Text = "Kiválasztott alkatrész";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ft";
            // 
            // numericUpDown_Ar
            // 
            this.numericUpDown_Ar.Location = new System.Drawing.Point(111, 145);
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
            this.numericUpDown_Ar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Ar.TabIndex = 22;
            this.numericUpDown_Ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Ar.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_Darab
            // 
            this.numericUpDown_Darab.Location = new System.Drawing.Point(111, 189);
            this.numericUpDown_Darab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Darab.Name = "numericUpDown_Darab";
            this.numericUpDown_Darab.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Darab.TabIndex = 23;
            this.numericUpDown_Darab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Darab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_Megnevezes
            // 
            this.textBox_Megnevezes.Location = new System.Drawing.Point(102, 59);
            this.textBox_Megnevezes.Name = "textBox_Megnevezes";
            this.textBox_Megnevezes.Size = new System.Drawing.Size(162, 20);
            this.textBox_Megnevezes.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Megnevezés";
            // 
            // textBox_Gyarto
            // 
            this.textBox_Gyarto.Location = new System.Drawing.Point(102, 104);
            this.textBox_Gyarto.Name = "textBox_Gyarto";
            this.textBox_Gyarto.Size = new System.Drawing.Size(162, 20);
            this.textBox_Gyarto.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gyártó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Darab";
            // 
            // textBox_konfiguracio
            // 
            this.textBox_konfiguracio.Location = new System.Drawing.Point(102, 19);
            this.textBox_konfiguracio.Name = "textBox_konfiguracio";
            this.textBox_konfiguracio.ReadOnly = true;
            this.textBox_konfiguracio.Size = new System.Drawing.Size(162, 20);
            this.textBox_konfiguracio.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Konfiguráció";
            // 
            // Form_Alkatresz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 316);
            this.Controls.Add(this.groupBox_Kivalasztott_alkatresz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_new);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Alkatresz";
            this.Text = "Form_Alkatresz";
            this.Load += new System.EventHandler(this.Form_Alkatresz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Kivalasztott_alkatresz.ResumeLayout(false);
            this.groupBox_Kivalasztott_alkatresz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Darab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_All_alkatreszek;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Kivalasztott_alkatresz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ar;
        private System.Windows.Forms.NumericUpDown numericUpDown_Darab;
        private System.Windows.Forms.TextBox textBox_Megnevezes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Gyarto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_konfiguracio;
        private System.Windows.Forms.Label label1;
    }
}