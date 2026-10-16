namespace PocitackaHezci
{
    partial class PocitackaHezci
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeleni = new Button();
            btnSoucin = new Button();
            btnRozdil = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtVysledek = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            btnSoucet = new Button();
            SuspendLayout();
            // 
            // btnDeleni
            // 
            btnDeleni.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btnDeleni.Location = new Point(129, 281);
            btnDeleni.Name = "btnDeleni";
            btnDeleni.Size = new Size(111, 104);
            btnDeleni.TabIndex = 19;
            btnDeleni.Text = "/";
            btnDeleni.UseVisualStyleBackColor = true;
            btnDeleni.Click += btnDeleni_Click;
            // 
            // btnSoucin
            // 
            btnSoucin.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btnSoucin.Location = new Point(14, 281);
            btnSoucin.Name = "btnSoucin";
            btnSoucin.Size = new Size(111, 104);
            btnSoucin.TabIndex = 18;
            btnSoucin.Text = "*";
            btnSoucin.UseVisualStyleBackColor = true;
            btnSoucin.Click += btnSoucin_Click;
            // 
            // btnRozdil
            // 
            btnRozdil.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btnRozdil.Location = new Point(129, 171);
            btnRozdil.Name = "btnRozdil";
            btnRozdil.Size = new Size(111, 104);
            btnRozdil.TabIndex = 17;
            btnRozdil.Text = "-";
            btnRozdil.UseVisualStyleBackColor = true;
            btnRozdil.Click += btnRozdil_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 115);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "Vysledek:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 15;
            label2.Text = "Hodnota B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 14;
            label1.Text = "Hodnota A:";
            // 
            // txtVysledek
            // 
            txtVysledek.Location = new Point(97, 112);
            txtVysledek.Name = "txtVysledek";
            txtVysledek.Size = new Size(143, 23);
            txtVysledek.TabIndex = 13;
            // 
            // txtB
            // 
            txtB.Location = new Point(97, 62);
            txtB.Name = "txtB";
            txtB.Size = new Size(143, 23);
            txtB.TabIndex = 12;
            // 
            // txtA
            // 
            txtA.Location = new Point(97, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(143, 23);
            txtA.TabIndex = 11;
            // 
            // btnSoucet
            // 
            btnSoucet.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btnSoucet.Location = new Point(12, 171);
            btnSoucet.Name = "btnSoucet";
            btnSoucet.Size = new Size(111, 104);
            btnSoucet.TabIndex = 10;
            btnSoucet.Text = "+";
            btnSoucet.UseVisualStyleBackColor = true;
            btnSoucet.Click += btnSoucet_Click;
            // 
            // PocitackaHezci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 402);
            Controls.Add(btnDeleni);
            Controls.Add(btnSoucin);
            Controls.Add(btnRozdil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtVysledek);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnSoucet);
            Name = "PocitackaHezci";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleni;
        private Button btnSoucin;
        private Button btnRozdil;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtVysledek;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnSoucet;
    }
}
