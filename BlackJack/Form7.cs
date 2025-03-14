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
    public partial class FormJoc : Form
    {
        int esteGata = 1;
        int nrTick = 0, m = 0, wjucator, wdealer, hjucator, hdealer, wjucatorSt, wjucatorDr;
        int sumaJucator = 0, sumaDealer = 0, sumaSt = 0, sumaDr = 0;
        int nrAsiJucator = 0, nrAsiDealer = 0 , nrAsiSt = 0, nrAsiDr = 0;
        int sumaPariata = 0, sumaPariataSt = 0, sumaPariataDr = 0;
        int[] viz = new int[54];
        int[] nr_tick = new int[54];
        int pac = 4;
        int split = 0;
        int sizex = 90, sizey = 110;
        int insurance = 0 , nrCardInsurance = 0;
        PictureBox[] pic;
        Random r =new Random();
        Timer[] t;

        private void AdaugaPuncte(int x)
        {
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand nrPuncte = new SqlCommand("SELECT puncte , victorii , victorii_consecutive , puncte_castigate , victorii_consecutive_max FROM Utilizatori WHERE Id_utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
            SqlDataReader dr = nrPuncte.ExecuteReader();
            int nr_puncte = 0 , victorii = 0 , puncte_catigate = 0  , victorii_cons = 0 , vic_max = 0;
            if(dr.Read())
            {
                nr_puncte = Convert.ToInt32(dr[0]);
                victorii = Convert.ToInt32(dr[1]);
                victorii_cons = Convert.ToInt32(dr[2]);
                puncte_catigate = Convert.ToInt32(dr[3]);
                vic_max = Convert.ToInt32(dr[4]);
            }
            if (x > 0)
            {
                victorii++;
                victorii_cons++;
                puncte_catigate += x;
            }
            else
                victorii_cons = 0;
            if (victorii_cons > vic_max)
                vic_max = victorii_cons;
            dr.Close();
            nr_puncte += x;
            textBoxPuncteTot.Text = Convert.ToString(nr_puncte);
            SqlCommand adaugare = new SqlCommand("UPDATE Utilizatori SET puncte = '" + nr_puncte + "' , victorii = '" + victorii + "' , victorii_consecutive = '" + victorii_cons + "' , puncte_castigate =  '" + puncte_catigate + "' , victorii_consecutive_max = '" + vic_max + "' WHERE Id_utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
            adaugare.ExecuteNonQuery();
            conexiune.Close();
        }

        private void FormJoc_Load(object sender, EventArgs e)
        {
            progressBarLoading.Value = 0;
            panelBet.Visible = false;
            textBoxPuncteTot.Visible = false;
            labelPuncteTot.Visible = false;
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand select = new SqlCommand("SELECT pachet , puncte FROM Utilizatori WHERE Id_utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
            SqlDataReader dr = select.ExecuteReader();
            int nrpuncte = 0;
            if(dr.Read())
            {
                nrpuncte = Convert.ToInt32(dr[1]);
                pac = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            if(nrpuncte == 0)
            {
                nrpuncte = 25;
                SqlCommand resetare = new SqlCommand("UPDATE Utilizatori SET puncte = '" + nrpuncte + "' WHERE Id_utilizator = '" + FormStart.VariabilePublice.id_curent + "'", conexiune);
                resetare.ExecuteNonQuery();
            }
            textBoxPuncteTot.Text = Convert.ToString(nrpuncte);
            conexiune.Close();
            if (FormStart.VariabilePublice.romana == 1)
            {
                buttonIncepe.Text = "Incepe";
                buttonInapoi.Text = "Inapoi";
                buttonSplit.Text = "Desparte";
                buttonDouble.Text = "Dubleaza";
                buttonHit.Text = "Carte";
                buttonStand.Text = "Stai";
                buttonInsurance.Text = "Asiguranta";                
                labelPariaza.Text = "Pariaza";
                labelPuncteTot.Text = "Dolari totali: ";
            }
            else
            {
                buttonIncepe.Text = "Start";
                buttonInapoi.Text = "Back to menu";
                buttonSplit.Text = "Split";
                buttonDouble.Text = "Double down";
                buttonHit.Text = "Hit";
                buttonStand.Text = "Stand";
                buttonInsurance.Text = "Insurance bet";
                labelPariaza.Text = "Bet";
                labelPuncteTot.Text = "Total dolars: ";
            }
            ///timerLoading.Enabled = true;
            labelLoading.Visible = false;
            progressBarLoading.Visible = false;
            /*this.BackgroundImage = Sanki_s_BlackJack.Properties.Resources.Loading;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            */
            this.BackgroundImage = null;
            panelBet.Visible = true;
            textBoxPuncteTot.Visible = true;
            labelPuncteTot.Visible = true;
            timerLoading.Stop();
        }

        private void buttonIncepe_MouseLeave(object sender, EventArgs e)
        {
            buttonIncepe.BackColor = Color.Green;
        }

        private void buttonIncepe_MouseEnter(object sender, EventArgs e)
        {
            buttonIncepe.BackColor = Color.DarkOrange;
        }

        private void buttonInapoi_MouseLeave(object sender, EventArgs e)
        {
            buttonInapoi.BackColor = Color.Green;
        }

        private void buttonInapoi_MouseEnter(object sender, EventArgs e)
        {
            buttonInapoi.BackColor = Color.DarkOrange;
        }

        private void buttonInsurance_MouseLeave(object sender, EventArgs e)
        {
            buttonInsurance.BackColor = Color.Green;
        }

        private void buttonInsurance_MouseEnter(object sender, EventArgs e)
        {
            buttonInsurance.BackColor = Color.DarkOrange;
        }

        private void buttonSplit_MouseLeave(object sender, EventArgs e)
        {
            buttonSplit.BackColor = Color.Green;
        }

        private void buttonSplit_MouseEnter(object sender, EventArgs e)
        {
            buttonSplit.BackColor = Color.DarkOrange;
        }

        private void buttonDouble_MouseLeave(object sender, EventArgs e)
        {
            buttonDouble.BackColor = Color.Green;
        }

        private void buttonDouble_MouseEnter(object sender, EventArgs e)
        {
            buttonDouble.BackColor = Color.DarkOrange;
        }

        private void buttonHit_MouseLeave(object sender, EventArgs e)
        {
            buttonHit.BackColor = Color.Green;
        }

        private void buttonHit_MouseEnter(object sender, EventArgs e)
        {
            buttonHit.BackColor = Color.DarkOrange;
        }

        private void buttonStand_MouseLeave(object sender, EventArgs e)
        {
            buttonStand.BackColor = Color.Green;
        }

        private void buttonStand_MouseEnter(object sender, EventArgs e)
        {
            buttonStand.BackColor = Color.DarkOrange;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.SteelBlue;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Cyan;
        }

        private void buttonFullScreen_MouseLeave(object sender, EventArgs e)
        {
            buttonFullScreen.BackColor = Color.SteelBlue;
        }

        private void buttonFullScreen_MouseEnter(object sender, EventArgs e)
        {
            buttonFullScreen.BackColor = Color.Cyan;
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            progressBarLoading.Value += 1;
            if (progressBarLoading.Value == progressBarLoading.Maximum)
            {
                labelLoading.Visible = false;
                progressBarLoading.Visible = false;
                /*this.BackgroundImage = Sanki_s_BlackJack.Properties.Resources.Loading;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                */
                this.BackgroundImage = null;
                panelBet.Visible = true;
                textBoxPuncteTot.Visible = true;
                labelPuncteTot.Visible = true;
                timerLoading.Stop();
            }
        }

        private void textBoxPariaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void labelLoading_Click(object sender, EventArgs e)
        {

        }

        private void button_allIn_Click(object sender, EventArgs e)
        {

        }

        private void buttonFullScreen_Click(object sender, EventArgs e)
        {
            if (FormStart.VariabilePublice.fullscreen == 0)
            {
                FormStart.VariabilePublice.fullscreen = 1;
                WindowState = FormWindowState.Maximized;
                buttonFullScreen.BackgroundImage = Sanki_s_BlackJack.Properties.Resources.minimize;
                sizex = (90 * this.Width) / 1410;
                sizey = (110 * this.Height) / 700;
            }
            else
            {
                FormStart.VariabilePublice.fullscreen = 0;
                WindowState = FormWindowState.Normal;
                buttonFullScreen.BackgroundImage = Sanki_s_BlackJack.Properties.Resources.fullscreen;
                sizex = 90;
                sizey = 110;
            }
            hjucator = panelCarti.Height / 5 * 4 - 40;
            wjucator = panelCarti.Width / 2 - 55;
            wdealer = panelCarti.Width / 2 - 55;
            wjucatorSt = 20 + 35;
            wjucatorDr = panelCarti.Width - 20 - 90 - 35;
            for (int i = 0; i < m; i++)
            {
                    pic[i].Size = new Size(sizex, sizey);
                    if (i == 2)
                    {
                       pic[i].Location = new Point(wdealer, hdealer);
                       wdealer += 35;
                    }
                    else if (i == 4)
                    {
                            pic[i].Location = new Point(wdealer, hdealer);
                            wdealer += 35;
                    }
                    else if (pic[i].Location.Y < panelCarti.Height / 3)
                    {
                        pic[i].Location = new Point(wdealer, hdealer);
                        wdealer += 35;
                    }
                    else if (split == 0)
                    {
                      if (i == 1)
                      {
                          pic[i].Location = new Point(wjucator, hjucator);
                          wjucator += 35;
                      }
                      else if (i == 3)
                      {
                          pic[i].Location = new Point(wjucator, hjucator);
                          wjucator += 35;
                      }
                      else if (pic[i].Location.Y > panelCarti.Height / 3 && i != 0)
                      {
                          pic[i].Location = new Point(wjucator, hjucator);
                          wjucator += 35;
                       }
                    }
                    else if(split > 0)
                    {
                      if(pic[i].Location.X < panelCarti.Width / 3)
                      {
                        pic[i].Location = new Point(wjucatorSt, hjucator);
                        wjucatorSt += 35;
                      }
                      else if(pic[i].Location.X > panelCarti.Width / 3)
                      {
                        pic[i].Location = new Point(wjucatorDr, hjucator);
                        wjucatorDr += 35;
                      }
                    }
            }
            if (m != 0)
            {
                if (split == 0)
                {
                    pic[0].Location = new Point((pic[1].Location.X + pic[2].Location.X) / 2, (pic[1].Location.Y + pic[2].Location.Y) / 2);
                }
                else
                {
                    pic[0].Location = new Point(pic[2].Location.X, (pic[1].Location.Y + pic[2].Location.Y) / 2);
                }
            }
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            buttonInsurance.Enabled = false;
            buttonSplit.Enabled = false;
            if (split == 0)
            {
                buttonDouble.Enabled = false;
                GenerareCarte(m, wjucator, hjucator, true, nrRandomCarte());
                m++;
            }
            if (split == 2)
            {
                buttonDouble.Enabled = false;
                GenerareCarte(m, wjucatorDr, hjucator, true, nrRandomCarte());
                m++;
            }
            if (split == 1)
            {
                buttonDouble.Enabled = false;
                GenerareCarte(m, wjucatorSt, hjucator, true, nrRandomCarte());
                m++;
            }
        }

        private void GenerareCarte(int m1 , int w , int h , bool esteJucator , int nrcard)
        {
            int hinceput = panelCarti.Height / 2 - 55;
            int winceput = panelCarti.Width / 2 - 55;
            pic[m1] = new PictureBox();
            pic[m1].Size = new Size(sizex, sizey);
            pic[m1].Location = new Point(winceput, hinceput);
            pic[m1].Name = "pic" + m1;
            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand selectare = new SqlCommand("SELECT poza_carte , valoare FROM ImaginiCarti1 WHERE Id_carte = '" + nrcard + "'", conexiune);
            SqlDataReader dr = selectare.ExecuteReader();
            int val = 0;
            if (dr.Read())
            {
                MemoryStream ms = new MemoryStream(dr.GetSqlBytes(0).Buffer);
                pic[m1].SizeMode = PictureBoxSizeMode.StretchImage;
                pic[m1].Image = Image.FromStream(ms);
                val = Convert.ToInt32(dr[1]);
            }
            if(m1 == 1)
            {
                sumaSt += val;
                if (val == 11)
                    nrAsiSt++;
            }
            if(m1 == 3)
            {
                sumaDr += val;
                if (val == 11)
                    nrAsiDr++;
                if (sumaJucator == val)
                    buttonSplit.Enabled = true;
            }
            if (val == 11)
            {
                if (esteJucator)
                {
                    if (split == 0)
                        nrAsiJucator++;
                    else if (split == 1)
                        nrAsiSt++;
                    else if (split == 2)
                        nrAsiDr++;
                }
                else
                {
                    nrAsiDealer++;
                    buttonInsurance.Enabled = true;
                }
            }
            if(esteJucator == true)
            {
                if(split == 0)
                {
                    wjucator += 35;
                    sumaJucator += val;
                    labelSuma.Text = "" + sumaJucator;
                    if (sumaJucator > 21)
                    {
                        if (nrAsiJucator > 0)
                        {
                            sumaJucator -= 10;
                            nrAsiJucator--;
                            labelSuma.Text = "" + sumaJucator;
                        }
                        else
                        {
                            if (FormStart.VariabilePublice.romana == 1)
                                labelRezultat.Text = "Ai pierdut " + sumaPariata;
                            else
                                labelRezultat.Text = "You lost " + sumaPariata;
                            AdaugaPuncte(-sumaPariata);
                            textBoxPariaza.ReadOnly = false;
                            labelRezultat.Visible = true;
                            panelControaleJoc.Visible = false;
                            buttonIncepe.Visible = true;
                            buttonInapoi.Visible = true;
                        }
                    }
                    /*else
                    {
                        if (sumaJucator == 21)
                        {
                            buttonStand.PerformClick();
                        }
                    }*/
                }
                if (split == 2)
                {
                    wjucatorDr -= 35;
                    sumaDr += val;
                    labelSumaDr.Text = "" + sumaDr;
                    if (sumaDr > 21)
                    {
                        if (nrAsiDr > 0)
                        {
                            sumaDr -= 10;
                            nrAsiDr--;
                            labelSumaDr.Text = "" + sumaDr;
                        }
                        else
                        {
                            if(sumaSt > 21)
                            {
                                buttonInapoi.Visible = true;
                                buttonIncepe.Visible = true;
                                if (FormStart.VariabilePublice.romana == 1)
                                    labelRezultat.Text = "Ai pierdut " + (sumaPariataDr + sumaPariataSt);
                                else
                                    labelRezultat.Text = "You lost " + (sumaPariataDr + sumaPariataSt);
                                textBoxPariaza.ReadOnly = false;
                                labelRezultat.Visible = true;
                            }
                            else
                            {
                                buttonStand.PerformClick();
                            }
                            textBoxDr.Visible = false;
                            panelControaleJoc.Visible = false;
                            labelRezultatDr.Visible = true;
                            if (FormStart.VariabilePublice.romana == 1)
                                labelRezultatDr.Text = "Ai pierdut " + sumaPariataDr;
                            else
                                labelRezultatDr.Text = "You lost " + sumaPariataDr;
                            AdaugaPuncte(-sumaPariataDr);
                        }
                    }
                    /*else
                    {
                        if (sumaDr == 21)
                            buttonStand.PerformClick();
                    }*/
                }
                if(split == 1)
                {
                    wjucatorSt += 35;
                    sumaSt += val;
                    labelSumaSt.Text = "" + sumaSt;
                    if (sumaSt > 21)
                    {
                        if (nrAsiSt > 0)
                        {
                            sumaSt -= 10;
                            nrAsiSt--;
                            labelSumaSt.Text = "" + sumaSt;
                        }
                        else
                        {
                            AdaugaPuncte(-sumaPariataSt);
                            textBoxSt.Visible = false;
                            panelControaleJoc.Visible = true;
                            buttonDouble.Enabled = true;
                            labelRezultatSt.Visible = true;
                            if (FormStart.VariabilePublice.romana == 1)
                                labelRezultatSt.Text = "Ai pierdut " + sumaPariataSt;
                            else
                                labelRezultatSt.Text = "You lost " + sumaPariataSt;
                            split++;
                            textBoxDr.Visible = true;
                        }
                    }
                    /*else
                    {
                        if (sumaSt == 21)
                            buttonStand.PerformClick();
                    }*/
                }
            }
            else
            {
                wdealer += 35;
                sumaDealer += val;
                if (sumaDealer > 21)
                {
                    if (nrAsiDealer > 0)
                    {
                        sumaDealer -= 10;
                        nrAsiDealer--;
                    }
                }
                labelSumaDealer.Text = "" + sumaDealer;
            }
            dr.Close();
            conexiune.Close();

            panelCarti.Controls.Add(pic[m1]);
            if (m1 >= 1)
            {
                pic[m].BringToFront();
            }
            int wplus = (w - winceput) / 20, hplus = (h - hinceput) / 20;
            if (m1 != 0)
            {
                t[m1] = new Timer();
                t[m1].Interval = 40;
                t[m1].Tick += delegate (object sender, EventArgs e)
                {
                    t_Tick(sender, e, m1, wplus, hplus, w, h);
                };
                this.components.Add(t[m1]);
                buttonFullScreen.Enabled = false;
                panelControaleJoc.Enabled = false;
                t[m1].Start();
            }
        }

        private void t_Tick(object sender, EventArgs e, int m1, int wplus, int hplus , int wfinal , int hfinal)
        {
            if(nr_tick[m1] == 20)
            {
                t[m1].Enabled = false;
                if(nrTick >= 4)
                {
                    panelControaleJoc.Enabled = true;
                    buttonFullScreen.Enabled = true;
                }
                if(m1 == 1 && split >= 1)
                {
                    wjucatorSt = 20 + 35;
                    wjucatorDr = panelCarti.Width - 20 - pic[3].Width - 35;
                    GenerareCarte(m, wjucatorSt, hjucator, true, nrRandomCarte());
                    m++;
                    split++;
                    GenerareCarte(m, wjucatorDr, hjucator, true, nrRandomCarte());
                    m++;
                    split--;
                    textBoxSt.Visible = true;
                    labelSumaDr.Visible = true;
                    labelSumaSt.Visible = true;
                }
                esteGata = 1;
                return;
            }
            if (nr_tick[m1] == 19)
            {
                pic[m1].Location = new Point(wfinal, hfinal);
                nr_tick[m1]++;
                return;
            }
            esteGata = 0;
            int wp = pic[m1].Location.X, hp = pic[m1].Location.Y;
            pic[m1].Location = new Point(wp + wplus , hp + hplus);
            nr_tick[m1]++;
        }

        private void t_Tick_Stand(object sender, EventArgs e)
        {
            GenerareCarte(m, wdealer, hdealer, false, nrRandomCarte());
            m++;
            if (sumaDealer >= 17)
            {
                t[34].Stop();
                verificare();
                return;
            }
        }

        private void t_Tick_DoubleDown(object sender, EventArgs e)
        {
            if(nr_tick[33] == 1)
            {
                t[33].Stop();
                buttonStand.PerformClick();
                return;
            }
            nr_tick[33]++;
        }

        private int nrRandomCarte()
        {
            int nrcard = 0;
            do
            {
                nrcard = r.Next(1, 53);
            } while (viz[nrcard] == 1);
            viz[nrcard] = 1;
            return nrcard + pac*53;
        }

        private void buttonInsurance_Click(object sender, EventArgs e)
        {
            int nrcard = nrRandomCarte();

            SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
            conexiune.Open();
            SqlCommand selectare = new SqlCommand("SELECT poza_carte , valoare FROM ImaginiCarti1 WHERE Id_carte = '" + nrcard + "'", conexiune);
            SqlDataReader dr = selectare.ExecuteReader();
            int val = 0;
            if (dr.Read())
            {
                MemoryStream ms2 = new MemoryStream(dr.GetSqlBytes(0).Buffer);;
                val = Convert.ToInt32(dr[1]);
                if(val == 10)
                {
                    pic[2].Image = null;
                    pic[2].SizeMode = PictureBoxSizeMode.StretchImage;
                    pic[2].Image = Image.FromStream(ms2);
                    if (FormStart.VariabilePublice.romana == 1)
                    {
                        MessageBox.Show("Dealer-ul ARE BLACKJACK! Ai castigat " + 2 * sumaPariata);
                        labelRezultat.Text = "Ai castigat " + 2 * sumaPariata;
                    }
                    else
                    {
                        MessageBox.Show("The dealer HAS BLACKJACK! You won " + 2 * sumaPariata);
                        labelRezultat.Text = "You won " + 2 * sumaPariata;
                    }
                    AdaugaPuncte(2 * sumaPariata);
                    textBoxPariaza.ReadOnly = false;
                    panelControaleJoc.Visible = false;
                    panelBet.Visible = true;
                    buttonIncepe.Visible = true;
                    buttonInapoi.Visible = true;
                    return;
                }
                else
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Dealer-ul NU are BLACKJACK! Ai pierdut asiguranta de " + sumaPariata);
                    else
                        MessageBox.Show("The dealer has NO BLACKJACK! You lost the insurance of " + sumaPariata);
                    AdaugaPuncte(-sumaPariata);
                    buttonInsurance.Enabled = false;
                    insurance = 1;
                    nrCardInsurance = nrcard;
                    return;
                }
            }
            conexiune.Close();
            dr.Close();
            buttonInsurance.Enabled = false;
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            if (sumaPariata * 2 > Convert.ToInt32(textBoxPuncteTot.Text))
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Nu ai destui dolari!");
                else
                    MessageBox.Show("You don't have enough dolars!");
                return;
            }
            textBoxPariaza.Text = "" + sumaPariata * 2;
            buttonSplit.Enabled = false;
            buttonInsurance.Enabled = false;
            labelSuma.Visible = false;

            sumaPariataSt = sumaPariata;
            sumaPariataDr = sumaPariata;

            nr_tick[1] = 0;
            t[1] = new Timer();
            t[1].Interval = 40;
            int wplus = (20 - pic[1].Location.X) / 20, hplus = (hjucator - pic[1].Location.Y) / 20;
            t[1].Tick += delegate (object sender1, EventArgs e1)
            {
                t_Tick(sender1, e1, 1, wplus, hplus, 20, hjucator);
            };
            t[1].Start();

            nr_tick[3] = 0;
            t[3] = new Timer();
            t[3].Interval = 40;
            int wplus1 = (panelCarti.Width - 20 - pic[3].Width - pic[3].Location.X) / 20, hplus1 = (hjucator - pic[3].Location.Y) / 20;
            t[3].Tick += delegate (object sender1, EventArgs e1)
            {
                t_Tick(sender1, e1, 3, wplus1, hplus1, panelCarti.Width - 20 - pic[3].Width, hjucator);
            };
            t[3].Start();
            split++;
        }

        private void verificare()
        {
            if (sumaDealer > 21)
            {
                if (split == 0)
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Ai castigat " + sumaPariata;
                    else
                        labelRezultat.Text = "You won " + sumaPariata;
                    AdaugaPuncte(sumaPariata);
                }
                if (split > 0)
                {
                    int castig = 0;
                    if (sumaSt <= 21)
                    {
                        castig += sumaPariataSt;
                        AdaugaPuncte(sumaPariataSt);
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatSt.Text = "Ai castigat " + sumaPariataSt;
                        else
                            labelRezultatSt.Text = "You won " + sumaPariataSt;
                    }
                    else
                    {
                        castig -= sumaPariataSt;
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatSt.Text = "Ai pierdut " + sumaPariataSt;
                        else
                            labelRezultatSt.Text = "You lost " + sumaPariataSt;
                    }
                    if (sumaDr <= 21)
                    {
                        castig += sumaPariataDr;
                        AdaugaPuncte(sumaPariataDr);
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatDr.Text = "Ai castigat " + sumaPariataDr;
                        else
                            labelRezultatDr.Text = "You won " + sumaPariataDr;
                    }
                    else
                    {
                        castig -= sumaPariataDr;
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatDr.Text = "Ai pierdut " + sumaPariataDr;
                        else
                            labelRezultatDr.Text = "You lost " + sumaPariataDr;
                    }
                    if (castig == 0)
                    {
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultat.Text = "Egal";
                        else
                            labelRezultat.Text = "Tie";
                    }
                    else if (castig > 0)
                    {
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultat.Text = "Ai castigat " + castig;
                        else
                            labelRezultat.Text = "You won " + castig;
                    }
                    else
                    {
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultat.Text = "Ai pierdut " + -castig;
                        else
                            labelRezultat.Text = "You lost " + -castig;
                    }
                }
                textBoxPariaza.ReadOnly = false;
                labelRezultat.Visible = true;
                panelControaleJoc.Visible = false;
                buttonIncepe.Visible = true;
                buttonInapoi.Visible = true;
                return;
            }
            if (split == 0)
            {
                if (sumaDealer < sumaJucator)
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Ai castigat " + sumaPariata;
                    else
                        labelRezultat.Text = "You won " + sumaPariata;
                    AdaugaPuncte(sumaPariata);
                    labelRezultat.Visible = true;
                    panelControaleJoc.Visible = false;
                    textBoxPariaza.ReadOnly = false;
                    buttonIncepe.Visible = true;
                    buttonInapoi.Visible = true;
                    return;
                }
                if (sumaDealer > sumaJucator)
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Ai pierdut " + sumaPariata;
                    else
                        labelRezultat.Text = "You lost " + sumaPariata;
                    AdaugaPuncte(-sumaPariata);
                    labelRezultat.Visible = true;
                    panelControaleJoc.Visible = false;
                    textBoxPariaza.ReadOnly = false;
                    buttonIncepe.Visible = true;
                    buttonInapoi.Visible = true;
                    return;
                }
                if (sumaDealer == sumaJucator)
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Egal";
                    else
                        labelRezultat.Text = "Tie";
                    labelRezultat.Visible = true;
                    panelControaleJoc.Visible = false;
                    textBoxPariaza.ReadOnly = false;
                    buttonIncepe.Visible = true;
                    buttonInapoi.Visible = true;
                    return;
                }
            }
            if (split == 2)
            {

                int castig = 0;
                if (sumaSt <= 21)
                {
                    if (sumaDealer < sumaSt)
                    {
                        castig += sumaPariataSt;
                        AdaugaPuncte(sumaPariataSt);
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatSt.Text = "Ai castigat " + sumaPariataSt;
                        else
                            labelRezultatSt.Text = "You won " + sumaPariataSt;
                        labelRezultatSt.Visible = true;
                    }
                    else if (sumaDealer > sumaSt)
                    {
                        castig -= sumaPariataSt;
                        AdaugaPuncte(-sumaPariataSt);
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatSt.Text = "Ai pierdut " + sumaPariataSt;
                        else
                            labelRezultatSt.Text = "You lost " + sumaPariataSt;
                        labelRezultatSt.Visible = true;
                    }
                    else
                    {
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatSt.Text = "Egal";
                        else
                            labelRezultatSt.Text = "Tie";
                        labelRezultatSt.Visible = true;
                    }
                }
                else
                {
                    castig -= sumaPariataSt;
                    AdaugaPuncte(-sumaPariataSt);
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultatSt.Text = "Ai pierdut " + sumaPariataSt;
                    else
                        labelRezultatSt.Text = "You lost " + sumaPariataSt;
                    labelRezultatSt.Visible = true;
                }
                if (sumaDr <= 21)
                {
                    if (sumaDealer < sumaDr)
                    {
                        castig += sumaPariataDr;
                        AdaugaPuncte(sumaPariataDr);
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatDr.Text = "Ai castigat " + sumaPariataDr;
                        else
                            labelRezultatDr.Text = "You won " + sumaPariataDr;
                        labelRezultatDr.Visible = true;
                    }
                    else if (sumaDealer > sumaDr)
                    {
                        castig -= sumaPariataDr;
                        AdaugaPuncte(-sumaPariataDr);
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatDr.Text = "Ai pierdut " + sumaPariataDr;
                        else
                            labelRezultatDr.Text = "You lost " + sumaPariataDr;
                        labelRezultatDr.Visible = true;
                    }
                    else
                    {
                        if (FormStart.VariabilePublice.romana == 1)
                            labelRezultatDr.Text = "Egal";
                        else
                            labelRezultatDr.Text = "Tie";
                        labelRezultatDr.Visible = true;
                    }
                }
                else
                {
                    castig -= sumaPariataDr;
                    AdaugaPuncte(-sumaPariataDr);
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultatDr.Text = "Ai pierdut " + sumaPariataDr;
                    else
                        labelRezultatDr.Text = "You lost " + sumaPariataDr;
                    labelRezultatDr.Visible = true;
                }
                if (castig == 0)
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Egal";
                    else
                        labelRezultat.Text = "Tie";
                }
                else if (castig > 0)
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Ai castigat " + castig;
                    else
                        labelRezultat.Text = "You won " + castig;
                }
                else
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        labelRezultat.Text = "Ai pierdut " + -castig;
                    else
                        labelRezultat.Text = "You lost " + -castig;
                }
                textBoxPariaza.ReadOnly = false;
                labelRezultat.Visible = true;
                panelControaleJoc.Visible = false;
                buttonIncepe.Visible = true;
                buttonInapoi.Visible = true;
                return;
            }
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            if (split == 0 || split == 2)
            {
                panelControaleJoc.Visible = false;
                int val = 0;
                if (insurance == 0)
                {
                    int nrcard = nrRandomCarte();

                    SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
                    conexiune.Open();
                    SqlCommand selectare = new SqlCommand("SELECT poza_carte , valoare FROM ImaginiCarti1 WHERE Id_carte = '" + nrcard + "'", conexiune);
                    SqlDataReader dr = selectare.ExecuteReader();
                    if (dr.Read())
                    {
                        pic[2].Image = null;
                        MemoryStream ms = new MemoryStream(dr.GetSqlBytes(0).Buffer);
                        pic[2].SizeMode = PictureBoxSizeMode.StretchImage;
                        pic[2].Image = Image.FromStream(ms);
                        val = Convert.ToInt32(dr[1]);
                    }
                } 
                else
                {
                    SqlConnection conexiune = new SqlConnection(FormStart.VariabilePublice.connString);
                    conexiune.Open();
                    SqlCommand selectare = new SqlCommand("SELECT poza_carte , valoare FROM ImaginiCarti1 WHERE Id_carte = '" + nrCardInsurance + "'", conexiune);
                    SqlDataReader dr = selectare.ExecuteReader();
                    if (dr.Read())
                    {
                        pic[2].Image = null;
                        MemoryStream ms = new MemoryStream(dr.GetSqlBytes(0).Buffer);
                        pic[2].SizeMode = PictureBoxSizeMode.StretchImage;
                        pic[2].Image = Image.FromStream(ms);
                        val = Convert.ToInt32(dr[1]);
                    }
                }
                if (val == 11)
                {
                    nrAsiDealer++;
                }
                sumaDealer += val;
                if (sumaDealer > 21)
                {
                    if (nrAsiDealer > 0)
                    {
                        sumaDealer -= 10;
                        nrAsiDealer--;
                    }
                }
                labelSumaDealer.Text = "" + sumaDealer;

                if (sumaDealer < 17)
                {
                    t[34] = new Timer();
                    t[34].Interval = 1000;
                    t[34].Tick += new EventHandler(t_Tick_Stand);
                    t[34].Start();
                }
                else
                    verificare();
            }
            if(split == 1)
            {
                textBoxSt.Visible = false;
                textBoxDr.Visible = true;
                split = 2;
            }
        }

        private void buttonDouble_Click(object sender, EventArgs e)
        {
            if (split == 0)
            {
                if(sumaPariata*2>Convert.ToInt32(textBoxPuncteTot.Text))
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Nu ai destui dolari!");
                    else
                        MessageBox.Show("You don't have enough dolars!");
                    return;
                }    
                sumaPariata += sumaPariata;
                textBoxPariaza.Text = "" + sumaPariata;
                GenerareCarte(m, wjucator, hjucator, true, nrRandomCarte());
                m++;
            }
            if (split == 2)
            {
                if (sumaPariataDr * 2 > Convert.ToInt32(textBoxPuncteTot.Text))
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Nu ai destui dolari!");
                    else
                        MessageBox.Show("You don't have enough dolars!");
                    return;
                }
                sumaPariataDr += sumaPariataDr;
                textBoxPariaza.Text = "" + (sumaPariataDr + sumaPariataSt);
                GenerareCarte(m, wjucatorDr, hjucator, true, nrRandomCarte());
                m++;
            }
            if (split == 1)
            {
                if (sumaPariataSt * 2 > Convert.ToInt32(textBoxPuncteTot.Text))
                {
                    if (FormStart.VariabilePublice.romana == 1)
                        MessageBox.Show("Nu ai destui dolari!");
                    else
                        MessageBox.Show("You don't have enough dolars!");
                    return;
                }
                sumaPariataSt += sumaPariataSt;
                textBoxPariaza.Text = "" + (sumaPariataDr + sumaPariataSt);
                GenerareCarte(m, wjucatorSt, hjucator, true, nrRandomCarte());
                m++;
            }
            nr_tick[33] = 0;
            t[33] = new Timer();
            t[33].Interval = 750;
            t[33].Tick += new EventHandler(t_Tick_DoubleDown);
            t[33].Start();
        }

        public FormJoc()
        {
            InitializeComponent();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            FormMeciuJoc fm = new FormMeciuJoc();
            this.Hide();
            fm.ShowDialog();
        }

        private void buttonIncepe_Click(object sender, EventArgs e)
        {
            if (esteGata == 0)
                return;
            if (textBoxPariaza.Text == "" || textBoxPariaza.Text == "0")
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Introduceti o suma!");
                else
                    MessageBox.Show("Select your bet!");
                return;
            }

            if(Convert.ToInt32(textBoxPariaza.Text) > Convert.ToInt32(textBoxPuncteTot.Text))
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Nu ai destui dolari!");
                else
                    MessageBox.Show("You don't have enough dolars!");
                return;
            }
            for(int i = 0; i < m; i ++)
            {
                pic[i].Dispose();
                this.Controls.Remove(pic[i]);
                nr_tick[i] = 0;
                viz[i] = 0;
                this.components.Remove(t[i]);
            }
            if(textBoxPariaza.Text == "")
            {
                if (FormStart.VariabilePublice.romana == 1)
                    MessageBox.Show("Introdu suma pe care o pariezi");
                else
                    MessageBox.Show("Enter the amount you are betting");
                return;
            }
            try
            {
                sumaPariata = Convert.ToInt32(textBoxPariaza.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            split = 0;
            nrAsiDr = 0;
            nrAsiSt = 0;
            sumaDr = 0;
            sumaSt = 0;
            sumaPariataDr = 0;
            sumaPariataSt = 0;
            nrTick = 0;
            m = 0;
            wjucator = panelCarti.Width / 2 - 55;
            hjucator = panelCarti.Height / 5 * 4 - 40;
            wdealer = panelCarti.Width / 2 - 55;
            hdealer = 10;
            sumaJucator = 0;
            sumaDealer = 0;
            nrAsiJucator = 0;
            nrAsiDealer = 0;
            textBoxDr.Visible = false;
            textBoxSt.Visible = false;
            labelSumaDr.Visible = false;
            labelSumaSt.Visible = false;
            labelRezultatDr.Visible = false;
            labelRezultatSt.Visible = false;
            labelRezultat.Visible = false;
            labelSuma.Visible = true;
            labelSumaDealer.Visible = true;
            labelSuma.Text = "" + 0;
            labelSumaDealer.Text = "" + 0;

            panelControaleJoc.Visible = true;
            panelControaleJoc.Enabled = false;

            textBoxPariaza.ReadOnly = true;
            buttonSplit.Enabled = false;
            buttonInsurance.Enabled = false;
            buttonDouble.Enabled = true;
            buttonFullScreen.Enabled = false;

            buttonIncepe.Visible = false;
            buttonInapoi.Visible = false;

            pic = new PictureBox[35];
            t = new Timer[35];
            m = 0;

            GenerareCarte(m, 25, this.Height / 2 - 55, false, 53 + 53*pac);
            m++;
            wdealer -= 35;

            for (int i = 0; i <= 53; i++)
            {
                viz[i] = 0;
                nr_tick[i] = 0;
            }
            
            nrTick = 0;
            timerInceput.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerInceput_Tick(object sender, EventArgs e)
        {
            if(nrTick == 4)
            {
                timerInceput.Stop();
                buttonFullScreen.Enabled = true;
                buttonFullScreen.Enabled = true;
                panelControaleJoc.Enabled = true;
                return;
            }
            if (nrTick % 2 == 0)
            {
                
                GenerareCarte(m ,wjucator, hjucator, true, nrRandomCarte());
                m++;
                nrTick++;
                return;
            }
            if(nrTick == 3)
            {
                GenerareCarte(m ,wdealer, hdealer, false, nrRandomCarte());
                m++;
                nrTick++;
                return;
            }
            if(nrTick==1)
            {
                GenerareCarte(m, wdealer , hdealer, false, 53+53*pac);
                m++;
                nrTick++;
                return;
            }
        }
    }
}
