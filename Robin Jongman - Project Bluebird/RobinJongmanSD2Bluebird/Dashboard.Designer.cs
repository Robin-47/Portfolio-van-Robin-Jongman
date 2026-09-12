namespace RobinJongmanSD2Bluebird
{
    partial class dashboard
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
            this.terugKnop = new System.Windows.Forms.Button();
            this.boekingenPerVlucht = new System.Windows.Forms.ListBox();
            this.stoelenPerVlucht = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(659, 12);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(129, 46);
            this.terugKnop.TabIndex = 1;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // boekingenPerVlucht
            // 
            this.boekingenPerVlucht.FormattingEnabled = true;
            this.boekingenPerVlucht.ItemHeight = 16;
            this.boekingenPerVlucht.Location = new System.Drawing.Point(16, 98);
            this.boekingenPerVlucht.Name = "boekingenPerVlucht";
            this.boekingenPerVlucht.Size = new System.Drawing.Size(309, 340);
            this.boekingenPerVlucht.TabIndex = 2;
            // 
            // stoelenPerVlucht
            // 
            this.stoelenPerVlucht.FormattingEnabled = true;
            this.stoelenPerVlucht.ItemHeight = 16;
            this.stoelenPerVlucht.Location = new System.Drawing.Point(350, 98);
            this.stoelenPerVlucht.Name = "stoelenPerVlucht";
            this.stoelenPerVlucht.Size = new System.Drawing.Size(309, 340);
            this.stoelenPerVlucht.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boekingen per Vlucht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrije Stoelen per Vlucht";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stoelenPerVlucht);
            this.Controls.Add(this.boekingenPerVlucht);
            this.Controls.Add(this.terugKnop);
            this.Controls.Add(this.label1);
            this.Name = "dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button terugKnop;
        private System.Windows.Forms.ListBox boekingenPerVlucht;
        private System.Windows.Forms.ListBox stoelenPerVlucht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}