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
    // Klasse voor het beheren van gebruikers
    public partial class gebruiker : Form
    {
        public static gebruiker Instance;
        public Label lab1;
        public gebruiker()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
            this.Load += new System.EventHandler(this.gebruiker_Load);
        }

        // Methode om gebruikers te laden en weer te geven in de lijst
        private void loadUser()
        {
            List<Users> users = Users.GetUsers();
            gebruikersLijst.Items.Clear();
            foreach (Users user in users)
            {
                gebruikersLijst.Items.Add(user);
            }
        }

        // Selecteert een gebruiker uit de lijst en vult de invoervelden
        private void gebruikersLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gebruikersLijst.SelectedItem != null)
            {
                Users user = (Users)gebruikersLijst.SelectedItem;

                voornaamBox.Text = user.Firstname;
                achternaamBox.Text = user.Lastname;
                emailBox.Text = user.Email;
                gebruikersBox.Text = user.Username;
            }
        }

        // Laadt de gebruikers wanneer het formulier wordt geopend
        private void gebruiker_Load(object sender, EventArgs e)
        {
            List<Users> users = Users.GetUsers();
            gebruikersLijst.Items.Clear();
            foreach (Users user in users)
            {
                gebruikersLijst.Items.Add(user);
            }
        }

        // Onderstaande knoppen voor het uitvoeren van taken
        private void terugKnop_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }

        private void toevoegKnop_Click(object sender, EventArgs e)
        {
            string voornaam = voornaamBox.Text;
            string achternaam = achternaamBox.Text;
            string email = emailBox.Text;
            string gebruikersnaam = gebruikersBox.Text;
            string wachtwoord = wachtwoordBox.Text;

            Users userObj = new Users();
            userObj.Firstname = voornaam;
            userObj.Lastname = achternaam;
            userObj.Email = email;
            userObj.Username = gebruikersnaam;

            userObj.Toevoegen(wachtwoord);

            MessageBox.Show("Gebruiker toegevoegd.");

            voornaamBox.Clear();
            achternaamBox.Clear();
            emailBox.Clear();
            gebruikersBox.Clear();
            wachtwoordBox.Clear();
            loadUser();
        }

        private void wijzigKnop_Click(object sender, EventArgs e)
        {
            string voornaam = voornaamBox.Text;
            string achternaam = achternaamBox.Text;
            string email = emailBox.Text;
            string gebruikersnaam = gebruikersBox.Text;
            string nieuwWachtwoord = wachtwoordBox.Text;

            Users userObj = ((Users)gebruikersLijst.SelectedItem);


            userObj.Firstname = voornaam;
            userObj.Lastname = achternaam;
            userObj.Email = email;
            userObj.Username = gebruikersnaam;
            userObj.Password = nieuwWachtwoord;

            if (string.IsNullOrEmpty(nieuwWachtwoord))
            {
                userObj.Wijzigen();
            }
            else
            {
                userObj.Wijzigen(nieuwWachtwoord);
            }

            MessageBox.Show("Gewijzigd.");
            loadUser();
            voornaamBox.Clear();
            achternaamBox.Clear();
            emailBox.Clear();
            gebruikersBox.Clear();
            wachtwoordBox.Clear();
        }

        private void verwijderKnop_Click(object sender, EventArgs e)
        {
            Users geselecteerdeGebruiker = (Users)gebruikersLijst.SelectedItem;

            if (geselecteerdeGebruiker.Id == Form1.HuidigeGebruiker.Id)
            {
                MessageBox.Show("Je kunt je eigen account niet verwijderen.");
            }
            else
            {
                geselecteerdeGebruiker.Verwijder();
                MessageBox.Show($"{geselecteerdeGebruiker.Firstname} {geselecteerdeGebruiker.Lastname} is verwijderd.");
                loadUser();
                voornaamBox.Clear();
                achternaamBox.Clear();
                emailBox.Clear();
                gebruikersBox.Clear();
                wachtwoordBox.Clear();
            }
        }
    }
}
