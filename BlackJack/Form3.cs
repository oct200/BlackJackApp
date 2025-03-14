using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Sanki_s_BlackJack
{
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
        }

        public string functieCryptare(string x)
        {
            byte[] parola;
            byte[] parolaHash;
            parola = ASCIIEncoding.ASCII.GetBytes(x);
            parolaHash = new MD5CryptoServiceProvider().ComputeHash(parola);

            string s = Encoding.UTF8.GetString(parolaHash, 0, parolaHash.Length);

            return s;
        }

        private void buttonIntrare_Click(object sender, EventArgs e)
        {
            string email = "", parola = "";
            if(textBoxEmail.Text == "" || textBoxParola.Text == "")
            {
                MessageBox.Show("Introduceti toate datele necesare!");
                return;
            }
            email = textBoxEmail.Text;
            parola = textBoxParola.Text;
            string parola1 = functieCryptare(parola);
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand selectare = new SqlCommand("SELECT Id_utilizator , limba, pachet FROM Utilizatori WHERE parola ='" + parola1 + "' AND email = '" + email + "'", conexiune);
            SqlDataReader dr = selectare.ExecuteReader();
            if(dr.Read())
            {
                FormStart.VariabilePublice.id_curent = Convert.ToInt32(dr[0]);
                FormStart.VariabilePublice.romana = Convert.ToInt32(dr[1]);
                FormStart.VariabilePublice.pachet = Convert.ToInt32(dr[2]);
                dr.Close();
                conexiune.Close();
                FormMeciuJoc fm = new FormMeciuJoc();
                this.Hide();
                fm.ShowDialog();
            }
            else
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Email sau parola gresite!");
                else
                    MessageBox.Show("Wrong email or password!");
            }
            if (!dr.IsClosed)
                dr.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormStart form = new FormStart();
            this.Hide();
            form.ShowDialog();
        }

        private void FormAutentificare_Load(object sender, EventArgs e)
        {
            if (FormStart.VariabilePublice.romana == 1)
            {
                buttonBack.Text = "Inapoi la meniu";
                buttonIntrare.Text = "Intra in cont";
                labelPasw.Text = "Parola";
            }
            else
            {
                buttonBack.Text = "Back to menu";
                buttonIntrare.Text = "Log in";
                labelPasw.Text = "Password";
            }
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Green;
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.DarkOrange;
        }

        private void buttonIntrare_MouseLeave(object sender, EventArgs e)
        {
            buttonIntrare.BackColor = Color.Green;
        }

        private void buttonIntrare_MouseEnter(object sender, EventArgs e)
        {
            buttonIntrare.BackColor = Color.DarkOrange;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.SteelBlue;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Cyan;
        }

        private void labelPasw_Click(object sender, EventArgs e)
        {

        }
    }
}
