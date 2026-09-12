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
    // Deze class is verantwoordelijk voor het aanpassen van passagiersgegevens
    public partial class passagier : Form
    {
        public static passagier Instance;
        public Label lab1;
        public passagier()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
            this.Load += new System.EventHandler(this.passagier_Load);
        }

        // Methode om passagiers te laden en weer te geven in de lijst
        private void loadPassagiers()
        {
            List<Passagiers> passagiers = Passagiers.GetPassagiers();
            passagierLijst.Items.Clear();
            foreach (Passagiers p in passagiers)
            {
                passagierLijst.Items.Add(p);
            }
        }

        // Laadt de passagiersgegevens bij het openen van het formulier
        private void passagier_Load(object sender, EventArgs e)
        {
            List<Passagiers> passagiers = Passagiers.GetPassagiers();
            foreach (Passagiers p in passagiers)
            {
                passagierLijst.Items.Add(p);
            }
        }

        // Methode om een nieuwe passagier toe te voegen aan de database
        private void toevoegKnop_Click(object sender, EventArgs e)
        {
            string voornaam = voornaamBox.Text;
            string achternaam = achternaamBox.Text;
            string address = adresBox.Text;
            string zipcode = postcodeBox.Text;
            string city = stadBox.Text;
            string email = emailBox.Text;
            string passport = paspoortBox.Text;

            Passagiers passengersObj = new Passagiers();
            passengersObj.firstname = voornaam;
            passengersObj.lastname = achternaam;
            passengersObj.address = address;
            passengersObj.zipCode = zipcode;
            passengersObj.city = city;
            passengersObj.email = email;
            passengersObj.passportNumber = passport;

            passengersObj.toevoegen();
            MessageBox.Show("Passagier toegevoegd.");

            loadPassagiers();
            voornaamBox.Clear();
            achternaamBox.Clear();
            adresBox.Clear();
            postcodeBox.Clear();
            stadBox.Clear();
            emailBox.Clear();
            paspoortBox.Clear();
        }

        // Nogmaals een knop voor het wijzigen
        private void wijzigKnop_Click(object sender, EventArgs e)
        {
            if (passagierLijst.SelectedItem != null)
            {
                Passagiers geselecteerdePassagier = (Passagiers)passagierLijst.SelectedItem;

                geselecteerdePassagier.firstname = voornaamBox.Text;
                geselecteerdePassagier.lastname = achternaamBox.Text;
                geselecteerdePassagier.address = adresBox.Text;
                geselecteerdePassagier.zipCode = postcodeBox.Text;
                geselecteerdePassagier.city = stadBox.Text;
                geselecteerdePassagier.email = emailBox.Text;
                geselecteerdePassagier.passportNumber = paspoortBox.Text;

                geselecteerdePassagier.Wijzigen();
                MessageBox.Show("Passagier gegevens gewijzigd.");

                loadPassagiers();
                voornaamBox.Clear();
                achternaamBox.Clear();
                adresBox.Clear();
                postcodeBox.Clear();
                stadBox.Clear();
                emailBox.Clear();
                paspoortBox.Clear();
            }
        }

        // Nogmaals een knop voor het verwijderen
        private void verwijderKnop_Click(object sender, EventArgs e)
        {
            if (passagierLijst.SelectedItem != null)
            {
                Passagiers geselecteerdePassagier = (Passagiers)passagierLijst.SelectedItem;

                geselecteerdePassagier.Verwijderen();

                MessageBox.Show($"{geselecteerdePassagier.firstname} {geselecteerdePassagier.lastname} is verwijderd.");

                loadPassagiers();
                voornaamBox.Clear();
                achternaamBox.Clear();
                adresBox.Clear();
                postcodeBox.Clear();
                stadBox.Clear();
                emailBox.Clear();
                paspoortBox.Clear();
            }

        }

        // Methode om de geselecteerde passagiergegevens weer te geven in de tekstvakken
        private void passagierLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (passagierLijst.SelectedItem != null)
            {
                Passagiers passagiers = (Passagiers)passagierLijst.SelectedItem;

                voornaamBox.Text = passagiers.firstname;
                achternaamBox.Text = passagiers.lastname;
                adresBox.Text = passagiers.address;
                postcodeBox.Text = passagiers.zipCode;
                stadBox.Text = passagiers.city;
                emailBox.Text = passagiers.email;
                paspoortBox.Text = passagiers.passportNumber;
            }
        }

        // Nog een knop om terug te gaan naar het menu
        private void terugKnop_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }
    }
}
