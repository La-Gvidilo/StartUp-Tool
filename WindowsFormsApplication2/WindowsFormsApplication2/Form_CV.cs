using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication2
{
    public partial class Form_CV : Form
    {
        Form1 _form1;
        public Form_CV(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Load_Current_CV(string[] LectureTravailleurs)
        {
            char[] delimiterChars = { '_', ',', ';' };
            int taille;

            taille = Convert.ToInt32(LectureTravailleurs.Length.ToString());
            string NomPrenom = "";
            if (_form1.get_CV_Manual() == 0) { NomPrenom = _form1.current_travailleur(); }
            if (_form1.get_CV_Manual() == 1) { NomPrenom = _form1.get_CV_Manual_current(); }


            string[] NomPrenomLst = NomPrenom.Split(delimiterChars);

            //Travailleur_nom.Text = NomPrenomLst[0];
            //Travailleur_prenom.Text = NomPrenomLst[1];
            //Travailleur_adresse.Text = LectureTravailleurs[0];
            //Travailleur_dateN.Value = Convert.ToDateTime(LectureTravailleurs[1]);
            //Travailleur_tel.Text = LectureTravailleurs[2];
            //Travailleur_fax.Text = LectureTravailleurs[3];
            //Travailleur_email.Text = LectureTravailleurs[4];
            //Travailleur_web.Text = LectureTravailleurs[5];
            //Travailleur_fb.Text = LectureTravailleurs[6];
            //Travailleur_tweet.Text = LectureTravailleurs[7];
            //Travailleur_formations.Text = LectureTravailleurs[8].Replace("§", "\r\n");
            //Travailleur_experiences.Text = LectureTravailleurs[9].Replace("§", "\r\n");
            //Travailleur_interets.Text = LectureTravailleurs[10].Replace("§", "\r\n");
            //Travailleur_check1.Checked = Convert.ToBoolean(LectureTravailleurs[11]);
            //Travailleur_check2.Checked = Convert.ToBoolean(LectureTravailleurs[12]);

            //Description.Text = LectureTravailleurs[12].Replace("§", "\r\n");

            Image img = Image.FromFile("NewLogo.png");
            Clipboard.SetImage(img);
            this.richText1.Paste();
            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Regular);
            this.richText1.AppendText("\r\n"+NomPrenomLst[0].ToUpper()+" - "+NomPrenomLst[1].ToLower()+"\r\n"+LectureTravailleurs[0]+"\r\nTéléphone: "+LectureTravailleurs[2]+"\r\nE-mail: "+LectureTravailleurs[4]+"\r\n");
            
            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Bold);
            this.richText1.AppendText("\r\n\r\nFORMATION.:");
            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Regular);
            this.richText1.AppendText("\r\n"+LectureTravailleurs[8].Replace("§","\r\n"));

            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Bold);
            this.richText1.AppendText("\r\n\r\nEXPERIENCES PROFESIONNELLES.:");
            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Regular);
            this.richText1.AppendText("\r\n" + LectureTravailleurs[9].Replace("§", "\r\n"));

            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Bold);
            this.richText1.AppendText("\r\n\r\nCENTRES D'INTERETS.:");
            this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Regular);
            this.richText1.AppendText("\r\n" + LectureTravailleurs[10].Replace("§", "\r\n"));

            //this.richText1.SelectionFont = new Font(this.richText1.Font, FontStyle.Regular);
            //this.richText1.AppendText("\r\n");

        }

        private void Form_CV_Load(object sender, EventArgs e)
        {
            if (_form1.get_CV_Manual()==0)
            {
               string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"" + _form1.current_travailleur() + ".txt");
               Load_Current_CV(LectureTravailleurs);
            }
            else if (_form1.get_CV_Manual() == 1)
            {
                string[] LectureTravailleurs = System.IO.File.ReadAllLines(@"" + _form1.get_CV_Manual_current() + ".txt");
                Load_Current_CV(LectureTravailleurs);
            }
            
            


            
        }
    }
}
