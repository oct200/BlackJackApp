using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanki_s_BlackJack
{
    public partial class FormMeciuJoc : Form
    {
        public FormMeciuJoc()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOptiuni_Click(object sender, EventArgs e)
        {
            FormOptiuni fo = new FormOptiuni();
            this.Hide();
            fo.ShowDialog();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormJoc fj = new FormJoc();
            this.Hide();
            fj.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAutentificare form = new FormAutentificare();
            this.Hide();
            form.ShowDialog();
        }

        private void FormMeciuJoc_Load(object sender, EventArgs e)
        {
            if (FormStart.VariabilePublice.romana == 1)
            {
                buttonBack.Text = "Inapoi la meniu";
                buttonOptiuni.Text = "Optiuni";
                buttonPlay.Text = "Joaca";
                linkLabelHowToPlay.Text = "Cum se joaca?";
            }
            else
            {
                buttonBack.Text = "Back to menu";
                buttonOptiuni.Text = "Options";
                buttonPlay.Text = "Play";
                linkLabelHowToPlay.Text = "How to play?";
            }
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackColor = Color.Green;
        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackColor = Color.DarkOrange;
        }

        private void buttonOptiuni_MouseLeave(object sender, EventArgs e)
        {
            buttonOptiuni.BackColor = Color.Green;
        }

        private void buttonOptiuni_MouseEnter(object sender, EventArgs e)
        {
            buttonOptiuni.BackColor = Color.DarkOrange;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Green;
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.DarkOrange;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.SteelBlue;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Cyan;
        }

        private void linkLabelHowToPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelHowToPlay.LinkVisited = true;
            if (FormStart.VariabilePublice.romana == 1)
                System.Diagnostics.Process.Start("https://pariurix.com/casino/blackjack/ghid-blackjack-online.html#gref");
            else
                System.Diagnostics.Process.Start("https://www.blackjackapprenticeship.com/how-to-play-blackjack/");
        }
    }
}
