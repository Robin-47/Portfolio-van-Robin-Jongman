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
    public partial class dashboard : Form
    {
        public static dashboard Instance;
        public Label lab1;
        public dashboard()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // toont boekingen per vlucht
            List<Boekingen> boekingen = Boekingen.GetBoekingenPerVlucht();
            foreach (Boekingen b in boekingen)
            {
                boekingenPerVlucht.Items.Add(b);
            }

            // toont vrije stoelen
            List<Boekingen> stoelen = Boekingen.GetVrijeStoelenPerVlucht();
            foreach (Boekingen boek in stoelen)
            {
                stoelenPerVlucht.Items.Add(boek.vrijeStoelen());
            }
        }

        private void terugKnop_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.lab1.Text = lab1.Text;
            form1.Show();
            this.Hide();
        }
    }
}
