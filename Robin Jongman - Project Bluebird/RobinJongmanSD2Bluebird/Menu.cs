using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobinJongmanSD2Bluebird
{
    // Het menu waar de gebruiker naar de gewenste locatie kan navigeren
    public partial class Menu : Form
    {
        public static Menu Instance;
        public Label lab1;
        public Menu()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
            this.FormClosed += Menu_FormClosed;
        }

        // Sluit de applicatie wanneer het menu wordt gesloten
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Onderstaande knoppen navigeren naar de gewenste locaties
        private void boekKnop_Click(object sender, EventArgs e)
        {
            vluchtBoeken form3 = new vluchtBoeken();
            form3.lab1.Text = lab1.Text;
            form3.Show();
            this.Hide();
        }

        private void overzichtKnop_Click(object sender, EventArgs e)
        {
            vluchtOverzicht form1 = new vluchtOverzicht();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }

        private void passagiersKnop_Click(object sender, EventArgs e)
        {
            passagier form1 = new passagier();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }

        private void dashboardKnop_Click(object sender, EventArgs e)
        {
            dashboard form3 = new dashboard();
            form3.lab1.Text = lab1.Text;
            form3.Show();
            this.Hide();
        }

        private void gebruikersKnop_Click(object sender, EventArgs e)
        {
            gebruiker form3 = new gebruiker();
            form3.lab1.Text = lab1.Text;
            form3.Show();
            this.Hide();
        }

        private void uitlogKnop_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
