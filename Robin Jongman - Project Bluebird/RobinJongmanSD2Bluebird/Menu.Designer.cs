namespace RobinJongmanSD2Bluebird
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.boekKnop = new System.Windows.Forms.Button();
            this.overzichtKnop = new System.Windows.Forms.Button();
            this.passagiersKnop = new System.Windows.Forms.Button();
            this.dashboardKnop = new System.Windows.Forms.Button();
            this.gebruikersKnop = new System.Windows.Forms.Button();
            this.uitlogKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // boekKnop
            // 
            this.boekKnop.Location = new System.Drawing.Point(16, 55);
            this.boekKnop.Name = "boekKnop";
            this.boekKnop.Size = new System.Drawing.Size(161, 69);
            this.boekKnop.TabIndex = 1;
            this.boekKnop.Text = "Boek Vlucht";
            this.boekKnop.UseVisualStyleBackColor = true;
            this.boekKnop.Click += new System.EventHandler(this.boekKnop_Click);
            // 
            // overzichtKnop
            // 
            this.overzichtKnop.Location = new System.Drawing.Point(183, 55);
            this.overzichtKnop.Name = "overzichtKnop";
            this.overzichtKnop.Size = new System.Drawing.Size(161, 69);
            this.overzichtKnop.TabIndex = 2;
            this.overzichtKnop.Text = "Vlucht Overzicht";
            this.overzichtKnop.UseVisualStyleBackColor = true;
            this.overzichtKnop.Click += new System.EventHandler(this.overzichtKnop_Click);
            // 
            // passagiersKnop
            // 
            this.passagiersKnop.Location = new System.Drawing.Point(16, 153);
            this.passagiersKnop.Name = "passagiersKnop";
            this.passagiersKnop.Size = new System.Drawing.Size(161, 69);
            this.passagiersKnop.TabIndex = 3;
            this.passagiersKnop.Text = "Passagiers";
            this.passagiersKnop.UseVisualStyleBackColor = true;
            this.passagiersKnop.Click += new System.EventHandler(this.passagiersKnop_Click);
            // 
            // dashboardKnop
            // 
            this.dashboardKnop.Location = new System.Drawing.Point(183, 153);
            this.dashboardKnop.Name = "dashboardKnop";
            this.dashboardKnop.Size = new System.Drawing.Size(161, 69);
            this.dashboardKnop.TabIndex = 4;
            this.dashboardKnop.Text = "Dashboard";
            this.dashboardKnop.UseVisualStyleBackColor = true;
            this.dashboardKnop.Click += new System.EventHandler(this.dashboardKnop_Click);
            // 
            // gebruikersKnop
            // 
            this.gebruikersKnop.Location = new System.Drawing.Point(350, 55);
            this.gebruikersKnop.Name = "gebruikersKnop";
            this.gebruikersKnop.Size = new System.Drawing.Size(161, 69);
            this.gebruikersKnop.TabIndex = 5;
            this.gebruikersKnop.Text = "Gebruikers";
            this.gebruikersKnop.UseVisualStyleBackColor = true;
            this.gebruikersKnop.Click += new System.EventHandler(this.gebruikersKnop_Click);
            // 
            // uitlogKnop
            // 
            this.uitlogKnop.Location = new System.Drawing.Point(350, 153);
            this.uitlogKnop.Name = "uitlogKnop";
            this.uitlogKnop.Size = new System.Drawing.Size(161, 69);
            this.uitlogKnop.TabIndex = 6;
            this.uitlogKnop.Text = "Uitloggen";
            this.uitlogKnop.UseVisualStyleBackColor = true;
            this.uitlogKnop.Click += new System.EventHandler(this.uitlogKnop_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 292);
            this.Controls.Add(this.uitlogKnop);
            this.Controls.Add(this.gebruikersKnop);
            this.Controls.Add(this.dashboardKnop);
            this.Controls.Add(this.passagiersKnop);
            this.Controls.Add(this.overzichtKnop);
            this.Controls.Add(this.boekKnop);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boekKnop;
        private System.Windows.Forms.Button overzichtKnop;
        private System.Windows.Forms.Button passagiersKnop;
        private System.Windows.Forms.Button dashboardKnop;
        private System.Windows.Forms.Button gebruikersKnop;
        private System.Windows.Forms.Button uitlogKnop;
    }
}