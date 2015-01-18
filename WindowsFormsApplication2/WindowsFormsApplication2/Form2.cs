using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class Form2 : Form
    {
        Form1 _form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermeture de la fenêtre
            _form1.form2_unlock(); // débloque la création de la form2
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // You can write to a file to store settings here.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // chargement e la fenetre

            string[] Juridique = { "N/A","SARL","EURL","SELARL","SA","SAS","SASU","SNC","SCP"};
            int a = 0;
            this.Client_Juridique.Items.AddRange(Juridique);
            this.Client_Juridique.SelectedIndex = a;

            //chargement de la fiche du client selectionné
            if (_form1.form2_loadclientstat()==1)
            {
                string[] LectureClients = System.IO.File.ReadAllLines(@"" + _form1.current_client() + ".txt");
                Load_Current_Client(LectureClients);
            }
           

        }


        public void Load_Current_Client(string[] LectureClients)
        {
            int taille;
            taille = Convert.ToInt32(LectureClients.Length.ToString());
            Client_nom.Text = _form1.current_client();
            Client_adresse.Text =  LectureClients[0];
            Client_tel.Text =  LectureClients[1];
            Client_fax.Text =  LectureClients[2];
            Client_email.Text =  LectureClients[3];
            Client_web.Text =  LectureClients[4];
            Client_Siret.Text = LectureClients[7];
            Client_NAF.Text =  LectureClients[8];
            Client_Etablissement.Text =  LectureClients[9];
            Client_Typo.Text =  LectureClients[10];
            Client_Juridique.Text = LectureClients[11];
            Description.Text = LectureClients[12].Replace("§", "\r\n");
            Lun1.Text = LectureClients[13];
            Lun2.Text = LectureClients[14];
            Lun3.Text = LectureClients[15];
            Lun4.Text = LectureClients[16];

            Mar1.Text = LectureClients[17];
            Mar2.Text = LectureClients[18];
            Mar3.Text = LectureClients[19];
            Mar4.Text = LectureClients[20];

            Mer1.Text = LectureClients[21];
            Mer2.Text = LectureClients[22];
            Mer3.Text = LectureClients[23];
            Mer4.Text = LectureClients[24];

            Jeu1.Text = LectureClients[25];
            Jeu2.Text = LectureClients[26];
            Jeu3.Text = LectureClients[27];
            Jeu4.Text = LectureClients[28];

            Ven1.Text = LectureClients[29];
            Ven2.Text = LectureClients[30];
            Ven3.Text = LectureClients[31];
            Ven4.Text = LectureClients[32];

            Sam1.Text = LectureClients[33];
            Sam2.Text = LectureClients[34];
            Sam3.Text = LectureClients[35];
            Sam4.Text = LectureClients[36];

            Dim1.Text = LectureClients[37];
            Dim2.Text = LectureClients[38];
            Dim3.Text = LectureClients[39];
            Dim4.Text = LectureClients[40]; 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_form1.form2_loadclientstat() != 1)
            {
                _form1.Clients_Add(this.Client_nom.Text);
                System.IO.File.WriteAllLines(@"ListeClients.txt", _form1.clients);
            }

            //_form1.Clients_Ins(_form1.Clients_IndexOf(this.Client_nom.Text), this.Client_adresse.Text);//plus tard d'autres argument
            
            string[] InformationsCourantes = { this.Client_adresse.Text, this.Client_tel.Text, this.Client_fax.Text, this.Client_email.Text, this.Client_web.Text, this.Client_fb.Text, this.Client_tweet.Text, this.Client_Siret.Text, this.Client_NAF.Text, this.Client_Etablissement.Text, this.Client_Typo.Text, this.Client_Juridique.SelectedItem.ToString(), this.Description.Text.Replace("\r\n", "§"),
                                                this.Lun1.Text,this.Lun2.Text,this.Lun3.Text,this.Lun4.Text, this.Mar1.Text,this.Mar2.Text,this.Mar3.Text,this.Mar4.Text, this.Mer1.Text,this.Mer2.Text,this.Mer3.Text,this.Mer4.Text, this.Jeu1.Text,this.Jeu2.Text,this.Jeu3.Text,this.Jeu4.Text, this.Ven1.Text,this.Ven2.Text,this.Ven3.Text,this.Ven4.Text, this.Sam1.Text,this.Sam2.Text,this.Sam3.Text,this.Sam4.Text, this.Dim1.Text,this.Dim2.Text,this.Dim3.Text,this.Dim4.Text};
            int taille;
            taille = Convert.ToInt32(InformationsCourantes.Length.ToString());
            for (int t = 0; t < taille; t++)
            {
                if (InformationsCourantes[t]=="")
                {
                    InformationsCourantes[t] = "N/A";
                }
            }
            
            System.IO.File.WriteAllLines(@"" + this.Client_nom.Text + ".txt", InformationsCourantes);

            if (_form1.form2_loadclientstat() == 1) { _form1.ListClientsBase_Update(); }

            this.Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }                                        // comme par exemple ls coordonnées





    }
}
