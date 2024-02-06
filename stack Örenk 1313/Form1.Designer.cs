namespace stack_Örenk_1313
{
    partial class Form1
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
            this.Müşteri = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.Müşteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // Müşteri
            // 
            this.Müşteri.BackColor = System.Drawing.SystemColors.Info;
            this.Müşteri.Controls.Add(this.btnEkle);
            this.Müşteri.Controls.Add(this.btnGetir);
            this.Müşteri.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Müşteri.Location = new System.Drawing.Point(34, 140);
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Size = new System.Drawing.Size(200, 83);
            this.Müşteri.TabIndex = 7;
            this.Müşteri.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 19);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 44);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(112, 19);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(82, 44);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Çağır";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(34, 90);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 28);
            this.txtAd.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(36, 34);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(38, 23);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(309, 302);
            this.Controls.Add(this.Müşteri);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Müşteri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Müşteri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
    }
}

