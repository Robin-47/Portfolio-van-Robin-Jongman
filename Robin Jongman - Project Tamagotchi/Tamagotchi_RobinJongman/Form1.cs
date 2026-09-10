using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi_RobinJongman
{
    // Robin Jongman

    public partial class Form1 : Form
    {
        int score;

        public Form1()
        {
            InitializeComponent();
            Tamagotchi();
        }

        private void Tamagotchi()
        {
            // Stelt de timers in om 60 seconden actief te blijven
            timer1.Interval = 295;
            timer1.Tick += Timer1_Tick;

            timer2.Interval = 295;
            timer2.Tick += Timer2_Tick;

            timer3.Interval = 295;
            timer3.Tick += Timer3_Tick;

            // Stelt de minimum en maximum waarden van de progressbars in
            hongerBar.Minimum = 0;
            hongerBar.Maximum = 100;
            hongerBar.Value = 100;

            drinkBar.Minimum = 0;
            drinkBar.Maximum = 100;
            drinkBar.Value = 100;

            welzijnBar.Minimum = 0;
            welzijnBar.Maximum = 100;
            welzijnBar.Value = 100;

            // Stelt de beginwaarde van de labels in
            label1.Text = "Honger: 100";
            label2.Text = "Drink: 100";
            label3.Text = "Welzijn: 100";

            score = 0;
        }

        // Start de timers wanneer er op de Start-knop wordt geklikt
        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }
            catch
            {
                MessageBox.Show($"Fout bij het starten van de timers: ");
            }
        }

        // Voegt 5 toe aan de hongerbar wanneer er op de Eten-knop wordt geklikt
        private void eten_Click(object sender, EventArgs e)
        {
            try
            {
                hongerBar.Value = Math.Min(hongerBar.Value + 5, 100);
                Labels();
            }
            catch
            {
                MessageBox.Show($"Fout bij het verhogen van de hongerbar: ");
            }
        }

        // Voegt 5 toe aan de drinkbar wanneer er op de Drinken-knop wordt geklikt
        private void drinken_Click(object sender, EventArgs e)
        {
            try
            {
                drinkBar.Value = Math.Min(drinkBar.Value + 5, 100);
                Labels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij het verhogen van de drinkbar: {ex.Message}");
            }
        }

        // Verminderd de hongerbalk van timer1 met 1 per tik
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                hongerBar.Increment(-1);
            }
            catch
            {
                MessageBox.Show($"Fout bij het verminderen van de hongerbar: ");
            }
        }

        // Verminderd de drinkbalk van timer2 met 1 per tik
        private void Timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                drinkBar.Increment(-1);
            }
            catch
            {
                MessageBox.Show($"Fout bij het verminderen van de drinkbar: ");
            }
        }

        // Verminderd de welzijnsbalk van timer3 met 1 per tik
        private void Timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                // Zorgt ervoor dat de welzijnsbalk daalt met -1 als de hongerbar en drinkbar beide 0 zijn
                if (hongerBar.Value == 0 && drinkBar.Value == 0)
                {
                    welzijnBar.Value = Math.Max(welzijnBar.Value - 1, 0);
                }

                PictureBox();
                Labels();

                if (welzijnBar.Value == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    MessageBox.Show($"Tom is Overleden. Eindscore: {score}");
                    Application.Exit();
                }

                score++;
            }
            catch
            {
                MessageBox.Show($"Fout bij het bijwerken van de welzijnsbalk en score:");
            }
        }

        // Zorgt ervoor dat de afbeeldingen veranderen afhankelijk van het welzijn
        private void PictureBox()
        {
            if (welzijnBar.Value == 0)
            {
                pictureBox1.Image = Properties.Resources.dood;
            }
            else if (welzijnBar.Value < 25)
            {
                pictureBox1.Image = Properties.Resources.bijnaDood;
            }
            else if (welzijnBar.Value < 50)
            {
                pictureBox1.Image = Properties.Resources.nietGoed;
            }
            else if (welzijnBar.Value < 75)
            {
                pictureBox1.Image = Properties.Resources.redelijk;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.perfect;
            }
        }

        // Zorgt ervoor dat de labels geupdatet blijven
        private void Labels()
        {
            label1.Text = $"Honger: {hongerBar.Value}";
            label2.Text = $"Drink: {drinkBar.Value}";
            label3.Text = $"Welzijn: {welzijnBar.Value}";
        }
    }
}
