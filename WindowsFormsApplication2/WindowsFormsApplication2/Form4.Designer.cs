namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aproposEquipe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EquipeNom = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lbl2_chk2 = new System.Windows.Forms.Label();
            this.lbl2_chk1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl2_prenom = new System.Windows.Forms.Label();
            this.lbl2_age = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl2_nom = new System.Windows.Forms.Label();
            this.lbl2_web = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl2_tel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl2_adresse = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl2_email = new System.Windows.Forms.Label();
            this.lbl2_fax = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListTravailleurs = new System.Windows.Forms.ListBox();
            this.ListMembres = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aproposEquipe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EquipeNom);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.lbl2_chk2);
            this.groupBox1.Controls.Add(this.lbl2_chk1);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ListTravailleurs);
            this.groupBox1.Controls.Add(this.ListMembres);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(704, 607);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiche de gestion d\'equipe";
            // 
            // aproposEquipe
            // 
            this.aproposEquipe.AcceptsReturn = true;
            this.aproposEquipe.AcceptsTab = true;
            this.aproposEquipe.Location = new System.Drawing.Point(8, 382);
            this.aproposEquipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aproposEquipe.Multiline = true;
            this.aproposEquipe.Name = "aproposEquipe";
            this.aproposEquipe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aproposEquipe.Size = new System.Drawing.Size(303, 150);
            this.aproposEquipe.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Description : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nom de l\'équipe : ";
            // 
            // EquipeNom
            // 
            this.EquipeNom.Location = new System.Drawing.Point(8, 335);
            this.EquipeNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EquipeNom.Name = "EquipeNom";
            this.EquipeNom.Size = new System.Drawing.Size(303, 22);
            this.EquipeNom.TabIndex = 32;
            // 
            // button6
            // 
            this.button6.AccessibleName = "";
            this.button6.Location = new System.Drawing.Point(439, 505);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 28);
            this.button6.TabIndex = 31;
            this.button6.Text = "Visualiser le CV";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbl2_chk2
            // 
            this.lbl2_chk2.AutoSize = true;
            this.lbl2_chk2.ForeColor = System.Drawing.Color.Red;
            this.lbl2_chk2.Location = new System.Drawing.Point(388, 555);
            this.lbl2_chk2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_chk2.Name = "lbl2_chk2";
            this.lbl2_chk2.Size = new System.Drawing.Size(0, 17);
            this.lbl2_chk2.TabIndex = 30;
            // 
            // lbl2_chk1
            // 
            this.lbl2_chk1.AutoSize = true;
            this.lbl2_chk1.ForeColor = System.Drawing.Color.Red;
            this.lbl2_chk1.Location = new System.Drawing.Point(388, 539);
            this.lbl2_chk1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_chk1.Name = "lbl2_chk1";
            this.lbl2_chk1.Size = new System.Drawing.Size(0, 17);
            this.lbl2_chk1.TabIndex = 29;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.lbl2_prenom);
            this.groupBox8.Controls.Add(this.lbl2_age);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.lbl2_nom);
            this.groupBox8.Controls.Add(this.lbl2_web);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.lbl2_tel);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.lbl2_adresse);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.lbl2_email);
            this.groupBox8.Controls.Add(this.lbl2_fax);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Location = new System.Drawing.Point(439, 308);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(257, 191);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Coordonnées";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Prenom :";
            // 
            // lbl2_prenom
            // 
            this.lbl2_prenom.AutoSize = true;
            this.lbl2_prenom.Location = new System.Drawing.Point(81, 36);
            this.lbl2_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_prenom.Name = "lbl2_prenom";
            this.lbl2_prenom.Size = new System.Drawing.Size(0, 17);
            this.lbl2_prenom.TabIndex = 26;
            // 
            // lbl2_age
            // 
            this.lbl2_age.AutoSize = true;
            this.lbl2_age.Location = new System.Drawing.Point(59, 52);
            this.lbl2_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_age.Name = "lbl2_age";
            this.lbl2_age.Size = new System.Drawing.Size(0, 17);
            this.lbl2_age.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 50);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "Age :";
            // 
            // lbl2_nom
            // 
            this.lbl2_nom.AutoSize = true;
            this.lbl2_nom.Location = new System.Drawing.Point(63, 20);
            this.lbl2_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_nom.Name = "lbl2_nom";
            this.lbl2_nom.Size = new System.Drawing.Size(0, 17);
            this.lbl2_nom.TabIndex = 25;
            // 
            // lbl2_web
            // 
            this.lbl2_web.AutoSize = true;
            this.lbl2_web.Location = new System.Drawing.Point(77, 164);
            this.lbl2_web.Name = "lbl2_web";
            this.lbl2_web.Size = new System.Drawing.Size(12, 17);
            this.lbl2_web.TabIndex = 12;
            this.lbl2_web.TabStop = true;
            this.lbl2_web.Text = " ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 18);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "Nom :";
            // 
            // lbl2_tel
            // 
            this.lbl2_tel.AutoSize = true;
            this.lbl2_tel.Location = new System.Drawing.Point(97, 113);
            this.lbl2_tel.Name = "lbl2_tel";
            this.lbl2_tel.Size = new System.Drawing.Size(0, 17);
            this.lbl2_tel.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Site web :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 17);
            this.label21.TabIndex = 28;
            this.label21.Text = "Téléphone :";
            // 
            // lbl2_adresse
            // 
            this.lbl2_adresse.AutoSize = true;
            this.lbl2_adresse.Location = new System.Drawing.Point(80, 74);
            this.lbl2_adresse.Name = "lbl2_adresse";
            this.lbl2_adresse.Size = new System.Drawing.Size(0, 17);
            this.lbl2_adresse.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 17);
            this.label22.TabIndex = 27;
            this.label22.Text = "Adresse :";
            // 
            // lbl2_email
            // 
            this.lbl2_email.AutoSize = true;
            this.lbl2_email.Location = new System.Drawing.Point(67, 145);
            this.lbl2_email.Name = "lbl2_email";
            this.lbl2_email.Size = new System.Drawing.Size(0, 17);
            this.lbl2_email.TabIndex = 10;
            // 
            // lbl2_fax
            // 
            this.lbl2_fax.AutoSize = true;
            this.lbl2_fax.Location = new System.Drawing.Point(56, 129);
            this.lbl2_fax.Name = "lbl2_fax";
            this.lbl2_fax.Size = new System.Drawing.Size(0, 17);
            this.lbl2_fax.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 17);
            this.label23.TabIndex = 30;
            this.label23.Text = "E-mail :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 17);
            this.label24.TabIndex = 29;
            this.label24.Text = "Fax : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Travailleurs disponible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Membres en place";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 185);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = ">>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListTravailleurs
            // 
            this.ListTravailleurs.FormattingEnabled = true;
            this.ListTravailleurs.ItemHeight = 16;
            this.ListTravailleurs.Location = new System.Drawing.Point(392, 71);
            this.ListTravailleurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListTravailleurs.Name = "ListTravailleurs";
            this.ListTravailleurs.Size = new System.Drawing.Size(303, 228);
            this.ListTravailleurs.TabIndex = 1;
            this.ListTravailleurs.SelectedIndexChanged += new System.EventHandler(this.ListTravailleurs_SelectedIndexChanged);
            // 
            // ListMembres
            // 
            this.ListMembres.FormattingEnabled = true;
            this.ListMembres.ItemHeight = 16;
            this.ListMembres.Location = new System.Drawing.Point(8, 71);
            this.ListMembres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListMembres.Name = "ListMembres";
            this.ListMembres.Size = new System.Drawing.Size(303, 228);
            this.ListMembres.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "VALIDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Fiche Equipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListTravailleurs;
        private System.Windows.Forms.ListBox ListMembres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbl2_chk2;
        private System.Windows.Forms.Label lbl2_chk1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl2_prenom;
        private System.Windows.Forms.Label lbl2_age;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl2_nom;
        private System.Windows.Forms.LinkLabel lbl2_web;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl2_tel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl2_adresse;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl2_email;
        private System.Windows.Forms.Label lbl2_fax;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EquipeNom;
        private System.Windows.Forms.TextBox aproposEquipe;
    }
}