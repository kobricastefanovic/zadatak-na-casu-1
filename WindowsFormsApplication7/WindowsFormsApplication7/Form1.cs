using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
        public partial class Form1 : Form
        {
            // Računar ovde pamti zamišljeni broj i broj pokušaja
            int trazeniBroj = 42;
            int brojPokusaja = 0;

            public Form1()
            {
                InitializeComponent();
            }

            // Ovo se pokreće i na klik dugmeta I na pritisak tastera Enter!
            private void button1_Click_1(object sender, EventArgs e)
            {
                // Ako je polje prazno, ne radi ništa da se program ne ugasi
                if (textBox1.Text == "")
                {
                    return;
                }

                // Pretvaramo tekst iz textboxa u broj
                int unetiBroj = Convert.ToInt32(textBox1.Text);

                // Povećavamo broj pokušaja za 1 i ispisujemo na formu
                brojPokusaja = brojPokusaja + 1;
                BrPokusaja.Text = Convert.ToString(brojPokusaja);

                // Provera broja
                if (unetiBroj < trazeniBroj)
                {
                    Komentar.Text = "Traženi broj je VEĆI!";
                }
                else if (unetiBroj > trazeniBroj)
                {
                    Komentar.Text = "Traženi broj je MANJI!";
                }
                else
                {
                    Komentar.Text = "POGODAK!";
                    MessageBox.Show("Bravo! Pogodili ste broj!");
                }

                // Brišemo stari broj iz kućice da možeš odmah da kucaš novi
                textBox1.Text = "";
            }
        }
    }
