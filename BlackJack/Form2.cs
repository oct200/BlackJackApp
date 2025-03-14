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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Sanki_s_BlackJack
{
    public partial class FormInregistrare : Form
    {
        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStart form = new FormStart();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        { 

            string email = "", parola = "", reparola = "m";
            email = textBoxEmail.Text;
            parola = textBoxParola.Text;
            reparola = textBoxReParola.Text;

            if (email == "" || parola == "" || reparola == "")
            {
                if(FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Introduceti toate datele");
                else
                    MessageBox.Show("Enter all data!");
                return;
            }
            if(parola.Length < 8)
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Parola trebuie sa contina minimum 8 caractere!");
                else
                    MessageBox.Show("The password has to be at least 8 characters long!");
                return;
            }
            if(parola != reparola)
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Parola a fost reintrodusa gresit");
                else
                    MessageBox.Show("The password was re-entered incorrectly");
                return;
            }
            /*if(email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Introdu un format corect de email!");
                else
                    MessageBox.Show("Please enter a correct email format");
                return;
            }*/
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = reg.Match(email);
            if (!match.Success)
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Emailul nu este valid");
                else
                    MessageBox.Show("Please enter a valid email");
                return;
            }
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand verificare = new SqlCommand("SELECT Id_utilizator FROM Utilizatori WHERE email = '" + email + "'", conexiune);
            SqlDataReader dr = verificare.ExecuteReader();
            if(dr.Read())
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Email-ul este folosit deja");
                else
                    MessageBox.Show("Email is already in use");
                conexiune.Close();
                return;
            }
            dr.Close();

            string s = functie.functieCryptare(parola);

            SqlCommand inserare = new SqlCommand("INSERT INTO Utilizatori(email,parola) VALUES ('" + email + "' , '" + s + "') ", conexiune);
            inserare.ExecuteNonQuery();
            if (FormStart.VariabilePublice.romana == 1)
                MessageBox.Show("Inregistrat cu succes!");
            else
                MessageBox.Show("Successfully registered!");
            conexiune.Close();
            buttonBack.PerformClick();
        }


        private void FormInregistrare_Load(object sender, EventArgs e)
        {
            if (FormStart.VariabilePublice.romana == 1)
            {
                buttonInregistrare.Text = "Inregistrare";
                buttonBack.Text = "Inapoi la meniu";
                labelPasw.Text = "Parola";
                labelRePasw.Text = "Reintroduceti parola";
            }
            else
            {
                buttonInregistrare.Text = "Register";
                buttonBack.Text = "Back to menu";
                labelPasw.Text = "Password";
                labelRePasw.Text = "Re-enter password";
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

        private void buttonInregistrare_MouseLeave(object sender, EventArgs e)
        {
            buttonInregistrare.BackColor = Color.Green;
        }

        private void buttonInregistrare_MouseEnter(object sender, EventArgs e)
        {
            buttonInregistrare.BackColor = Color.DarkOrange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.SteelBlue;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Cyan;
        }
    }
    public static class functie
    {
        public static string functieCryptare(string x)
        {
            byte[] parola;
            byte[] parolaHash;
            parola = ASCIIEncoding.ASCII.GetBytes(x);
            parolaHash = new MD5CryptoServiceProvider().ComputeHash(parola);

            string s = Encoding.UTF8.GetString(parolaHash, 0, parolaHash.Length);

            return s;
        }
    }
}
