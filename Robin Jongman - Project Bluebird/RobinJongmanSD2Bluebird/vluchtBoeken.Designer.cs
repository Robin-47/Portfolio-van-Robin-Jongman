namespace RobinJongmanSD2Bluebird
{
    partial class vluchtBoeken
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
            this.klantenBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vluchtBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stoelBox = new System.Windows.Forms.ListBox();
            this.invoerKnop = new System.Windows.Forms.Button();
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
            // klantenBox
            // 
            this.klantenBox.FormattingEnabled = true;
            this.klantenBox.Location = new System.Drawing.Point(132, 54);
            this.klantenBox.Name = "klantenBox";
            this.klantenBox.Size = new System.Drawing.Size(121, 24);
            this.klantenBox.TabIndex = 1;
            this.klantenBox.SelectedIndexChanged += new System.EventHandler(this.klantenBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecteer Klant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vluchten Overzicht";
            // 
            // vluchtBox
            // 
            this.vluchtBox.FormattingEnabled = true;
            this.vluchtBox.ItemHeight = 16;
            this.vluchtBox.Location = new System.Drawing.Point(185, 124);
            this.vluchtBox.Name = "vluchtBox";
            this.vluchtBox.Size = new System.Drawing.Size(414, 148);
            this.vluchtBox.TabIndex = 4;
            this.vluchtBox.SelectedIndexChanged += new System.EventHandler(this.vluchtBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Beschikbare Stoelen *Per Vlucht";
            // 
            // stoelBox
            // 
            this.stoelBox.FormattingEnabled = true;
            this.stoelBox.ItemHeight = 16;
            this.stoelBox.Location = new System.Drawing.Point(185, 358);
            this.stoelBox.Name = "stoelBox";
            this.stoelBox.Size = new System.Drawing.Size(414, 148);
            this.stoelBox.TabIndex = 6;
            this.stoelBox.SelectedIndexChanged += new System.EventHandler(this.stoelBox_SelectedIndexChanged);
            // 
            // invoerKnop
            // 
            this.invoerKnop.Location = new System.Drawing.Point(636, 411);
            this.invoerKnop.Name = "invoerKnop";
            this.invoerKnop.Size = new System.Drawing.Size(130, 55);
            this.invoerKnop.TabIndex = 7;
            this.invoerKnop.Text = "Invoeren";
            this.invoerKnop.UseVisualStyleBackColor = true;
            this.invoerKnop.Click += new System.EventHandler(this.invoerKnop_Click);
            // 
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(619, 36);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(147, 42);
            this.terugKnop.TabIndex = 8;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // vluchtBoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.terugKnop);
            this.Controls.Add(this.invoerKnop);
            this.Controls.Add(this.stoelBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vluchtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.klantenBox);
            this.Controls.Add(this.label1);
            this.Name = "vluchtBoeken";
            this.Text = "Boek Vlucht";
            this.Load += new System.EventHandler(this.vluchtBoeken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox klantenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox vluchtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox stoelBox;
        private System.Windows.Forms.Button invoerKnop;
        private System.Windows.Forms.Button terugKnop;
    }
}