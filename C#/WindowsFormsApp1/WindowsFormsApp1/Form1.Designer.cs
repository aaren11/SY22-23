namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BuyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CanecelButton = new System.Windows.Forms.Button();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.cctextbox = new System.Windows.Forms.TextBox();
            this.exptextbox = new System.Windows.Forms.TextBox();
            this.ziptextbox = new System.Windows.Forms.TextBox();
            this.amountextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Feetextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(123, 208);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CC#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "EXP Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // CanecelButton
            // 
            this.CanecelButton.Location = new System.Drawing.Point(212, 208);
            this.CanecelButton.Name = "CanecelButton";
            this.CanecelButton.Size = new System.Drawing.Size(75, 23);
            this.CanecelButton.TabIndex = 7;
            this.CanecelButton.Text = "Cancel";
            this.CanecelButton.UseVisualStyleBackColor = true;
            this.CanecelButton.Click += new System.EventHandler(this.CanecelButton_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(197, 59);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(100, 22);
            this.nametextbox.TabIndex = 8;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // cctextbox
            // 
            this.cctextbox.Location = new System.Drawing.Point(197, 84);
            this.cctextbox.Name = "cctextbox";
            this.cctextbox.Size = new System.Drawing.Size(100, 22);
            this.cctextbox.TabIndex = 9;
            // 
            // exptextbox
            // 
            this.exptextbox.Location = new System.Drawing.Point(197, 113);
            this.exptextbox.Name = "exptextbox";
            this.exptextbox.Size = new System.Drawing.Size(100, 22);
            this.exptextbox.TabIndex = 10;
            // 
            // ziptextbox
            // 
            this.ziptextbox.Location = new System.Drawing.Point(197, 147);
            this.ziptextbox.Name = "ziptextbox";
            this.ziptextbox.Size = new System.Drawing.Size(100, 22);
            this.ziptextbox.TabIndex = 11;
            // 
            // amountextbox
            // 
            this.amountextbox.Location = new System.Drawing.Point(197, 177);
            this.amountextbox.Name = "amountextbox";
            this.amountextbox.Size = new System.Drawing.Size(100, 22);
            this.amountextbox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fee";
            // 
            // Feetextbox
            // 
            this.Feetextbox.Location = new System.Drawing.Point(187, 245);
            this.Feetextbox.Name = "Feetextbox";
            this.Feetextbox.Size = new System.Drawing.Size(100, 22);
            this.Feetextbox.TabIndex = 15;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Feetextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amountextbox);
            this.Controls.Add(this.ziptextbox);
            this.Controls.Add(this.exptextbox);
            this.Controls.Add(this.cctextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.CanecelButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CanecelButton;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox cctextbox;
        private System.Windows.Forms.TextBox exptextbox;
        private System.Windows.Forms.TextBox ziptextbox;
        private System.Windows.Forms.TextBox amountextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Feetextbox;
    }
}

