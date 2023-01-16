namespace WindowsFormsApp1
{
    partial class Form9
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
            this.lbSonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.bNotkta = new System.Windows.Forms.Button();
            this.bCarp = new System.Windows.Forms.Button();
            this.bEsit = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCikar = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bBol = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.Location = new System.Drawing.Point(35, 42);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 24);
            this.lbSonuc.TabIndex = 22;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(38, 67);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(359, 29);
            this.txtSonuc.TabIndex = 0;
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b0.Location = new System.Drawing.Point(38, 331);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(140, 69);
            this.b0.TabIndex = 19;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // bNotkta
            // 
            this.bNotkta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNotkta.Location = new System.Drawing.Point(184, 331);
            this.bNotkta.Name = "bNotkta";
            this.bNotkta.Size = new System.Drawing.Size(67, 69);
            this.bNotkta.TabIndex = 18;
            this.bNotkta.Text = ",";
            this.bNotkta.UseVisualStyleBackColor = true;
            this.bNotkta.Click += new System.EventHandler(this.bNotkta_Click);
            // 
            // bCarp
            // 
            this.bCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCarp.Location = new System.Drawing.Point(257, 106);
            this.bCarp.Name = "bCarp";
            this.bCarp.Size = new System.Drawing.Size(67, 69);
            this.bCarp.TabIndex = 17;
            this.bCarp.Text = "*";
            this.bCarp.UseVisualStyleBackColor = true;
            this.bCarp.Click += new System.EventHandler(this.ISLEM_OLAY);
            // 
            // bEsit
            // 
            this.bEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEsit.Location = new System.Drawing.Point(330, 256);
            this.bEsit.Name = "bEsit";
            this.bEsit.Size = new System.Drawing.Size(67, 144);
            this.bEsit.TabIndex = 16;
            this.bEsit.Text = "=";
            this.bEsit.UseVisualStyleBackColor = true;
            this.bEsit.Click += new System.EventHandler(this.bEsit_Click);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bC.Location = new System.Drawing.Point(330, 181);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(67, 69);
            this.bC.TabIndex = 15;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCikar
            // 
            this.bCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCikar.Location = new System.Drawing.Point(257, 256);
            this.bCikar.Name = "bCikar";
            this.bCikar.Size = new System.Drawing.Size(67, 69);
            this.bCikar.TabIndex = 14;
            this.bCikar.Text = "-";
            this.bCikar.UseVisualStyleBackColor = true;
            this.bCikar.Click += new System.EventHandler(this.ISLEM_OLAY);
            // 
            // bCE
            // 
            this.bCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCE.Location = new System.Drawing.Point(330, 106);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(67, 69);
            this.bCE.TabIndex = 13;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bBol
            // 
            this.bBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBol.Location = new System.Drawing.Point(257, 181);
            this.bBol.Name = "bBol";
            this.bBol.Size = new System.Drawing.Size(67, 69);
            this.bBol.TabIndex = 3;
            this.bBol.Text = "/";
            this.bBol.UseVisualStyleBackColor = true;
            this.bBol.Click += new System.EventHandler(this.ISLEM_OLAY);
            // 
            // bEkle
            // 
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.Location = new System.Drawing.Point(257, 331);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(67, 69);
            this.bEkle.TabIndex = 11;
            this.bEkle.Text = "+";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.ISLEM_OLAY);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.Location = new System.Drawing.Point(184, 256);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(67, 69);
            this.b3.TabIndex = 10;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b6.Location = new System.Drawing.Point(184, 181);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(67, 69);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b9.Location = new System.Drawing.Point(184, 106);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(67, 69);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.Location = new System.Drawing.Point(111, 256);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(67, 69);
            this.b2.TabIndex = 7;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.Location = new System.Drawing.Point(111, 181);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(67, 69);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b8.Location = new System.Drawing.Point(111, 106);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(67, 69);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.Location = new System.Drawing.Point(38, 256);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(67, 69);
            this.b1.TabIndex = 4;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.Location = new System.Drawing.Point(38, 181);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(67, 69);
            this.b4.TabIndex = 20;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b7.Location = new System.Drawing.Point(38, 106);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(67, 69);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.SAYI_CLICK);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 443);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bNotkta);
            this.Controls.Add(this.bCarp);
            this.Controls.Add(this.bEsit);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCikar);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bBol);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bNotkta;
        private System.Windows.Forms.Button bCarp;
        private System.Windows.Forms.Button bEsit;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCikar;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bBol;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
    }
}