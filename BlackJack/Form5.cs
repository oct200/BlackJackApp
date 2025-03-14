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
using System.IO;

namespace Sanki_s_BlackJack
{
    public partial class FormOptiuni : Form
    {
        int victorii = 0, puncte_catigate = 0, vic_max = 0, pac = FormStart.VariabilePublice.pachet;
        public FormOptiuni()
        {
            InitializeComponent();
            ///InitializareImagini(FormStart.VariabilePublice.pachet);
        }

        private void InitializareImagini(int p)
        {
            Random r = new Random();
            int nrcard = r.Next(1, 53);
            nrcard += p * 53;
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand selectare = new SqlCommand("SELECT poza_carte FROM ImaginiCarti1 WHERE Id_carte = '" + (p+1)*53 + "'", conexiune);
            SqlDataReader dr = selectare.ExecuteReader();
            if (dr.Read())
            {
                MemoryStream ms = new MemoryStream(dr.GetSqlBytes(0).Buffer);
                pictureBoxCarte1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxCarte1.Image = Image.FromStream(ms);
            }
            dr.Close();
            SqlCommand selectare1 = new SqlCommand("SELECT poza_carte FROM ImaginiCarti1 WHERE Id_carte = '" + nrcard + "'", conexiune);
            SqlDataReader dr1 = selectare1.ExecuteReader();
            if (dr1.Read())
            {
                MemoryStream ms = new MemoryStream(dr1.GetSqlBytes(0).Buffer);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromStream(ms);
            }
            dr1.Close();
            conexiune.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInserare_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            int x = comboBoxPachet.SelectedIndex;
            if (x == -1)
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Selecteaza un pachet!");
                else
                    MessageBox.Show("Please select a deck");
                return;
            }
            if (x == 0)
            {
                conexiune.Open();
                SqlCommand update = new SqlCommand("UPDATE Utilizatori SET pachet = 0 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent +"'", conexiune);
                update.ExecuteNonQuery();
                conexiune.Close();
                FormStart.VariabilePublice.pachet = 0;
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Pachet selectat!");
                else
                    MessageBox.Show("Deck selected");

            }
            if(x == 1)
            {
                if (victorii >= 10)
                {
                    conexiune.Open();
                    SqlCommand update = new SqlCommand("UPDATE Utilizatori SET pachet = 1 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
                    update.ExecuteNonQuery();
                    conexiune.Close();
                    FormStart.VariabilePublice.pachet = 1;
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Pachet selectat!");
                    else
                        MessageBox.Show("Deck selected");
                }
                else
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Necesita 10 victorii!");
                    else
                        MessageBox.Show("Requires 10 victories");
                }
            }
            if (x == 2)
            {
                if (vic_max >= 3)
                {
                    conexiune.Open();
                    SqlCommand update = new SqlCommand("UPDATE Utilizatori SET pachet = 2 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
                    update.ExecuteNonQuery();
                    conexiune.Close();
                    FormStart.VariabilePublice.pachet = 2;
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Pachet selectat!");
                    else
                        MessageBox.Show("Deck selected");
                }
                else
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Necesita 3 victorii consecutive!");
                    else
                        MessageBox.Show("Requires 3 consecutive victories");
                }
            }
            if (x == 3)
            {
                if (puncte_catigate >= 200)
                {
                    conexiune.Open();
                    SqlCommand update = new SqlCommand("UPDATE Utilizatori SET pachet = 3 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
                    update.ExecuteNonQuery();
                    conexiune.Close();
                    FormStart.VariabilePublice.pachet = 3;
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Pachet selectat!");
                    else
                        MessageBox.Show("Deck selected");
                }
                else
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Necesita 200 puncte castigate!");
                    else
                        MessageBox.Show("Requires 200 points won!");
                }
            }
            if (x == 4)
            {
                if (puncte_catigate >= 300 && vic_max >= 4 && victorii >= 20)
                {
                    conexiune.Open();
                    SqlCommand update = new SqlCommand("UPDATE Utilizatori SET pachet = 4 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
                    update.ExecuteNonQuery();
                    conexiune.Close();
                    FormStart.VariabilePublice.pachet = 4;
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Pachet selectat!");
                    else
                        MessageBox.Show("Deck selected");
                }
                else
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Necesita 300 puncte castigate si 4 victorii consecutive si 20 victorii!");
                    else
                        MessageBox.Show("Requires 300 points won and 4 consecutive wins and 20 wins!");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMeciuJoc form = new FormMeciuJoc();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormStart.VariabilePublice.romana == 0)
                return;
            FormStart.VariabilePublice.romana = 0;
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand replace = new SqlCommand("UPDATE Utilizatori SET limba = 0 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent + "'" , conexiune);
            replace.ExecuteNonQuery();
            conexiune.Close();
            buttonEngl.Text = "English";
            buttonRom.Text = "Romanian";
            buttonBack.Text = "Back to menu";
            labelPac.Text = "Card packet used";
            labelLimba.Text = "Language";
            buttonInserare.Text = "Insert images";
            labelPuncteTot.Text = "Dolars won: ";
            labelVictorii.Text = "Wins: ";
            labelVictoriiCons.Text = "Consecutive wins: ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FormStart.VariabilePublice.romana == 0)
            {
                FormStart.VariabilePublice.romana = 1;
                SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
                conexiune.Open();
                SqlCommand replace = new SqlCommand("UPDATE Utilizatori SET limba = 1 WHERE Id_Utilizator = '" + FormStart.VariabilePublice.id_curent + "'" , conexiune);
                replace.ExecuteNonQuery();
                conexiune.Close();
            }
            buttonEngl.Text = "Engleza";
            buttonRom.Text = "Romana";
            buttonBack.Text = "Inapoi la meniu";
            labelPac.Text = "Pachet de carti folosit";
            labelLimba.Text = "Limba";
            buttonInserare.Text = "Inserare imagini";
            labelPuncteTot.Text = "Dolari castigati: ";
            labelVictorii.Text = "Victorii: ";
            labelVictoriiCons.Text = "Victorii consecutive: ";
        }

        private void FormOptiuni_Load(object sender, EventArgs e)
        {

            InitializareImagini(FormStart.VariabilePublice.pachet);
            if (FormStart.VariabilePublice.romana == 1)
            {
                buttonEngl.Text = "Engleza";
                buttonRom.Text = "Romana";
                buttonBack.Text = "Inapoi la meniu";
                labelPac.Text = "Pachet de carti folosit";
                labelLimba.Text = "Limba";
                buttonInserare.Text = "Selecteaza pachetul";
                labelPuncteTot.Text = "Dolari castigati: ";
                labelVictorii.Text = "Victorii: ";
                labelVictoriiCons.Text = "Victorii consecutive: ";
            }
            else
            {
                buttonEngl.Text = "English";
                buttonRom.Text = "Romanian";
                buttonBack.Text = "Back to menu";
                labelPac.Text = "Card packet used";
                labelLimba.Text = "Language";
                buttonInserare.Text = "Select the deck";
                labelPuncteTot.Text = "Dolars won: ";
                labelVictorii.Text = "Wins: ";
                labelVictoriiCons.Text = "Consecutive wins: ";
            }
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand nrPuncte = new SqlCommand("SELECT victorii , puncte_castigate , victorii_consecutive_max FROM Utilizatori WHERE Id_utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
            SqlDataReader dr = nrPuncte.ExecuteReader();
            if (dr.Read())
            {
                victorii = Convert.ToInt32(dr[0]);
                puncte_catigate = Convert.ToInt32(dr[1]);
                vic_max = Convert.ToInt32(dr[2]);
            }
            dr.Close();
            conexiune.Close();
            textBoxPuncteTot.Text = Convert.ToString(puncte_catigate);
            textBoxVictorii.Text = Convert.ToString(victorii);
            textBoxVictoriiCons.Text = Convert.ToString(vic_max);
        }

        private void buttonEngl_MouseLeave(object sender, EventArgs e)
        {
            buttonEngl.BackColor = Color.Lime;
        }

        private void buttonEngl_MouseEnter(object sender, EventArgs e)
        {
            buttonEngl.BackColor = Color.DarkOrange;
        }

        private void buttonRom_MouseLeave(object sender, EventArgs e)
        {
            buttonRom.BackColor = Color.Lime;
        }

        private void buttonRom_MouseEnter(object sender, EventArgs e)
        {
            buttonRom.BackColor = Color.DarkOrange;
        }

        private void buttonInserare_MouseLeave(object sender, EventArgs e)
        {
            buttonInserare.BackColor = Color.Lime;
        }

        private void buttonInserare_MouseEnter(object sender, EventArgs e)
        {
            buttonInserare.BackColor = Color.DarkOrange;
        }

        private void buttonBack_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Green;
        }

        private void comboBoxPachet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = comboBoxPachet.SelectedIndex;
            InitializareImagini(x);
        }

        private void pictureBoxCarte1_Click(object sender, EventArgs e)
        {

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
    }
}
