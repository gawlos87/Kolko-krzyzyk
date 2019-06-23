using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool ruch = true;
        int remis = 0;
        bool SI = false;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Michał Gawlik", "Kółko i krzyżyk");
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruch = true;
            remis = 0;


            foreach (var item in Controls)
            {
                try
                {
                    Button button = (Button)item;
                    button.Text = "";
                    button.Enabled = true;
                }
                catch
                {

                }
            }

        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (ruch)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            ruch = !ruch;

            b.Enabled = false;

            remis++;

            spradzWygrana();

            if ((!ruch) && (SI))
            {
                ruch_SI();
            }
        }

        private void spradzWygrana()
        {
            bool warunkiWygranej = false;

            //wiersze
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (a1.Text != ""))
                warunkiWygranej = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                warunkiWygranej = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                warunkiWygranej = true;
            //kolumny
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                warunkiWygranej = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                warunkiWygranej = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                warunkiWygranej = true;
            //przekatne
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                warunkiWygranej = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
                warunkiWygranej = true;

            if (warunkiWygranej)
            {
                dezaktywujPrzyciski();

                var wygrany = "";
                if (ruch)
                {
                    wygrany = gracz2.Text;
                    oCount.Text = (Int32.Parse(oCount.Text) + 1).ToString();
                }
                else
                {
                    wygrany = gracz1.Text;
                    xCount.Text = (Int32.Parse(xCount.Text) + 1).ToString();
                }
                MessageBox.Show("Wygrał: " + wygrany);
            }
            else
            {
                if (remis == 9)
                {
                    remisCount.Text = (Int32.Parse(remisCount.Text) + 1).ToString();
                    MessageBox.Show("Remis!", "Kółko i krzyżyk");
                }

            }

        }

        private void dezaktywujPrzyciski()
        {
            foreach (var item in Controls)
            {
                try
                {

                    Button button = (Button)item;
                    button.Enabled = false;
                }
                catch
                {

                }
            }


        }

        private void onMouseEnterButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (ruch)
                    button.Text = "X";
                else
                    button.Text = "O";
            }

        }

        private void onMouseLeaveButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
                button.Text = "";
        }

        private void resetujWynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCount.Text = "0";
            oCount.Text = "0";
            remisCount.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Gracz2_TextChanged(object sender, EventArgs e)

        {
            if (gracz2.Text == "SI")
            {
                SI = true;
            }
            else SI = false;
        }

        private void ruch_SI()
        {

        }
    }
}
