
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_konfiguracio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Gyarto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Megnevezes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Darab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ar = new System.Windows.Forms.NumericUpDown();
            this.listBox_Alkatreszek = new System.Windows.Forms.ListBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Darab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konfiguráció";
            // 
            // textBox_konfiguracio
            // 
            this.textBox_konfiguracio.Location = new System.Drawing.Point(177, 39);
            this.textBox_konfiguracio.Name = "textBox_konfiguracio";
            this.textBox_konfiguracio.ReadOnly = true;
            this.textBox_konfiguracio.Size = new System.Drawing.Size(162, 20);
            this.textBox_konfiguracio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Darab";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ár";
            // 
            // textBox_Gyarto
            // 
            this.textBox_Gyarto.Location = new System.Drawing.Point(177, 124);
            this.textBox_Gyarto.Name = "textBox_Gyarto";
            this.textBox_Gyarto.ReadOnly = true;
            this.textBox_Gyarto.Size = new System.Drawing.Size(162, 20);
            this.textBox_Gyarto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gyártó";
            // 
            // textBox_Megnevezes
            // 
            this.textBox_Megnevezes.Location = new System.Drawing.Point(177, 79);
            this.textBox_Megnevezes.Name = "textBox_Megnevezes";
            this.textBox_Megnevezes.ReadOnly = true;
            this.textBox_Megnevezes.Size = new System.Drawing.Size(162, 20);
            this.textBox_Megnevezes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Megnevezés";
            // 
            // numericUpDown_Darab
            // 
            this.numericUpDown_Darab.Location = new System.Drawing.Point(186, 209);
            this.numericUpDown_Darab.Name = "numericUpDown_Darab";
            this.numericUpDown_Darab.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Darab.TabIndex = 10;
            this.numericUpDown_Darab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Ar
            // 
            this.numericUpDown_Ar.Location = new System.Drawing.Point(186, 165);
            this.numericUpDown_Ar.Name = "numericUpDown_Ar";
            this.numericUpDown_Ar.ReadOnly = true;
            this.numericUpDown_Ar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Ar.TabIndex = 10;
            this.numericUpDown_Ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox_Alkatreszek
            // 
            this.listBox_Alkatreszek.FormattingEnabled = true;
            this.listBox_Alkatreszek.Location = new System.Drawing.Point(400, 23);
            this.listBox_Alkatreszek.Name = "listBox_Alkatreszek";
            this.listBox_Alkatreszek.Size = new System.Drawing.Size(235, 316);
            this.listBox_Alkatreszek.TabIndex = 11;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(42, 304);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(297, 37);
            this.button_Update.TabIndex = 12;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(42, 246);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(297, 37);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Töröl";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // Form_Alkatresz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 372);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.listBox_Alkatreszek);
            this.Controls.Add(this.numericUpDown_Ar);
            this.Controls.Add(this.numericUpDown_Darab);
            this.Controls.Add(this.textBox_Megnevezes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Gyarto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_konfiguracio);
            this.Controls.Add(this.label1);
            this.Name = "Form_Alkatresz";
            this.Text = "Form_Alkatresz";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Darab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_konfiguracio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Gyarto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Megnevezes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_Darab;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ar;
        private System.Windows.Forms.ListBox listBox_Alkatreszek;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}