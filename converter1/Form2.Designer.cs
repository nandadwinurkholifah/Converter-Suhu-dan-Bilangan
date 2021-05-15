
namespace converter1
{
    partial class F_suhu
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
            this.tb_celcius = new System.Windows.Forms.TextBox();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.lfahrenheit = new System.Windows.Forms.Label();
            this.lreamur = new System.Windows.Forms.Label();
            this.lkelvin = new System.Windows.Forms.Label();
            this.tb_fahrenheit = new System.Windows.Forms.TextBox();
            this.tb_reamur = new System.Windows.Forms.TextBox();
            this.tb_kelvin = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konversi Suhu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan celcius";
            // 
            // tb_celcius
            // 
            this.tb_celcius.Location = new System.Drawing.Point(254, 181);
            this.tb_celcius.Name = "tb_celcius";
            this.tb_celcius.Size = new System.Drawing.Size(138, 20);
            this.tb_celcius.TabIndex = 2;
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(480, 178);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(75, 23);
            this.btn_konversi.TabIndex = 3;
            this.btn_konversi.Text = "Konversi";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
            // 
            // lfahrenheit
            // 
            this.lfahrenheit.AutoSize = true;
            this.lfahrenheit.Location = new System.Drawing.Point(107, 317);
            this.lfahrenheit.Name = "lfahrenheit";
            this.lfahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lfahrenheit.TabIndex = 4;
            this.lfahrenheit.Text = "Fahrenheit";
            // 
            // lreamur
            // 
            this.lreamur.AutoSize = true;
            this.lreamur.Location = new System.Drawing.Point(377, 317);
            this.lreamur.Name = "lreamur";
            this.lreamur.Size = new System.Drawing.Size(44, 13);
            this.lreamur.TabIndex = 5;
            this.lreamur.Text = "Reamur";
            // 
            // lkelvin
            // 
            this.lkelvin.AutoSize = true;
            this.lkelvin.Location = new System.Drawing.Point(637, 320);
            this.lkelvin.Name = "lkelvin";
            this.lkelvin.Size = new System.Drawing.Size(36, 13);
            this.lkelvin.TabIndex = 6;
            this.lkelvin.Text = "Kelvin";
            // 
            // tb_fahrenheit
            // 
            this.tb_fahrenheit.Location = new System.Drawing.Point(89, 368);
            this.tb_fahrenheit.Name = "tb_fahrenheit";
            this.tb_fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tb_fahrenheit.TabIndex = 7;
            // 
            // tb_reamur
            // 
            this.tb_reamur.Location = new System.Drawing.Point(354, 368);
            this.tb_reamur.Name = "tb_reamur";
            this.tb_reamur.Size = new System.Drawing.Size(100, 20);
            this.tb_reamur.TabIndex = 8;
            // 
            // tb_kelvin
            // 
            this.tb_kelvin.Location = new System.Drawing.Point(612, 368);
            this.tb_kelvin.Name = "tb_kelvin";
            this.tb_kelvin.Size = new System.Drawing.Size(100, 20);
            this.tb_kelvin.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(589, 178);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // F_suhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_kelvin);
            this.Controls.Add(this.tb_reamur);
            this.Controls.Add(this.tb_fahrenheit);
            this.Controls.Add(this.lkelvin);
            this.Controls.Add(this.lreamur);
            this.Controls.Add(this.lfahrenheit);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.tb_celcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_suhu";
            this.Text = "Suhu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_celcius;
        private System.Windows.Forms.Button btn_konversi;
        private System.Windows.Forms.Label lfahrenheit;
        private System.Windows.Forms.Label lreamur;
        private System.Windows.Forms.Label lkelvin;
        private System.Windows.Forms.TextBox tb_fahrenheit;
        private System.Windows.Forms.TextBox tb_reamur;
        private System.Windows.Forms.TextBox tb_kelvin;
        private System.Windows.Forms.Button btn_clear;
    }
}