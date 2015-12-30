using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            iskoriscenaSlova.Add((Button)sender);

            DocrtajCicaglisu();

            if (brojPromasaja == BROJ_POKUSAJA)
            {
                Console.WriteLine("GAME OVER");

                //generalPanel.Enabled = false;
                keyboardPanel.Enabled = false;
            }

        }


        private void DocrtajCicaglisu()
        {
            brojPromasaja++;

            switch (brojPromasaja)
            {
                case 1:
                    this.slika.Image = global::Hangman.Properties.Resources._1;
                    break;
                case 2:
                    this.slika.Image = global::Hangman.Properties.Resources._2;
                    break;
                case 3:
                    this.slika.Image = global::Hangman.Properties.Resources._3;
                    break;
                case 4:
                    this.slika.Image = global::Hangman.Properties.Resources._4;
                    break;
                case 5:
                    this.slika.Image = global::Hangman.Properties.Resources._5;
                    break;
                case 6:
                    this.slika.Image = global::Hangman.Properties.Resources._6;
                    break;
                    // baci exception mozda
            }
        }


        private void GameForm_FormClosing(object sender, FormClosingEventArgs e) //FormClosingEventArgs
        {
            if (MessageBox.Show("Da li želite da završite igru?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return;
            else
                ((FormClosingEventArgs)e).Cancel = true;
        }


        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // krece nova igra

            // aktivira sva dugmad
            if (iskoriscenaSlova.Count > 0)
            {
                iskoriscenaSlova.ForEach(AktivirajDugme);
                iskoriscenaSlova.Clear();
            }
            // nova rec

            // resetovanje promasaja i glise
            this.slika.Image = global::Hangman.Properties.Resources._0;
            brojPromasaja = 0;

            // aktiviraj tastere (slova)
            keyboardPanel.Enabled = true;
        }


        private static void AktivirajDugme(Button b)
        {
            b.Enabled = true;
        }





        private int brojPromasaja = 0;
        private const int BROJ_POKUSAJA = 6;
        private List<Button> iskoriscenaSlova = new List<Button>();
    }
}
