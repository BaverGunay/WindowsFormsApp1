namespace WindowsFormsApp1
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.lblsan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldk = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblsa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(327, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "DURDUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "BASLAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(361, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 63);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsal.Location = new System.Drawing.Point(403, 57);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(87, 63);
            this.lblsal.TabIndex = 10;
            this.lblsal.Text = "00";
            // 
            // lblsan
            // 
            this.lblsan.AutoSize = true;
            this.lblsan.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsan.Location = new System.Drawing.Point(274, 57);
            this.lblsan.Name = "lblsan";
            this.lblsan.Size = new System.Drawing.Size(87, 63);
            this.lblsan.TabIndex = 9;
            this.lblsan.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(232, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 63);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // lbldk
            // 
            this.lbldk.AutoSize = true;
            this.lbldk.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldk.Location = new System.Drawing.Point(145, 57);
            this.lbldk.Name = "lbldk";
            this.lbldk.Size = new System.Drawing.Size(87, 63);
            this.lbldk.TabIndex = 7;
            this.lbldk.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = ":";
            // 
            // lblsa
            // 
            this.lblsa.AutoSize = true;
            this.lblsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsa.Location = new System.Drawing.Point(12, 57);
            this.lblsa.Name = "lblsa";
            this.lblsa.Size = new System.Drawing.Size(87, 63);
            this.lblsa.TabIndex = 14;
            this.lblsa.Text = "00";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lblsan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldk);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lblsan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsa;
    }
}