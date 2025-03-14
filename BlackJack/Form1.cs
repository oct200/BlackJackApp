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

namespace Sanki_s_BlackJack
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static class VariabilePublice
        {
            public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\BazaBlackjack.mdf"";Integrated Security=True;Connect Timeout=30";
            public static int id_curent;
            public static int pachet = 0;
            public static int romana = 0;
            public static int fullscreen = 0;
        }

        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            FormAutentificare form = new FormAutentificare();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            FormInregistrare form = new FormInregistrare();
            this.Hide();
            form.ShowDialog();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            if(VariabilePublice.romana == 1)
            {
                buttonAutentificare.Text = "Autentificare";
                buttonInregistrare.Text = "Inregistrare";
            }
            else
            {
                buttonAutentificare.Text = "Log in";
                buttonInregistrare.Text = "Register";
            }
        }

        private void buttonInregistrare_MouseLeave(object sender, EventArgs e)
        {
            buttonInregistrare.BackColor = Color.Green;
        }

        private void buttonInregistrare_MouseEnter(object sender, EventArgs e)
        {
            buttonInregistrare.BackColor = Color.DarkOrange;
        }

        private void buttonAutentificare_MouseLeave(object sender, EventArgs e)
        {
            buttonAutentificare.BackColor = Color.Green;
        }

        private void buttonAutentificare_MouseEnter(object sender, EventArgs e)
        {
            buttonAutentificare.BackColor = Color.DarkOrange;
        }

        private void buttonIesire_MouseLeave(object sender, EventArgs e)
        {
            buttonIesire.BackColor = Color.SteelBlue;
        }

        private void buttonIesire_MouseEnter(object sender, EventArgs e)
        {
            buttonIesire.BackColor = Color.Cyan;
        }
    }
}
