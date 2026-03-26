namespace winVoiture
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnValiderR = new Button();
            txtContenu = new TextBox();
            label2 = new Label();
            txtCapacite = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnValiderV = new Button();
            txtReservoir = new TextBox();
            lblReservoir = new Label();
            txtVitesseMax = new TextBox();
            txtCompteur = new TextBox();
            lblVitesseMax = new Label();
            lblCompteur = new Label();
            txtVitesse = new TextBox();
            lblVitesse = new Label();
            txtlmmat = new TextBox();
            lbllmmat = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnValiderR);
            groupBox1.Controls.Add(txtContenu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCapacite);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(58, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Réservoire";
            // 
            // btnValiderR
            // 
            btnValiderR.Location = new Point(94, 158);
            btnValiderR.Name = "btnValiderR";
            btnValiderR.Size = new Size(94, 29);
            btnValiderR.TabIndex = 4;
            btnValiderR.Text = "Valider";
            btnValiderR.UseVisualStyleBackColor = true;
            btnValiderR.Click += button1_Click;
            // 
            // txtContenu
            // 
            txtContenu.Location = new Point(119, 93);
            txtContenu.Name = "txtContenu";
            txtContenu.Size = new Size(125, 27);
            txtContenu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Contenu";
            // 
            // txtCapacite
            // 
            txtCapacite.Location = new Point(119, 46);
            txtCapacite.Name = "txtCapacite";
            txtCapacite.Size = new Size(125, 27);
            txtCapacite.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Capacité";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnValiderV);
            groupBox2.Controls.Add(txtReservoir);
            groupBox2.Controls.Add(lblReservoir);
            groupBox2.Controls.Add(txtVitesseMax);
            groupBox2.Controls.Add(txtCompteur);
            groupBox2.Controls.Add(lblVitesseMax);
            groupBox2.Controls.Add(lblCompteur);
            groupBox2.Controls.Add(txtVitesse);
            groupBox2.Controls.Add(lblVitesse);
            groupBox2.Controls.Add(txtlmmat);
            groupBox2.Controls.Add(lbllmmat);
            groupBox2.Location = new Point(405, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 312);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Véhicule";
            // 
            // btnValiderV
            // 
            btnValiderV.Location = new Point(117, 252);
            btnValiderV.Name = "btnValiderV";
            btnValiderV.Size = new Size(94, 29);
            btnValiderV.TabIndex = 12;
            btnValiderV.Text = "Valider";
            btnValiderV.UseVisualStyleBackColor = true;
            btnValiderV.Click += btnValiderV_Click;
            // 
            // txtReservoir
            // 
            txtReservoir.Location = new Point(182, 205);
            txtReservoir.Name = "txtReservoir";
            txtReservoir.Size = new Size(125, 27);
            txtReservoir.TabIndex = 11;
            // 
            // lblReservoir
            // 
            lblReservoir.AutoSize = true;
            lblReservoir.Location = new Point(30, 205);
            lblReservoir.Name = "lblReservoir";
            lblReservoir.Size = new Size(78, 20);
            lblReservoir.TabIndex = 10;
            lblReservoir.Text = "Réservoire";
            // 
            // txtVitesseMax
            // 
            txtVitesseMax.Location = new Point(182, 163);
            txtVitesseMax.Name = "txtVitesseMax";
            txtVitesseMax.Size = new Size(125, 27);
            txtVitesseMax.TabIndex = 9;
            txtVitesseMax.TextChanged += textBox6_TextChanged;
            // 
            // txtCompteur
            // 
            txtCompteur.Location = new Point(182, 123);
            txtCompteur.Name = "txtCompteur";
            txtCompteur.Size = new Size(125, 27);
            txtCompteur.TabIndex = 8;
            // 
            // lblVitesseMax
            // 
            lblVitesseMax.AutoSize = true;
            lblVitesseMax.Location = new Point(30, 163);
            lblVitesseMax.Name = "lblVitesseMax";
            lblVitesseMax.Size = new Size(87, 20);
            lblVitesseMax.TabIndex = 7;
            lblVitesseMax.Text = "Vitesse Max";
            // 
            // lblCompteur
            // 
            lblCompteur.AutoSize = true;
            lblCompteur.Location = new Point(30, 123);
            lblCompteur.Name = "lblCompteur";
            lblCompteur.Size = new Size(75, 20);
            lblCompteur.TabIndex = 6;
            lblCompteur.Text = "Compteur";
            // 
            // txtVitesse
            // 
            txtVitesse.Location = new Point(182, 80);
            txtVitesse.Name = "txtVitesse";
            txtVitesse.Size = new Size(125, 27);
            txtVitesse.TabIndex = 3;
            // 
            // lblVitesse
            // 
            lblVitesse.AutoSize = true;
            lblVitesse.Location = new Point(30, 80);
            lblVitesse.Name = "lblVitesse";
            lblVitesse.Size = new Size(55, 20);
            lblVitesse.TabIndex = 2;
            lblVitesse.Text = "Vitesse";
            lblVitesse.Click += label4_Click;
            // 
            // txtlmmat
            // 
            txtlmmat.Location = new Point(182, 37);
            txtlmmat.Name = "txtlmmat";
            txtlmmat.Size = new Size(125, 27);
            txtlmmat.TabIndex = 1;
            // 
            // lbllmmat
            // 
            lbllmmat.AutoSize = true;
            lbllmmat.Location = new Point(30, 40);
            lbllmmat.Name = "lbllmmat";
            lbllmmat.Size = new Size(114, 20);
            lbllmmat.TabIndex = 0;
            lbllmmat.Text = "Immatriculation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnValiderR;
        private TextBox txtContenu;
        private Label label2;
        private TextBox txtCapacite;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtVitesse;
        private Label lblVitesse;
        private TextBox txtlmmat;
        private Label lbllmmat;
        private TextBox txtVitesseMax;
        private TextBox txtCompteur;
        private Label lblVitesseMax;
        private Label lblCompteur;
        private Button btnValiderV;
        private TextBox txtReservoir;
        private Label lblReservoir;
    }
}
