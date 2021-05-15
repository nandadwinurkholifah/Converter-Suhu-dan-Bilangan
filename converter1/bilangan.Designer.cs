
namespace converter1
{
    partial class bilangan
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_angka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.txtb_biner = new System.Windows.Forms.TextBox();
            this.txtb_dec = new System.Windows.Forms.TextBox();
            this.txtb_hex = new System.Windows.Forms.TextBox();
            this.txtb_oct = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konversi Bilangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan angka";
            // 
            // txt_angka
            // 
            this.txt_angka.Location = new System.Drawing.Point(202, 162);
            this.txt_angka.Name = "txt_angka";
            this.txt_angka.Size = new System.Drawing.Size(126, 20);
            this.txt_angka.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Binary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hexadesimal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Oktal";
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(388, 160);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(75, 23);
            this.btn_konversi.TabIndex = 7;
            this.btn_konversi.Text = "Konversi";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
            // 
            // txtb_biner
            // 
            this.txtb_biner.Location = new System.Drawing.Point(53, 369);
            this.txtb_biner.Name = "txtb_biner";
            this.txtb_biner.Size = new System.Drawing.Size(100, 20);
            this.txtb_biner.TabIndex = 8;
            // 
            // txtb_dec
            // 
            this.txtb_dec.Location = new System.Drawing.Point(243, 369);
            this.txtb_dec.Name = "txtb_dec";
            this.txtb_dec.Size = new System.Drawing.Size(100, 20);
            this.txtb_dec.TabIndex = 9;
            // 
            // txtb_hex
            // 
            this.txtb_hex.Location = new System.Drawing.Point(436, 369);
            this.txtb_hex.Name = "txtb_hex";
            this.txtb_hex.Size = new System.Drawing.Size(100, 20);
            this.txtb_hex.TabIndex = 10;
            // 
            // txtb_oct
            // 
            this.txtb_oct.Location = new System.Drawing.Point(629, 369);
            this.txtb_oct.Name = "txtb_oct";
            this.txtb_oct.Size = new System.Drawing.Size(100, 20);
            this.txtb_oct.TabIndex = 11;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(501, 159);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // bilangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txtb_oct);
            this.Controls.Add(this.txtb_hex);
            this.Controls.Add(this.txtb_dec);
            this.Controls.Add(this.txtb_biner);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_angka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bilangan";
            this.Text = "Bilangan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_angka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_konversi;
        private System.Windows.Forms.TextBox txtb_biner;
        private System.Windows.Forms.TextBox txtb_dec;
        private System.Windows.Forms.TextBox txtb_hex;
        private System.Windows.Forms.TextBox txtb_oct;
        private System.Windows.Forms.Button btn_clear;
    }
}