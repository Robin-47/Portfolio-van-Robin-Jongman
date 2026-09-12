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
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public static Users HuidigeGebruiker;
        public string tb1;
        string voornaam = "";
        string achternaam = "";
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BCrypt om het wachtwoord te hashen
            string wachtwoordHash = BCrypt.Net.BCrypt.EnhancedHashPassword("Eva@123");
            string gebruikersnaam = gebruikerBox.Text;
            string wachtwoord = wachtwoordBox.Text;
            bool isMatch = BCrypt.Net.BCrypt.EnhancedVerify("Eva@123", "$2a$11$r25WNV1/WZ3G.splrs/AaeQSrL/YbNoXalTGQpoX4KoST1BQg.3dC");

            Users gebruikersobject = Users.getLoginGebruiker(gebruikersnaam, wachtwoord);
            if (gebruikersobject != null)
            {
                // Laat de gebruiker inloggen
                HuidigeGebruiker = gebruikersobject;
                voornaam = gebruikersobject.Firstname;
                achternaam = gebruikersobject.Lastname;
                Menu form2 = new Menu();
                form2.lab1.Text = "Welkom " + voornaam + " " + achternaam + "!";
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ongeldige inlog");
            }
        }
    }
}
