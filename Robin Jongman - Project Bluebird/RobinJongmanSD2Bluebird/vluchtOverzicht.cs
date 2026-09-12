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
    // Klasse voor het overzicht van vluchten en boekingen
    public partial class vluchtOverzicht : Form
    {
        public static vluchtOverzicht Instance;
        public Label lab1;
        public vluchtOverzicht()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
        }

        // Laadt vluchtgegeven in het overzicht en vult de filteropties
        private void vluchtOverzicht_Load(object sender, EventArgs e)
        {
            vluchtenData.DataSource = Vluchten.getBookingOverview();

            vluchtenData.Columns[0].HeaderText = "Voornaam";
            vluchtenData.Columns[1].HeaderText = "Achternaam";
            vluchtenData.Columns[2].HeaderText = "Stad";
            vluchtenData.Columns[3].HeaderText = "Email";
            vluchtenData.Columns[4].HeaderText = "Boeking datum";
            vluchtenData.Columns[5].HeaderText = "Status";
            vluchtenData.Columns[6].HeaderText = "Stoelnummer";
            vluchtenData.Columns[7].HeaderText = "Klasse";
            vluchtenData.Columns[8].HeaderText = "Raamplaats";
            vluchtenData.Columns[9].HeaderText = "Gangpad";

            vluchtenData.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";

            foreach (Vluchten statObj in Vluchten.GetStatus())
            {
                statusBox.Items.Add(statObj.bookingStatus.ToString());
            }

            foreach (Vluchten dateObj in Vluchten.GetDatum())
            {
                datumBox.Items.Add(dateObj.bookingDate.ToString("dd-MM-yyyy"));
            }
        }

        // Knop voor het tonen van gefilterde vluchtgegevens op basis van status en/of datum
        private void toonKnop_Click(object sender, EventArgs e)
        {
            string zoekStats = statusBox.Text;
            string zoekDatum = datumBox.Text;

            bool statusFilter = zoekStats != "" && zoekStats != "Alle";
            bool datumFilter = zoekDatum != "" && zoekDatum != "Alle";

            if (statusFilter && datumFilter)
            {
                DateTime gekozenDatum = DateTime.Parse(zoekDatum);
                vluchtenData.DataSource = Vluchten.zoekStatusEnDatum(zoekStats, gekozenDatum);
            }
            else if (statusFilter)
            {
                vluchtenData.DataSource = Vluchten.zoekStatus(zoekStats);
            }
            else if (datumFilter)
            {
                DateTime gekozenDatum = DateTime.Parse(zoekDatum);

                vluchtenData.DataSource = Vluchten.zoekDate(gekozenDatum);
            }
            else
            {
                vluchtenData.DataSource = Vluchten.getBookingOverview();
            }
        }

        // Knop voor het terugkeren naar het menu
        private void terugKnop_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }
    }
}
