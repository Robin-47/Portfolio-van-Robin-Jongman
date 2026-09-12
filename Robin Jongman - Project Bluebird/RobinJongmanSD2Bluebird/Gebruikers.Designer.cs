namespace RobinJongmanSD2Bluebird
{
    partial class gebruiker
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
            this.gebruikersLijst = new System.Windows.Forms.ListBox();
            this.voornaamBox = new System.Windows.Forms.TextBox();
            this.achternaamBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.gebruikersBox = new System.Windows.Forms.TextBox();
            this.wachtwoordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toevoegKnop = new System.Windows.Forms.Button();
            this.wijzigKnop = new System.Windows.Forms.Button();
            this.verwijderKnop = new System.Windows.Forms.Button();
            this.terugKnop = new System.Windows.Forms.Button();
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
            // gebruikersLijst
            // 
            this.gebruikersLijst.FormattingEnabled = true;
            this.gebruikersLijst.ItemHeight = 16;
            this.gebruikersLijst.Location = new System.Drawing.Point(12, 53);
            this.gebruikersLijst.Name = "gebruikersLijst";
            this.gebruikersLijst.Size = new System.Drawing.Size(453, 372);
            this.gebruikersLijst.TabIndex = 1;
            this.gebruikersLijst.SelectedIndexChanged += new System.EventHandler(this.gebruikersLijst_SelectedIndexChanged);
            // 
            // voornaamBox
            // 
            this.voornaamBox.Location = new System.Drawing.Point(597, 118);
            this.voornaamBox.Name = "voornaamBox";
            this.voornaamBox.Size = new System.Drawing.Size(100, 22);
            this.voornaamBox.TabIndex = 2;
            // 
            // achternaamBox
            // 
            this.achternaamBox.Location = new System.Drawing.Point(597, 185);
            this.achternaamBox.Name = "achternaamBox";
            this.achternaamBox.Size = new System.Drawing.Size(100, 22);
            this.achternaamBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(597, 244);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 4;
            // 
            // gebruikersBox
            // 
            this.gebruikersBox.Location = new System.Drawing.Point(597, 308);
            this.gebruikersBox.Name = "gebruikersBox";
            this.gebruikersBox.Size = new System.Drawing.Size(100, 22);
            this.gebruikersBox.TabIndex = 5;
            // 
            // wachtwoordBox
            // 
            this.wachtwoordBox.Location = new System.Drawing.Point(597, 370);
            this.wachtwoordBox.Name = "wachtwoordBox";
            this.wachtwoordBox.Size = new System.Drawing.Size(100, 22);
            this.wachtwoordBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Voornaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gebruikersnaam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wachtwoord";
            // 
            // toevoegKnop
            // 
            this.toevoegKnop.Location = new System.Drawing.Point(487, 53);
            this.toevoegKnop.Name = "toevoegKnop";
            this.toevoegKnop.Size = new System.Drawing.Size(92, 44);
            this.toevoegKnop.TabIndex = 12;
            this.toevoegKnop.Text = "Toevoegen";
            this.toevoegKnop.UseVisualStyleBackColor = true;
            this.toevoegKnop.Click += new System.EventHandler(this.toevoegKnop_Click);
            // 
            // wijzigKnop
            // 
            this.wijzigKnop.Location = new System.Drawing.Point(585, 53);
            this.wijzigKnop.Name = "wijzigKnop";
            this.wijzigKnop.Size = new System.Drawing.Size(92, 44);
            this.wijzigKnop.TabIndex = 13;
            this.wijzigKnop.Text = "Wijzigen";
            this.wijzigKnop.UseVisualStyleBackColor = true;
            this.wijzigKnop.Click += new System.EventHandler(this.wijzigKnop_Click);
            // 
            // verwijderKnop
            // 
            this.verwijderKnop.Location = new System.Drawing.Point(683, 53);
            this.verwijderKnop.Name = "verwijderKnop";
            this.verwijderKnop.Size = new System.Drawing.Size(92, 44);
            this.verwijderKnop.TabIndex = 14;
            this.verwijderKnop.Text = "Verwijderen";
            this.verwijderKnop.UseVisualStyleBackColor = true;
            this.verwijderKnop.Click += new System.EventHandler(this.verwijderKnop_Click);
            // 
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(683, 3);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(92, 44);
            this.terugKnop.TabIndex = 15;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.terugKnop);
            this.Controls.Add(this.verwijderKnop);
            this.Controls.Add(this.wijzigKnop);
            this.Controls.Add(this.toevoegKnop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wachtwoordBox);
            this.Controls.Add(this.gebruikersBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.achternaamBox);
            this.Controls.Add(this.voornaamBox);
            this.Controls.Add(this.gebruikersLijst);
            this.Controls.Add(this.label1);
            this.Name = "gebruiker";
            this.Text = "Gebruikers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox gebruikersLijst;
        private System.Windows.Forms.TextBox voornaamBox;
        private System.Windows.Forms.TextBox achternaamBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox gebruikersBox;
        private System.Windows.Forms.TextBox wachtwoordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button toevoegKnop;
        private System.Windows.Forms.Button wijzigKnop;
        private System.Windows.Forms.Button verwijderKnop;
        private System.Windows.Forms.Button terugKnop;
    }
}