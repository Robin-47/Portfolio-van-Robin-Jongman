namespace RobinJongmanSD2Bluebird
{
    partial class vluchtOverzicht
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
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.datumBox = new System.Windows.Forms.ComboBox();
            this.vluchtenData = new System.Windows.Forms.DataGridView();
            this.toonKnop = new System.Windows.Forms.Button();
            this.terugKnop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vluchtenData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(16, 57);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 24);
            this.statusBox.TabIndex = 1;
            // 
            // datumBox
            // 
            this.datumBox.FormattingEnabled = true;
            this.datumBox.Location = new System.Drawing.Point(212, 57);
            this.datumBox.Name = "datumBox";
            this.datumBox.Size = new System.Drawing.Size(121, 24);
            this.datumBox.TabIndex = 2;
            // 
            // vluchtenData
            // 
            this.vluchtenData.AllowUserToOrderColumns = true;
            this.vluchtenData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vluchtenData.Location = new System.Drawing.Point(16, 105);
            this.vluchtenData.Name = "vluchtenData";
            this.vluchtenData.RowHeadersWidth = 51;
            this.vluchtenData.RowTemplate.Height = 24;
            this.vluchtenData.Size = new System.Drawing.Size(704, 309);
            this.vluchtenData.TabIndex = 3;
            // 
            // toonKnop
            // 
            this.toonKnop.Location = new System.Drawing.Point(465, 57);
            this.toonKnop.Name = "toonKnop";
            this.toonKnop.Size = new System.Drawing.Size(75, 24);
            this.toonKnop.TabIndex = 4;
            this.toonKnop.Text = "Toon";
            this.toonKnop.UseVisualStyleBackColor = true;
            this.toonKnop.Click += new System.EventHandler(this.toonKnop_Click);
            // 
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(697, 9);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(91, 39);
            this.terugKnop.TabIndex = 5;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boeking Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Boeking Datum";
            // 
            // vluchtOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.terugKnop);
            this.Controls.Add(this.toonKnop);
            this.Controls.Add(this.vluchtenData);
            this.Controls.Add(this.datumBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Name = "vluchtOverzicht";
            this.Text = "Vlucht Overzicht";
            this.Load += new System.EventHandler(this.vluchtOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vluchtenData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.ComboBox datumBox;
        private System.Windows.Forms.DataGridView vluchtenData;
        private System.Windows.Forms.Button toonKnop;
        private System.Windows.Forms.Button terugKnop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}