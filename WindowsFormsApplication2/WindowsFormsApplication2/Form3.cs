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
    public partial class Form3 : Form
    {
        Form1 _form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermeture de la fenêtre
            _form1.form3_unlock(); // débloque la création de la form2
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // You can write to a file to store settings here.
        }

        public void Load_Current_Travailleur(string[] LectureTravailleurs)
        {
            char[] delimiterChars = { '_', ',', ';' };
            int taille;
            taille = Convert.ToInt32(LectureTravailleurs.Length.ToString());
            string NomPrenom = _form1.current_travailleur();
            string[] NomPrenomLst =  NomPrenom.Split(delimiterChars);
            
            Travailleur_nom.Text = NomPrenomLst[0];
            Travailleur_prenom.Text=NomPrenomLst[1];
            Travailleur_adresse.Text = LectureTravailleurs[0];
            Travailleur_dateN.Value = Convert.ToDateTime(LectureTravailleurs[1]);
            Travailleur_tel.Text = LectureTravailleurs[2];
            Travailleur_fax.Text = LectureTravailleurs[3];
            Travailleur_email.Text = LectureTravailleurs[4];
            Travailleur_web.Text = LectureTravailleurs[5];
            Travailleur_fb.Text = LectureTravailleurs[6];
            Travailleur_tweet.Text = LectureTravailleurs[7];
            Travailleur_formations.Text = LectureTravailleurs[8].Replace("§","\r\n");
            Travailleur_experiences.Text = LectureTravailleurs[9].Replace("§","\r\n");
            Travailleur_interets.Text = LectureTravailleurs[10].Replace("§","\r\n");
            Travailleur_check1.Checked = Convert.ToBoolean(LectureTravailleurs[11]);
            Travailleur_check2.Checked = Convert.ToBoolean(LectureTravailleurs[12]);

            //Description.Text = LectureTravailleurs[12].Replace("§", "\r\n");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //chargement de la fiche du client selectionné
            if (_form1.form3_loadtravailleurstat() == 1)
            {
                string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"" + _form1.current_travailleur() + ".txt");
                Load_Current_Travailleur(LectureTravailleurs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_form1.form3_loadtravailleurstat() != 1)
            {
                _form1.travailleurs_Add(this.Travailleur_nom.Text + "_" + this.Travailleur_prenom.Text);
                System.IO.File.WriteAllLines(@"ListeTravailleurs.txt", _form1.travailleurs);
            }

            //_form1.Clients_Ins(_form1.Clients_IndexOf(this.Client_nom.Text), this.Client_adresse.Text);//plus tard d'autres argument


            string[] InformationsCourantes = { this.Travailleur_adresse.Text,Convert.ToString(this.Travailleur_dateN.Value) , this.Travailleur_tel.Text, this.Travailleur_fax.Text, this.Travailleur_email.Text, this.Travailleur_web.Text, this.Travailleur_fb.Text, this.Travailleur_tweet.Text, this.Travailleur_formations.Text.Replace("\r\n", "§"), this.Travailleur_experiences.Text.Replace("\r\n", "§"), this.Travailleur_interets.Text.Replace("\r\n", "§"), Convert.ToString(this.Travailleur_check1.Checked), Convert.ToString(this.Travailleur_check2.Checked) };

            int taille;
            taille = Convert.ToInt32(InformationsCourantes.Length.ToString());
            for (int t = 0; t < taille; t++)
            {
                if (InformationsCourantes[t] == "")
                {
                    InformationsCourantes[t] = "N/A";
                }
            }

            System.IO.File.WriteAllLines(@"" + this.Travailleur_nom.Text + "_" + this.Travailleur_prenom.Text + ".txt", InformationsCourantes);

            if (_form1.form3_loadtravailleurstat() == 1) { _form1.ListTravailleursBase_Update(); }
            
            this.Close();
        }  
    }
}
