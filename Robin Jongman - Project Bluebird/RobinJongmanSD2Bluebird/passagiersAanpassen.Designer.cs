namespace RobinJongmanSD2Bluebird
{
    partial class passagier
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
            this.voornaamBox = new System.Windows.Forms.TextBox();
            this.achternaamBox = new System.Windows.Forms.TextBox();
            this.adresBox = new System.Windows.Forms.TextBox();
            this.postcodeBox = new System.Windows.Forms.TextBox();
            this.stadBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.paspoortBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passagierLijst = new System.Windows.Forms.ListBox();
            this.toevoegKnop = new System.Windows.Forms.Button();
            this.wijzigKnop = new System.Windows.Forms.Button();
            this.verwijderKnop = new System.Windows.Forms.Button();
            this.terugKnop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voornaamBox
            // 
            this.voornaamBox.Location = new System.Drawing.Point(661, 62);
            this.voornaamBox.Name = "voornaamBox";
            this.voornaamBox.Size = new System.Drawing.Size(100, 22);
            this.voornaamBox.TabIndex = 0;
            // 
            // achternaamBox
            // 
            this.achternaamBox.Location = new System.Drawing.Point(661, 104);
            this.achternaamBox.Name = "achternaamBox";
            this.achternaamBox.Size = new System.Drawing.Size(100, 22);
            this.achternaamBox.TabIndex = 1;
            // 
            // adresBox
            // 
            this.adresBox.Location = new System.Drawing.Point(661, 150);
            this.adresBox.Name = "adresBox";
            this.adresBox.Size = new System.Drawing.Size(100, 22);
            this.adresBox.TabIndex = 2;
            // 
            // postcodeBox
            // 
            this.postcodeBox.Location = new System.Drawing.Point(661, 204);
            this.postcodeBox.Name = "postcodeBox";
            this.postcodeBox.Size = new System.Drawing.Size(100, 22);
            this.postcodeBox.TabIndex = 3;
            // 
            // stadBox
            // 
            this.stadBox.Location = new System.Drawing.Point(661, 260);
            this.stadBox.Name = "stadBox";
            this.stadBox.Size = new System.Drawing.Size(100, 22);
            this.stadBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(661, 315);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 5;
            // 
            // paspoortBox
            // 
            this.paspoortBox.Location = new System.Drawing.Point(661, 366);
            this.paspoortBox.Name = "paspoortBox";
            this.paspoortBox.Size = new System.Drawing.Size(100, 22);
            this.paspoortBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // passagierLijst
            // 
            this.passagierLijst.FormattingEnabled = true;
            this.passagierLijst.ItemHeight = 16;
            this.passagierLijst.Location = new System.Drawing.Point(16, 51);
            this.passagierLijst.Name = "passagierLijst";
            this.passagierLijst.Size = new System.Drawing.Size(458, 276);
            this.passagierLijst.TabIndex = 8;
            this.passagierLijst.SelectedIndexChanged += new System.EventHandler(this.passagierLijst_SelectedIndexChanged);
            // 
            // toevoegKnop
            // 
            this.toevoegKnop.Location = new System.Drawing.Point(12, 367);
            this.toevoegKnop.Name = "toevoegKnop";
            this.toevoegKnop.Size = new System.Drawing.Size(135, 45);
            this.toevoegKnop.TabIndex = 9;
            this.toevoegKnop.Text = "Toevoegen";
            this.toevoegKnop.UseVisualStyleBackColor = true;
            this.toevoegKnop.Click += new System.EventHandler(this.toevoegKnop_Click);
            // 
            // wijzigKnop
            // 
            this.wijzigKnop.Location = new System.Drawing.Point(182, 367);
            this.wijzigKnop.Name = "wijzigKnop";
            this.wijzigKnop.Size = new System.Drawing.Size(135, 45);
            this.wijzigKnop.TabIndex = 10;
            this.wijzigKnop.Text = "Wijzigen";
            this.wijzigKnop.UseVisualStyleBackColor = true;
            this.wijzigKnop.Click += new System.EventHandler(this.wijzigKnop_Click);
            // 
            // verwijderKnop
            // 
            this.verwijderKnop.Location = new System.Drawing.Point(339, 367);
            this.verwijderKnop.Name = "verwijderKnop";
            this.verwijderKnop.Size = new System.Drawing.Size(135, 45);
            this.verwijderKnop.TabIndex = 11;
            this.verwijderKnop.Text = "Verwijderen";
            this.verwijderKnop.UseVisualStyleBackColor = true;
            this.verwijderKnop.Click += new System.EventHandler(this.verwijderKnop_Click);
            // 
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(661, 12);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(127, 34);
            this.terugKnop.TabIndex = 12;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Voornaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Paspoortnummer";
            // 
            // passagier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.terugKnop);
            this.Controls.Add(this.verwijderKnop);
            this.Controls.Add(this.wijzigKnop);
            this.Controls.Add(this.toevoegKnop);
            this.Controls.Add(this.passagierLijst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paspoortBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.stadBox);
            this.Controls.Add(this.postcodeBox);
            this.Controls.Add(this.adresBox);
            this.Controls.Add(this.achternaamBox);
            this.Controls.Add(this.voornaamBox);
            this.Name = "passagier";
            this.Text = "Aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voornaamBox;
        private System.Windows.Forms.TextBox achternaamBox;
        private System.Windows.Forms.TextBox adresBox;
        private System.Windows.Forms.TextBox postcodeBox;
        private System.Windows.Forms.TextBox stadBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox paspoortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox passagierLijst;
        private System.Windows.Forms.Button toevoegKnop;
        private System.Windows.Forms.Button wijzigKnop;
        private System.Windows.Forms.Button verwijderKnop;
        private System.Windows.Forms.Button terugKnop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}