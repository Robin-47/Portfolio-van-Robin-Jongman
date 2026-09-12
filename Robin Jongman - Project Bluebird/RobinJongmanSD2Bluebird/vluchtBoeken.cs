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
    // Klasse voor het boeken van een vlucht
    public partial class vluchtBoeken : Form
    {
        public static vluchtBoeken Instance;
        public Label lab1;
        public Vluchten geselecteerdeVlucht;
        public vluchtBoeken()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
        }

        // Event handler voor het bijwerken
        private void klantenBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Laadt de passagiers en vluchten bij het openen van het formulier
        private void vluchtBoeken_Load(object sender, EventArgs e)
        {
            List<Passagiers> passengers = Passagiers.GetPassagiers();
            foreach (Passagiers p in passengers)
            {
                klantenBox.DataSource = passengers;
                klantenBox.DisplayMember = "PassengerDisplay";
                klantenBox.SelectedIndex = -1;

            }
            klantenBox.SelectedIndex = -1;

            List<Vluchten> flights = Vluchten.GetFlights();
            foreach (Vluchten f in flights)
            {
                vluchtBox.Items.Add(f);
            }
        }

        // Event handler voor het bijwerken
        private void stoelBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Event handler voor het bijwerken
        private void vluchtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vluchtBox.SelectedItem != null)
            {
                geselecteerdeVlucht = (Vluchten)vluchtBox.SelectedItem;

                stoelBox.Items.Clear();

                List<Stoelen> vrijeStoelen =
                    Stoelen.GetAvailableSeatsByFlight_SQL(geselecteerdeVlucht.id);

                foreach (Stoelen s in vrijeStoelen)
                {
                    stoelBox.Items.Add(s);
                }
            }
        }

        // Knop voor het invoeren
        private void invoerKnop_Click(object sender, EventArgs e)
        {
            if (klantenBox.SelectedItem == null ||
                vluchtBox.SelectedItem == null ||
                stoelBox.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst");
                return;
            }

            Passagiers p = (Passagiers)klantenBox.SelectedItem;
            Vluchten f = (Vluchten)vluchtBox.SelectedItem;
            Stoelen s = (Stoelen)stoelBox.SelectedItem;

            Boekingen.maakBoeking(f.id, p.id, s.seatId);

            MessageBox.Show("Boeking aangemaakt.");
        }

        // Nogmaals een knop om terug te gaan
        private void terugKnop_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }
    }
}
