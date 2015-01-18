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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Form2 f2;
        int f2lock = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (f2lock == 0)// vérifie le nombre de feuilles form2, doit etre egal a zero
            {
                f2 = new Form2(this); // créé une nouvelle feuille form2
                f2.Show(); // affiche la nouvelle feuille
                f2lock++; // inc. le nombre de feuille dans cet entier
            }
        }

        public void form2_unlock() // Permet de réinitialiser le compteur
        {
            f2lock = 0;
            f2loadclient = 0;
        }



        int f2loadclient = 0;
        public int form2_loadclientstat()
        {
            return f2loadclient;
        }




        public List<string> clients = new List<string>();
        // fonctions de mon LDB
        public void Clients_Add(string clientsup)
        {
            this.clients.Add(clientsup);
            this.ListClients.Items.Add(clientsup);
            this.comboclients.Items.Add(clientsup);
            //rajouter numéros de telephones ,adresse, ect...
        }


        public void Clients_Del(string clientsup)
        { // cela, pas la peine de les faires pour le moment(del et ins),
            // On copira les ligne de Add en utilisant la touche 'Ctrl' combinée a la touche 'c'
            // ensuite il n'y aura plus qu'a utiliser 'recherche/remplacer'...
            // c'est merveilleux! :o)
            this.clients.Remove(clientsup);
            this.ListClients.Items.Remove(clientsup);
            this.comboclients.Items.Remove(clientsup);
        }

        public void Clients_Ins(int supindex, string clientsup)
        {
            this.clients.Insert(supindex, clientsup);
            this.ListClients.Items.Insert(supindex, clientsup);
            this.comboclients.Items.Insert(supindex, clientsup);
        }

        public int Clients_IndexOf(string clientsup)
        {
            return this.clients.IndexOf(clientsup);
        }
        // fonctions de mon LDB pour la gestion


        public void Client_FILE_UPDATE(string clientname)
        {
            System.IO.File.Delete("ListeClients.txt");
            this.clients.Remove(clientname);
            System.IO.File.WriteAllLines(@"ListeClients.txt",this.clients);
            this.ListClients.Items.Remove(clientname);
            this.comboclients.Items.Remove(clientname);
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


        public List<string> equipes = new List<string>();
        // fonctions de mon LDB
        public void equipes_Add(string equipesup)
        {
            this.equipes.Add(equipesup);
            this.ListEquipes.Items.Add(equipesup);

            //rajouter numéros de telephones ,adresse, ect...
        }


        public void equipes_Del(string equipesup)
        { // cela, pas la peine de les faires pour le moment(del et ins),
            // On copira les ligne de Add en utilisant la touche 'Ctrl' combinée a la touche 'c'
            // ensuite il n'y aura plus qu'a utiliser 'recherche/remplacer'...
            // c'est merveilleux! :o)
            this.equipes.Remove(equipesup);
            this.ListEquipes.Items.Remove(equipesup);

        }

        public void equipes_Ins(int supindex, string equipesup)
        {
            this.equipes.Insert(supindex, equipesup);
            this.ListEquipes.Items.Insert(supindex, equipesup);

        }

        public int equipes_IndexOf(string equipesup)
        {
            return this.equipes.IndexOf(equipesup);
        }
        // fonctions de mon LDB pour la gestion


        public void equipe_FILE_UPDATE(string equipename)
        {
            System.IO.File.Delete("Listeequipes.txt");
            this.equipes.Remove(equipename);
            System.IO.File.WriteAllLines(@"Listeequipes.txt", this.equipes);
            this.ListEquipes.Items.Remove(equipename);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermeture de la fenêtre
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // You can write to a file to store settings here.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // chargement de la fenetre
            string[] LectureClients = System.IO.File.ReadAllLines(@"ListeClients.txt");
            Load_ClientsNames(LectureClients);

            string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"ListeTravailleurs.txt");
            Load_TravailleursNames(LectureTravailleurs);

            string[] LectureEquipes = System.IO.File.ReadAllLines(@"ListeEquipes.txt");
            Load_EquipesNames(LectureEquipes);
        }

        public void Load_ClientsNames(string[] LectureClients)
        {
            int taille;
            taille = Convert.ToInt32(LectureClients.Length.ToString());
            for (int t=0; t<taille; t++)
            {
                this.Clients_Add(LectureClients[t]);
            }
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

        public void Load_EquipesNames(string[] LectureEquipes)
        {
            int taille;
            taille = Convert.ToInt32(LectureEquipes.Length.ToString());
            for (int t = 0; t < taille; t++)
            {
                this.equipes_Add(LectureEquipes[t]);
            }
        }

        public string current_client()
        {
            return ListClients.SelectedItem.ToString();
        }

        public void Load_Current_Client(string[] LectureClients)
        {
            int taille;
            taille = Convert.ToInt32(LectureClients.Length.ToString());
            lbl_adresse.Text = "Adresse :  "+LectureClients[0];
            lbl_tel.Text = "Téléphone :  " + LectureClients[1];
            lbl_fax.Text = "Fax :  "+LectureClients[2];
            lbl_email.Text = "E-mail :  "+LectureClients[3];
            lbl_web.Text = ""+LectureClients[4];
            lbl_Siret.Text = "SIRET :  " + LectureClients[7];
            lbl_NAF.Text = "Code NAF :  " + LectureClients[8];
            lbl_Effectif.Text = "Effectif de l'établissement :  " + LectureClients[9];
            lbl_Typo.Text = "Typologie de l'établissement :  " + LectureClients[10];
            lbl_Juridique.Text = "Statut juridique :  " + LectureClients[11];
            txt_d.Text = LectureClients[12].Replace("§","\r\n");



            Lun.Text ="";
            Mar.Text = "";
            Mer.Text = "";
            Jeu.Text = "";
            Ven.Text = "";
            Sam.Text = "";
            Dim.Text = "";

            if ((LectureClients[13].Contains("N/A")) && (LectureClients[14].Contains("N/A")) && (LectureClients[15].Contains("N/A")) && (LectureClients[16].Contains("N/A"))) { Lun.Text = " FERMER"; }
            if ((LectureClients[13].Contains("N/A")==false) && (LectureClients[14].Contains("N/A")==false))
            {
                if (LectureClients[13].Contains("h"))
                {
                    Lun.Text = LectureClients[13] + "-";
                }
                else if (LectureClients[13].Contains("h")==false)
                {
                    Lun.Text = LectureClients[13] + "h-";
                }
                if (LectureClients[14].Contains("h"))
                {
                    Lun.Text = Lun.Text+ LectureClients[14] + "";
                }
                else if (LectureClients[14].Contains("h")== false)
                {
                    Lun.Text = Lun.Text+ LectureClients[14] + "h";
                }
                if ((LectureClients[13].Contains("N/A") == false) && (LectureClients[14].Contains("N/A") == false) && (LectureClients[15].Contains("N/A") == false) && (LectureClients[16].Contains("N/A") == false)) { Lun.Text = Lun.Text + " et "; }
            }
            if ((LectureClients[15].Contains("N/A")==false) && (LectureClients[16].Contains("N/A")==false))
            {
                if (LectureClients[15].Contains("h"))
                {
                    Lun.Text = Lun.Text+ LectureClients[15] + "-";
                }
                else if (LectureClients[15].Contains("h") == false)
                {
                    Lun.Text =Lun.Text+ LectureClients[15] + "h-";
                }
                if (LectureClients[16].Contains("h"))
                {
                    Lun.Text = Lun.Text+ LectureClients[16] + "";
                }
                else if (LectureClients[16].Contains("h") == false)
                {
                    Lun.Text = Lun.Text+ LectureClients[16] + "h";
                }
            }


            if ((LectureClients[17].Contains("N/A")) && (LectureClients[18].Contains("N/A")) && (LectureClients[19].Contains("N/A")) && (LectureClients[20].Contains("N/A"))) { Mar.Text = " FERMER"; }
            if ((LectureClients[17].Contains("N/A") == false) && (LectureClients[18].Contains("N/A") == false))
            {
                if (LectureClients[17].Contains("h"))
                {
                    Mar.Text = LectureClients[17] + "-";
                }
                else if (LectureClients[17].Contains("h") == false)
                {
                    Mar.Text = LectureClients[17] + "h-";
                }
                if (LectureClients[18].Contains("h"))
                {
                    Mar.Text = Mar.Text + LectureClients[18] + "";
                }
                else if (LectureClients[18].Contains("h") == false)
                {
                    Mar.Text = Mar.Text + LectureClients[18] + "h";
                }
                if ((LectureClients[17].Contains("N/A") == false) && (LectureClients[18].Contains("N/A") == false) && (LectureClients[19].Contains("N/A") == false) && (LectureClients[20].Contains("N/A") == false)) { Mar.Text = Mar.Text + " et "; }
            }
            if ((LectureClients[19].Contains("N/A") == false) && (LectureClients[20].Contains("N/A") == false))
            {
                if (LectureClients[19].Contains("h"))
                {
                    Mar.Text = Mar.Text + LectureClients[19] + "-";
                }
                else if (LectureClients[19].Contains("h") == false)
                {
                    Mar.Text = Mar.Text + LectureClients[19] + "h-";
                }
                if (LectureClients[20].Contains("h"))
                {
                    Mar.Text = Mar.Text + LectureClients[20] + "";
                }
                else if (LectureClients[20].Contains("h") == false)
                {
                    Mar.Text = Mar.Text + LectureClients[20] + "h";
                }
            }


            if ((LectureClients[21].Contains("N/A")) && (LectureClients[22].Contains("N/A")) && (LectureClients[23].Contains("N/A")) && (LectureClients[24].Contains("N/A"))) { Mer.Text = " FERMER"; }
            if ((LectureClients[21].Contains("N/A") == false) && (LectureClients[22].Contains("N/A") == false))
            {
                if (LectureClients[21].Contains("h"))
                {
                    Mer.Text = LectureClients[21] + "-";
                }
                else if (LectureClients[21].Contains("h") == false)
                {
                    Mer.Text = LectureClients[21] + "h-";
                }
                if (LectureClients[22].Contains("h"))
                {
                    Mer.Text = Mer.Text + LectureClients[22] + "";
                }
                else if (LectureClients[22].Contains("h") == false)
                {
                    Mer.Text = Mer.Text + LectureClients[22] + "h";
                }
                if ((LectureClients[21].Contains("N/A") == false) && (LectureClients[22].Contains("N/A") == false) && (LectureClients[23].Contains("N/A") == false) && (LectureClients[24].Contains("N/A") == false)) { Mer.Text = Mer.Text + " et "; }
            }
            if ((LectureClients[23].Contains("N/A") == false) && (LectureClients[24].Contains("N/A") == false))
            {
                if (LectureClients[23].Contains("h"))
                {
                    Mer.Text = Mer.Text + LectureClients[23] + "-";
                }
                else if (LectureClients[23].Contains("h") == false)
                {
                    Mer.Text = Mer.Text + LectureClients[23] + "h-";
                }
                if (LectureClients[24].Contains("h"))
                {
                    Mer.Text = Mer.Text + LectureClients[24] + "";
                }
                else if (LectureClients[24].Contains("h") == false)
                {
                    Mer.Text = Mer.Text + LectureClients[24] + "h";
                }
            }


            if ((LectureClients[25].Contains("N/A")) && (LectureClients[26].Contains("N/A")) && (LectureClients[27].Contains("N/A")) && (LectureClients[28].Contains("N/A"))) { Jeu.Text = " FERMER"; }
            if ((LectureClients[25].Contains("N/A") == false) && (LectureClients[26].Contains("N/A") == false))
            {
                if (LectureClients[25].Contains("h"))
                {
                    Jeu.Text = LectureClients[25] + "-";
                }
                else if (LectureClients[25].Contains("h") == false)
                {
                    Jeu.Text = LectureClients[25] + "h-";
                }
                if (LectureClients[26].Contains("h"))
                {
                    Jeu.Text = Jeu.Text + LectureClients[26] + "";
                }
                else if (LectureClients[26].Contains("h") == false)
                {
                    Jeu.Text = Jeu.Text + LectureClients[26] + "h";
                }
                if ((LectureClients[25].Contains("N/A") == false) && (LectureClients[26].Contains("N/A") == false) && (LectureClients[27].Contains("N/A") == false) && (LectureClients[28].Contains("N/A") == false)) { Jeu.Text = Jeu.Text + " et "; }
            }
            if ((LectureClients[27].Contains("N/A") == false) && (LectureClients[28].Contains("N/A") == false))
            {
                if (LectureClients[27].Contains("h"))
                {
                    Jeu.Text = Jeu.Text + LectureClients[27] + "-";
                }
                else if (LectureClients[27].Contains("h") == false)
                {
                    Jeu.Text = Jeu.Text + LectureClients[27] + "h-";
                }
                if (LectureClients[28].Contains("h"))
                {
                    Jeu.Text = Jeu.Text + LectureClients[28] + "";
                }
                else if (LectureClients[28].Contains("h") == false)
                {
                    Jeu.Text = Jeu.Text + LectureClients[28] + "h";
                }
            }


            if ((LectureClients[29].Contains("N/A")) && (LectureClients[30].Contains("N/A")) && (LectureClients[31].Contains("N/A")) && (LectureClients[32].Contains("N/A"))) { Ven.Text = " FERMER"; }
            if ((LectureClients[29].Contains("N/A") == false) && (LectureClients[30].Contains("N/A") == false))
            {
                if (LectureClients[29].Contains("h"))
                {
                    Ven.Text = LectureClients[29] + "-";
                }
                else if (LectureClients[29].Contains("h") == false)
                {
                    Ven.Text = LectureClients[29] + "h-";
                }
                if (LectureClients[30].Contains("h"))
                {
                    Ven.Text = Ven.Text + LectureClients[30] + "";
                }
                else if (LectureClients[30].Contains("h") == false)
                {
                    Ven.Text = Ven.Text + LectureClients[30] + "h";
                }
                if ((LectureClients[29].Contains("N/A") == false) && (LectureClients[30].Contains("N/A") == false) && (LectureClients[31].Contains("N/A") == false) && (LectureClients[32].Contains("N/A") == false)) { Ven.Text = Ven.Text + " et "; }
            }
            if ((LectureClients[31].Contains("N/A") == false) && (LectureClients[32].Contains("N/A") == false))
            {
                if (LectureClients[31].Contains("h"))
                {
                    Ven.Text = Ven.Text + LectureClients[31] + "-";
                }
                else if (LectureClients[31].Contains("h") == false)
                {
                    Ven.Text = Ven.Text + LectureClients[31] + "h-";
                }
                if (LectureClients[32].Contains("h"))
                {
                    Ven.Text = Ven.Text + LectureClients[32] + "";
                }
                else if (LectureClients[32].Contains("h") == false)
                {
                    Ven.Text = Ven.Text + LectureClients[32] + "h";
                }
            }


            if ((LectureClients[33].Contains("N/A")) && (LectureClients[34].Contains("N/A")) && (LectureClients[35].Contains("N/A")) && (LectureClients[36].Contains("N/A"))) { Sam.Text = " FERMER"; }
            if ((LectureClients[33].Contains("N/A") == false) && (LectureClients[34].Contains("N/A") == false))
            {
                if (LectureClients[33].Contains("h"))
                {
                    Sam.Text = LectureClients[33] + "-";
                }
                else if (LectureClients[33].Contains("h") == false)
                {
                    Sam.Text = LectureClients[33] + "h-";
                }
                if (LectureClients[34].Contains("h"))
                {
                    Sam.Text = Sam.Text + LectureClients[34] + "";
                }
                else if (LectureClients[34].Contains("h") == false)
                {
                    Sam.Text = Sam.Text + LectureClients[34] + "h";
                }
                if ((LectureClients[33].Contains("N/A") == false) && (LectureClients[34].Contains("N/A") == false) && (LectureClients[35].Contains("N/A") == false) && (LectureClients[36].Contains("N/A") == false)) { Sam.Text = Sam.Text + " et "; }
            }
            if ((LectureClients[35].Contains("N/A") == false) && (LectureClients[36].Contains("N/A") == false))
            {
                if (LectureClients[35].Contains("h"))
                {
                    Sam.Text = Sam.Text + LectureClients[35] + "-";
                }
                else if (LectureClients[35].Contains("h") == false)
                {
                    Sam.Text = Sam.Text + LectureClients[35] + "h-";
                }
                if (LectureClients[36].Contains("h"))
                {
                    Sam.Text = Sam.Text + LectureClients[36] + "";
                }
                else if (LectureClients[36].Contains("h") == false)
                {
                    Sam.Text = Sam.Text + LectureClients[36] + "h";
                }
            }


            if ((LectureClients[37].Contains("N/A")) && (LectureClients[38].Contains("N/A")) && (LectureClients[39].Contains("N/A")) && (LectureClients[40].Contains("N/A"))) { Dim.Text = " FERMER"; }
            if ((LectureClients[37].Contains("N/A") == false) && (LectureClients[38].Contains("N/A") == false))
            {
                if (LectureClients[37].Contains("h"))
                {
                    Dim.Text = LectureClients[37] + "-";
                }
                else if (LectureClients[37].Contains("h") == false)
                {
                    Dim.Text = LectureClients[37] + "h-";
                }
                if (LectureClients[38].Contains("h"))
                {
                    Dim.Text = Dim.Text + LectureClients[38] + "";
                }
                else if (LectureClients[38].Contains("h") == false)
                {
                    Dim.Text = Dim.Text + LectureClients[38] + "h";
                }
                if ((LectureClients[37].Contains("N/A") == false) && (LectureClients[38].Contains("N/A") == false) && (LectureClients[39].Contains("N/A") == false) && (LectureClients[40].Contains("N/A") == false)) { Dim.Text = Dim.Text + " et "; }
            }
            if ((LectureClients[39].Contains("N/A") == false) && (LectureClients[40].Contains("N/A") == false))
            {
                if (LectureClients[39].Contains("h"))
                {
                    Dim.Text = Dim.Text + LectureClients[39] + "-";
                }
                else if (LectureClients[39].Contains("h") == false)
                {
                    Dim.Text = Dim.Text + LectureClients[39] + "h-";
                }
                if (LectureClients[40].Contains("h"))
                {
                    Dim.Text = Dim.Text + LectureClients[40] + "";
                }
                else if (LectureClients[40].Contains("h") == false)
                {
                    Dim.Text = Dim.Text + LectureClients[40] + "h";
                }
            }
            //Lun.Text = LectureClients[13].Replace("N/A", "#") + "h-" + LectureClients[14].Replace("N/A", "#") + "h et " + LectureClients[15].Replace("N/A", "#") + "h-" + LectureClients[16].Replace("N/A", "#") + "h";
            //Mar.Text = LectureClients[17].Replace("N/A", "#") + "h-" + LectureClients[18].Replace("N/A", "#") + "h et " + LectureClients[19].Replace("N/A", "#") + "h-" + LectureClients[20].Replace("N/A", "#") + "h";
            //Mer.Text = LectureClients[21].Replace("N/A", "#") + "h-" + LectureClients[22].Replace("N/A", "#") + "h et " + LectureClients[23].Replace("N/A", "#") + "h-" + LectureClients[24].Replace("N/A", "#") + "h";
            //Jeu.Text = LectureClients[25].Replace("N/A", "#") + "h-" + LectureClients[26].Replace("N/A", "#") + "h et " + LectureClients[27].Replace("N/A", "#") + "h-" + LectureClients[28].Replace("N/A", "#") + "h";
            //Ven.Text = LectureClients[29].Replace("N/A", "#") + "h-" + LectureClients[30].Replace("N/A", "#") + "h et " + LectureClients[31].Replace("N/A", "#") + "h-" + LectureClients[32].Replace("N/A", "#") + "h";
            //Sam.Text = LectureClients[33].Replace("N/A", "#") + "h-" + LectureClients[34].Replace("N/A", "#") + "h et " + LectureClients[35].Replace("N/A", "#") + "h-" + LectureClients[36].Replace("N/A", "#") + "h";
            //Dim.Text = LectureClients[37].Replace("N/A", "#") + "h-" + LectureClients[38].Replace("N/A", "#") + "h et " + LectureClients[39].Replace("N/A", "#") + "h-" + LectureClients[40].Replace("N/A", "#") + "h";

        }

        public void Init_Current_Client()
        {
            lbl_adresse.Text = "Adresse :  ";
            lbl_tel.Text = "Téléphone :  ";
            lbl_fax.Text = "Fax :  ";
            lbl_email.Text = "E-mail :  ";
            lbl_web.Text = "";
            lbl_Siret.Text = "SIRET :  ";
            lbl_NAF.Text = "Code NAF :  ";
            lbl_Effectif.Text = "Effectif de l'établissement :  ";
            lbl_Typo.Text = "Typologie de l'établissement :  ";
            lbl_Juridique.Text = "Statut juridique :  " ;
            txt_d.Text = "";
            Lun.Text = "";
            Mar.Text = "";
            Mer.Text = "";
            Jeu.Text = "";
            Ven.Text = "";
            Sam.Text = "";
            Dim.Text = "";
        }

        private void SupprimerClient_Click(object sender, EventArgs e)
        {
            if (ListClients.SelectedIndex != -1)
            {
                System.IO.File.Delete("" + ListClients.SelectedItem.ToString() + ".txt"); 
                Client_FILE_UPDATE(ListClients.SelectedItem.ToString()); 
            }
        }

        private void comboclients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListClients.SelectedIndex = comboclients.SelectedIndex;
        }

        private void ListClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboclients.SelectedIndex = ListClients.SelectedIndex;
            if (ListClients.SelectedIndex != -1)
            {
                string[] LectureClients = System.IO.File.ReadAllLines(@"" + ListClients.SelectedItem.ToString() + ".txt");
                Load_Current_Client(LectureClients);
            }
            else if (ListClients.SelectedIndex == -1) { Init_Current_Client(); }

        }

        public void ListClientsBase_Update()
        {
            if (ListClients.SelectedIndex != -1)
            {
                string[] LectureClients = System.IO.File.ReadAllLines(@"" + ListClients.SelectedItem.ToString() + ".txt");
                Load_Current_Client(LectureClients);
            }
            else if (ListClients.SelectedIndex == -1) { Init_Current_Client(); }
        }

        private void lbl_web_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ModifierClient_Click(object sender, EventArgs e)
        {
            if (ListClients.SelectedIndex != -1) 
            { 
                if (comboclients.SelectedIndex!=-1)
                {
                    if (f2lock == 0)// vérifie le nombre de feuilles form2, doit etre egal a zero
                    {
                        f2loadclient = 1;
                        f2 = new Form2(this); // créé une nouvelle feuille form2
                        f2.Show(); // affiche la nouvelle feuille
                        f2lock++; // inc. le nombre de feuille dans cet entier
                    }
                }
            }

        }




        private Form4 f4;
        int f4lock = 0;
        private void AddEquipe_Click(object sender, EventArgs e)
        {
            if (f4lock == 0)// vérifie le nombre de feuilles form2, doit etre egal a zero
            {
                f4 = new Form4(this); // créé une nouvelle feuille form2
                f4.Show(); // affiche la nouvelle feuille
                f4lock++; // inc. le nombre de feuille dans cet entier
            }
        }


        public void form4_unlock() // Permet de réinitialiser le compteur
        {
            f4lock = 0;
            f4loadclient = 0;
        }

        int f4loadclient = 0;
        public int form4_loadclientstat()
        {
            return f4loadclient;
        }





        private Form3 f3;
        int f3lock = 0;
        private void AddTravailleur_Click(object sender, EventArgs e)
        {
            if (f3lock == 0)// vérifie le nombre de feuilles form2, doit etre egal a zero
            {
                f3 = new Form3(this); // créé une nouvelle feuille form2
                f3.Show(); // affiche la nouvelle feuille
                f3lock++; // inc. le nombre de feuille dans cet entier
            }
        }


        public void form3_unlock() // Permet de réinitialiser le compteur
        {
            f3lock = 0;
            f3loadtravailleur = 0;
        }

        int f3loadtravailleur = 0;
        public int form3_loadtravailleurstat()
        {
            return f3loadtravailleur;
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
                this.lbl2_chk1.ForeColor=System.Drawing.Color.Green;
                this.lbl2_chk1.Text = "Ce travailleur possède un permis voiture.";
            }
            else if (Convert.ToBoolean(LectureTravailleurs[11])==false) 
            {
                this.lbl2_chk1.ForeColor = System.Drawing.Color.Red;
                this.lbl2_chk1.Text = "Ce travailleur ne possède pas de permis voiture.";
            }
             


            if (Convert.ToBoolean(LectureTravailleurs[12])) 
            {
                this.lbl2_chk2.ForeColor = System.Drawing.Color.Green;
                this.lbl2_chk2.Text = "Ce travailleur possède une voiture.";
            }
            else if (Convert.ToBoolean(LectureTravailleurs[12])==false) 
            {
                this.lbl2_chk2.ForeColor = System.Drawing.Color.Red;
                this.lbl2_chk2.Text = "Ce travailleur ne possède pas de voiture.";
            }
            

        }

        public void Init_Current_Travailleur()
        {
            this.lbl2_nom.Text ="";
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


        public void Travailleur_FILE_UPDATE(string travailleurname)
        {
            System.IO.File.Delete("ListeTravailleurs.txt");
            this.travailleurs.Remove(travailleurname);
            System.IO.File.WriteAllLines(@"ListeTravailleurs.txt", this.travailleurs);
            this.ListTravailleurs.Items.Remove(travailleurname);
            
        }


        private void SupprimerTravailleur_Click(object sender, EventArgs e)
        {
            if (ListTravailleurs.SelectedIndex != -1)
            {
                System.IO.File.Delete("" + ListTravailleurs.SelectedItem.ToString() + ".txt");
                Travailleur_FILE_UPDATE(ListTravailleurs.SelectedItem.ToString());
            }
        }

        public void ListTravailleursBase_Update()
        {
            if (ListTravailleurs.SelectedIndex != -1)
            {
                string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"" + ListTravailleurs.SelectedItem.ToString() + ".txt");
                Load_Current_Travailleur(LectureTravailleurs);
            }
            else if (ListTravailleurs.SelectedIndex == -1) { Init_Current_Travailleur(); }// ici Init et Load_Current inachever
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ListTravailleurs.SelectedIndex != -1)
            {
                if (f3lock == 0)// vérifie le nombre de feuilles form2, doit etre egal a zero
                {
                    f3loadtravailleur = 1;
                    f3 = new Form3(this); // créé une nouvelle feuille form2
                    f3.Show(); // affiche la nouvelle feuille
                    f3lock++; // inc. le nombre de feuille dans cet entier
                }
            }
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

        private Form_CV fCV;
        private void button6_Click(object sender, EventArgs e)
        {
            if (ListTravailleurs.SelectedIndex != -1)
            {
                //ICI NOUS ALONS GENERER ET AFFICHER UN CV POUR LE TRAVAILLEUR COURANT
                fCV = new Form_CV(this); // créé une nouvelle feuille form2
                fCV.Show(); // affiche la nouvelle feuille
            }
        }

        int CV_Manual = 0;
        string CV_Manual_current = "";
        public void ShowCV_Manual()
        {

            //ICI NOUS ALONS GENERER ET AFFICHER UN CV POUR LE TRAVAILLEUR COURANT
            fCV = new Form_CV(this); // créé une nouvelle feuille form2
            fCV.Show(); // affiche la nouvelle feuille
            

        }

        public void set_CV_Manual(int val)
        {
            CV_Manual = val;
        }

        public int get_CV_Manual()
        {
            return CV_Manual;
        }

        public void set_CV_Manual_current(string val)
        {
            CV_Manual_current = val;
        }

        public string get_CV_Manual_current()
        {
            return CV_Manual_current;
        }

        private void ListProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Load_Current_Equipe(string[] LectureClients)
        {
        }


        public void Init_Current_Equipe()
        {
        }

        private void listEquipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListEquipes.SelectedIndex != -1)
            {
                string[] LectureEquipes = System.IO.File.ReadAllLines(@"" + ListEquipes.SelectedItem.ToString() + ".txt");
                Load_Current_Equipe(LectureEquipes);
            }
            else if (ListEquipes.SelectedIndex == -1) { Init_Current_Equipe(); }
        }

        //public string current_travailleur_manual(string val)
        //{
        //    return ListTravailleurs.SelectedItem.ToString();
        //}

    }


}
