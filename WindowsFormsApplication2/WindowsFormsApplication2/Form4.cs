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
    public partial class Form4 : Form
    {
        Form1 _form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }


        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermeture de la fenêtre
            _form1.form4_unlock(); // débloque la création de la form4
            _form1.set_CV_Manual(0);
            _form1.set_CV_Manual_current("");
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            // You can write to a file to store settings here.
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"ListeTravailleurs.txt");
            Load_TravailleursNames(LectureTravailleurs);

        }


        public int getAge(DateTime DateDeNaissance)
        {
            int age = DateTime.Now.Year - DateDeNaissance.Year;
            if (age > 0)
            {
                DateTime dateAnn = new DateTime(DateTime.Now.Year, DateDeNaissance.Month, DateDeNaissance.Day);
                if (dateAnn > DateTime.Now)
                    age--;
            }
            return age;
        }


        public void Load_TravailleursNames(string[] LectureTravailleurs)
        {
            int taille;
            taille = Convert.ToInt32(LectureTravailleurs.Length.ToString());
            for (int t = 0; t < taille; t++)
            {
                this.travailleurs_Add(LectureTravailleurs[t]);
            }
        }

        public List<string> travailleurs = new List<string>();
        // fonctions de mon LDB
        public void travailleurs_Add(string travailleursup)
        {
            this.travailleurs.Add(travailleursup);
            this.ListTravailleurs.Items.Add(travailleursup);

            //rajouter numéros de telephones ,adresse, ect...
        }


        public void travailleurs_Del(string travailleursup)
        { // cela, pas la peine de les faires pour le moment(del et ins),
            // On copira les ligne de Add en utilisant la touche 'Ctrl' combinée a la touche 'c'
            // ensuite il n'y aura plus qu'a utiliser 'recherche/remplacer'...
            // c'est merveilleux! :o)
            this.travailleurs.Remove(travailleursup);
            this.ListTravailleurs.Items.Remove(travailleursup);

        }

        public void travailleurs_Ins(int supindex, string travailleursup)
        {
            this.travailleurs.Insert(supindex, travailleursup);
            this.ListTravailleurs.Items.Insert(supindex, travailleursup);

        }

        public int travailleurs_IndexOf(string travailleursup)
        {
            return this.travailleurs.IndexOf(travailleursup);
        }
        // fonctions de mon LDB pour la gestion


        public void travailleur_FILE_UPDATE(string travailleurname)
        {
            System.IO.File.Delete("Listetravailleurs.txt");
            this.travailleurs.Remove(travailleurname);
            System.IO.File.WriteAllLines(@"Listetravailleurs.txt", this.travailleurs);
            this.ListTravailleurs.Items.Remove(travailleurname);

        }

        private void ListTravailleurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListTravailleurs.SelectedIndex != -1)
            {
                string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"" + ListTravailleurs.SelectedItem.ToString() + ".txt");
                Load_Current_Travailleur(LectureTravailleurs);
            }
            else if (ListTravailleurs.SelectedIndex == -1) { Init_Current_Travailleur(); }
        }

        public string current_travailleur()
        {
            return ListTravailleurs.SelectedItem.ToString();
        }

        public void Load_Current_Travailleur(string[] LectureTravailleurs)
        {
            char[] delimiterChars = { '_', ',', ';' };
            int taille;
            taille = Convert.ToInt32(LectureTravailleurs.Length.ToString());
            string NomPrenom = this.current_travailleur();
            string[] NomPrenomLst = NomPrenom.Split(delimiterChars);

            this.lbl2_nom.Text = NomPrenomLst[0];
            this.lbl2_prenom.Text = NomPrenomLst[1];
            this.lbl2_adresse.Text = LectureTravailleurs[0];
            DateTime DateDeNaissance = Convert.ToDateTime(LectureTravailleurs[1]);
            this.lbl2_age.Text = Convert.ToString(getAge(DateDeNaissance));
            this.lbl2_tel.Text = LectureTravailleurs[2];
            this.lbl2_fax.Text = LectureTravailleurs[3];
            this.lbl2_email.Text = LectureTravailleurs[4];
            this.lbl2_web.Text = LectureTravailleurs[5];
            //this.lbl2_fb.Text = LectureTravailleurs[6];
            //this.lbl2_tweet.Text = LectureTravailleurs[7];
            //this.lbl2_formations.Text = LectureTravailleurs[8].Replace("§", "\r\n");
            //this.lbl2_experiences.Text = LectureTravailleurs[9].Replace("§", "\r\n");
            //this.lbl2_interets.Text = LectureTravailleurs[10].Replace("§", "\r\n");
            if (Convert.ToBoolean(LectureTravailleurs[11]))
            {
                this.lbl2_chk1.ForeColor = System.Drawing.Color.Green;
                this.lbl2_chk1.Text = "Ce travailleur possède un permis voiture.";
            }
            else if (Convert.ToBoolean(LectureTravailleurs[11]) == false)
            {
                this.lbl2_chk1.ForeColor = System.Drawing.Color.Red;
                this.lbl2_chk1.Text = "Ce travailleur ne possède pas de permis voiture.";
            }



            if (Convert.ToBoolean(LectureTravailleurs[12]))
            {
                this.lbl2_chk2.ForeColor = System.Drawing.Color.Green;
                this.lbl2_chk2.Text = "Ce travailleur possède une voiture.";
            }
            else if (Convert.ToBoolean(LectureTravailleurs[12]) == false)
            {
                this.lbl2_chk2.ForeColor = System.Drawing.Color.Red;
                this.lbl2_chk2.Text = "Ce travailleur ne possède pas de voiture.";
            }


        }

        public void Init_Current_Travailleur()
        {
            this.lbl2_nom.Text = "";
            this.lbl2_prenom.Text = "";
            this.lbl2_adresse.Text = "";
            this.lbl2_age.Text = "";
            this.lbl2_tel.Text = "";
            this.lbl2_fax.Text = "";
            this.lbl2_email.Text = "";
            this.lbl2_web.Text = "";
            this.lbl2_chk1.ForeColor = System.Drawing.Color.Red;
            this.lbl2_chk2.ForeColor = System.Drawing.Color.Red;
            this.lbl2_chk1.Text = "";
            this.lbl2_chk2.Text = "";
            //this.lbl2_fb.Text = "";
            //this.lbl2_tweet.Text = "";
            //this.lbl2_formations.Text = "";
            //this.lbl2_experiences.Text = "";
            //this.lbl2_interets.Text = "";
            //this.lbl2_check1.Checked = "";
            //this.lbl2_check2.Checked = "";
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (ListTravailleurs.SelectedIndex != -1)
            {
                _form1.set_CV_Manual(1);
                _form1.set_CV_Manual_current(this.current_travailleur());
                _form1.ShowCV_Manual();
            }
        }

        public List<string> membres = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ListTravailleurs.SelectedIndex != -1)
            {
                this.ListMembres.Items.Add(this.ListTravailleurs.SelectedItem.ToString());
                membres.Add(this.ListTravailleurs.SelectedItem.ToString());
                this.ListTravailleurs.Items.RemoveAt(this.ListTravailleurs.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ListMembres.SelectedIndex!=-1)
            { 
                this.ListTravailleurs.Items.Add(this.ListMembres.SelectedItem.ToString());
                membres.RemoveAt(this.ListMembres.SelectedIndex);
                this.ListMembres.Items.RemoveAt(this.ListMembres.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (_form1.form2_loadclientstat() != 1)
            //{
                //_form1.Clients_Add(this.EquipeNom.Text);
                //System.IO.File.WriteAllLines(@"ListeEquipes.txt", _form1.clients);
            //}

            //_form1.Clients_Ins(_form1.Clients_IndexOf(this.Client_nom.Text), this.Client_adresse.Text);//plus tard d'autres argument
            char[] delimiterChars = { '_', ',', ';' };
            //int MembresLen = membres.Count;  // Split(delimiterChars);

            System.IO.File.WriteAllLines(@"ListeEquipes.txt", membres);


            //string a;
            //for (int t=0; t<MembresLen; t++)
            //{
            //   a= this.ListMembres.Sor;
            //}



            string[] InformationsCourantes = { this.EquipeNom.Text, this.aproposEquipe.Text.Replace("\r\n", "§") };
            int taille;
            taille = Convert.ToInt32(InformationsCourantes.Length.ToString());
            for (int t = 0; t < taille; t++)
            {
                if (InformationsCourantes[t] == "")
                {
                    InformationsCourantes[t] = "N/A";
                }
            }

            System.IO.File.WriteAllLines(@"" + this.EquipeNom.Text + ".txt", InformationsCourantes);

            //if (_form1.form4_loadequipestat() == 1) { _form1.ListEquipeBase_Update(); }

            this.Close();
        }


    }
}
