namespace Tamagotchi_RobinJongman
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drinkBar = new System.Windows.Forms.ProgressBar();
            this.hongerBar = new System.Windows.Forms.ProgressBar();
            this.welzijnBar = new System.Windows.Forms.ProgressBar();
            this.drinken = new System.Windows.Forms.Button();
            this.eten = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Tamagotchi_RobinJongman.Properties.Resources.perfect;
            this.pictureBox1.Location = new System.Drawing.Point(30, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "1";
            // 
            // drinkBar
            // 
            this.drinkBar.BackColor = System.Drawing.Color.Cyan;
            this.drinkBar.ForeColor = System.Drawing.Color.Red;
            this.drinkBar.Location = new System.Drawing.Point(551, 57);
            this.drinkBar.Name = "drinkBar";
            this.drinkBar.Size = new System.Drawing.Size(239, 23);
            this.drinkBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.drinkBar.TabIndex = 15;
            // 
            // hongerBar
            // 
            this.hongerBar.BackColor = System.Drawing.Color.Lime;
            this.hongerBar.Location = new System.Drawing.Point(30, 57);
            this.hongerBar.Name = "hongerBar";
            this.hongerBar.Size = new System.Drawing.Size(239, 23);
            this.hongerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hongerBar.TabIndex = 14;
            // 
            // welzijnBar
            // 
            this.welzijnBar.BackColor = System.Drawing.Color.Red;
            this.welzijnBar.Location = new System.Drawing.Point(286, 57);
            this.welzijnBar.Name = "welzijnBar";
            this.welzijnBar.Size = new System.Drawing.Size(239, 23);
            this.welzijnBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.welzijnBar.TabIndex = 13;
            // 
            // drinken
            // 
            this.drinken.BackColor = System.Drawing.Color.Transparent;
            this.drinken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drinken.BackgroundImage")));
            this.drinken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinken.Location = new System.Drawing.Point(562, 464);
            this.drinken.Name = "drinken";
            this.drinken.Size = new System.Drawing.Size(228, 67);
            this.drinken.TabIndex = 12;
            this.drinken.Text = "Drinken";
            this.drinken.UseVisualStyleBackColor = false;
            this.drinken.Click += new System.EventHandler(this.drinken_Click);
            // 
            // eten
            // 
            this.eten.BackColor = System.Drawing.Color.Transparent;
            this.eten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eten.BackgroundImage")));
            this.eten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eten.Location = new System.Drawing.Point(30, 464);
            this.eten.Name = "eten";
            this.eten.Size = new System.Drawing.Size(228, 67);
            this.eten.TabIndex = 11;
            this.eten.Text = "Eten";
            this.eten.UseVisualStyleBackColor = false;
            this.eten.Click += new System.EventHandler(this.eten_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(297, 464);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(228, 67);
            this.start.TabIndex = 10;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drinkBar);
            this.Controls.Add(this.hongerBar);
            this.Controls.Add(this.welzijnBar);
            this.Controls.Add(this.drinken);
            this.Controls.Add(this.eten);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tamagotchi Tom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar drinkBar;
        private System.Windows.Forms.ProgressBar hongerBar;
        private System.Windows.Forms.ProgressBar welzijnBar;
        private System.Windows.Forms.Button drinken;
        private System.Windows.Forms.Button eten;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
    }
}

