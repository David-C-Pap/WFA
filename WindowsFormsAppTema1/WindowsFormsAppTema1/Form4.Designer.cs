namespace WindowsFormsAppTema1
{
    partial class Form4
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
            this.btn_arsenalAntrenor = new System.Windows.Forms.Button();
            this.btn_arsenalTitularii = new System.Windows.Forms.Button();
            this.btn_arsenalRezerve = new System.Windows.Forms.Button();
            this.lb_arsenalTitularii = new System.Windows.Forms.ListBox();
            this.lb_arsenalRezerve = new System.Windows.Forms.ListBox();
            this.btn_mutatitularArsenal = new System.Windows.Forms.Button();
            this.btn_mutarezervaArsenal = new System.Windows.Forms.Button();
            this.btn_clearArsenal = new System.Windows.Forms.Button();
            this.btn_arsenalBest = new System.Windows.Forms.Button();
            this.ArsenalTopPlayer_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_arsenalHighestValue = new System.Windows.Forms.TextBox();
            this.tb_arsenalTopPlayer = new System.Windows.Forms.TextBox();
            this.tb_afiseazaArsenalAntrenor = new System.Windows.Forms.TextBox();
            this.btn_pozaArsenal = new System.Windows.Forms.Button();
            this.arsenalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arsenalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_arsenalAntrenor
            // 
            this.btn_arsenalAntrenor.Location = new System.Drawing.Point(12, 27);
            this.btn_arsenalAntrenor.Name = "btn_arsenalAntrenor";
            this.btn_arsenalAntrenor.Size = new System.Drawing.Size(100, 31);
            this.btn_arsenalAntrenor.TabIndex = 0;
            this.btn_arsenalAntrenor.Text = "Arsenal_antrenor";
            this.btn_arsenalAntrenor.UseVisualStyleBackColor = true;
            this.btn_arsenalAntrenor.Click += new System.EventHandler(this.btn_arsenalAntrenor_Click);
            // 
            // btn_arsenalTitularii
            // 
            this.btn_arsenalTitularii.Location = new System.Drawing.Point(12, 90);
            this.btn_arsenalTitularii.Name = "btn_arsenalTitularii";
            this.btn_arsenalTitularii.Size = new System.Drawing.Size(100, 26);
            this.btn_arsenalTitularii.TabIndex = 1;
            this.btn_arsenalTitularii.Text = "Arsenal_titularii";
            this.btn_arsenalTitularii.UseVisualStyleBackColor = true;
            this.btn_arsenalTitularii.Click += new System.EventHandler(this.btn_arsenalTitularii_Click);
            // 
            // btn_arsenalRezerve
            // 
            this.btn_arsenalRezerve.Location = new System.Drawing.Point(148, 90);
            this.btn_arsenalRezerve.Name = "btn_arsenalRezerve";
            this.btn_arsenalRezerve.Size = new System.Drawing.Size(95, 26);
            this.btn_arsenalRezerve.TabIndex = 2;
            this.btn_arsenalRezerve.Text = "Arsenal_rezerve";
            this.btn_arsenalRezerve.UseVisualStyleBackColor = true;
            this.btn_arsenalRezerve.Click += new System.EventHandler(this.btn_arsenalRezerve_Click);
            // 
            // lb_arsenalTitularii
            // 
            this.lb_arsenalTitularii.FormattingEnabled = true;
            this.lb_arsenalTitularii.Location = new System.Drawing.Point(12, 125);
            this.lb_arsenalTitularii.Name = "lb_arsenalTitularii";
            this.lb_arsenalTitularii.Size = new System.Drawing.Size(100, 212);
            this.lb_arsenalTitularii.TabIndex = 3;
            // 
            // lb_arsenalRezerve
            // 
            this.lb_arsenalRezerve.FormattingEnabled = true;
            this.lb_arsenalRezerve.Location = new System.Drawing.Point(148, 125);
            this.lb_arsenalRezerve.Name = "lb_arsenalRezerve";
            this.lb_arsenalRezerve.Size = new System.Drawing.Size(95, 212);
            this.lb_arsenalRezerve.TabIndex = 4;
            // 
            // btn_mutatitularArsenal
            // 
            this.btn_mutatitularArsenal.Location = new System.Drawing.Point(12, 371);
            this.btn_mutatitularArsenal.Name = "btn_mutatitularArsenal";
            this.btn_mutatitularArsenal.Size = new System.Drawing.Size(88, 35);
            this.btn_mutatitularArsenal.TabIndex = 5;
            this.btn_mutatitularArsenal.Text = "Muta_titular";
            this.btn_mutatitularArsenal.UseVisualStyleBackColor = true;
            this.btn_mutatitularArsenal.Click += new System.EventHandler(this.btn_mutatitularArsenal_Click);
            // 
            // btn_mutarezervaArsenal
            // 
            this.btn_mutarezervaArsenal.Location = new System.Drawing.Point(148, 371);
            this.btn_mutarezervaArsenal.Name = "btn_mutarezervaArsenal";
            this.btn_mutarezervaArsenal.Size = new System.Drawing.Size(95, 35);
            this.btn_mutarezervaArsenal.TabIndex = 6;
            this.btn_mutarezervaArsenal.Text = "Muta_rezerva";
            this.btn_mutarezervaArsenal.UseVisualStyleBackColor = true;
            this.btn_mutarezervaArsenal.Click += new System.EventHandler(this.btn_mutarezervaArsenal_Click);
            // 
            // btn_clearArsenal
            // 
            this.btn_clearArsenal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_clearArsenal.Location = new System.Drawing.Point(12, 442);
            this.btn_clearArsenal.Name = "btn_clearArsenal";
            this.btn_clearArsenal.Size = new System.Drawing.Size(100, 50);
            this.btn_clearArsenal.TabIndex = 7;
            this.btn_clearArsenal.Text = "ClearArsenal";
            this.btn_clearArsenal.UseVisualStyleBackColor = false;
            this.btn_clearArsenal.Click += new System.EventHandler(this.btn_clearArsenal_Click);
            // 
            // btn_arsenalBest
            // 
            this.btn_arsenalBest.Location = new System.Drawing.Point(632, 23);
            this.btn_arsenalBest.Name = "btn_arsenalBest";
            this.btn_arsenalBest.Size = new System.Drawing.Size(107, 39);
            this.btn_arsenalBest.TabIndex = 8;
            this.btn_arsenalBest.Text = "Arsenal_TheBest";
            this.btn_arsenalBest.UseVisualStyleBackColor = true;
            this.btn_arsenalBest.Click += new System.EventHandler(this.btn_arsenalBest_Click);
            // 
            // ArsenalTopPlayer_label1
            // 
            this.ArsenalTopPlayer_label1.AutoSize = true;
            this.ArsenalTopPlayer_label1.Location = new System.Drawing.Point(539, 90);
            this.ArsenalTopPlayer_label1.Name = "ArsenalTopPlayer_label1";
            this.ArsenalTopPlayer_label1.Size = new System.Drawing.Size(96, 13);
            this.ArsenalTopPlayer_label1.TabIndex = 9;
            this.ArsenalTopPlayer_label1.Text = "Arsenal_TopPlayer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Arsenal_HighestValue";
            // 
            // tb_arsenalHighestValue
            // 
            this.tb_arsenalHighestValue.Location = new System.Drawing.Point(661, 118);
            this.tb_arsenalHighestValue.Name = "tb_arsenalHighestValue";
            this.tb_arsenalHighestValue.Size = new System.Drawing.Size(100, 20);
            this.tb_arsenalHighestValue.TabIndex = 11;
            // 
            // tb_arsenalTopPlayer
            // 
            this.tb_arsenalTopPlayer.Location = new System.Drawing.Point(661, 83);
            this.tb_arsenalTopPlayer.Name = "tb_arsenalTopPlayer";
            this.tb_arsenalTopPlayer.Size = new System.Drawing.Size(100, 20);
            this.tb_arsenalTopPlayer.TabIndex = 12;
            // 
            // tb_afiseazaArsenalAntrenor
            // 
            this.tb_afiseazaArsenalAntrenor.Location = new System.Drawing.Point(143, 42);
            this.tb_afiseazaArsenalAntrenor.Name = "tb_afiseazaArsenalAntrenor";
            this.tb_afiseazaArsenalAntrenor.Size = new System.Drawing.Size(100, 20);
            this.tb_afiseazaArsenalAntrenor.TabIndex = 13;
            // 
            // btn_pozaArsenal
            // 
            this.btn_pozaArsenal.Location = new System.Drawing.Point(542, 159);
            this.btn_pozaArsenal.Name = "btn_pozaArsenal";
            this.btn_pozaArsenal.Size = new System.Drawing.Size(102, 31);
            this.btn_pozaArsenal.TabIndex = 14;
            this.btn_pozaArsenal.Text = "Poza-Arsenal";
            this.btn_pozaArsenal.UseVisualStyleBackColor = true;
            this.btn_pozaArsenal.Click += new System.EventHandler(this.btn_pozaArsenal_Click);
            // 
            // arsenalPictureBox
            // 
            this.arsenalPictureBox.Location = new System.Drawing.Point(599, 213);
            this.arsenalPictureBox.Name = "arsenalPictureBox";
            this.arsenalPictureBox.Size = new System.Drawing.Size(162, 111);
            this.arsenalPictureBox.TabIndex = 15;
            this.arsenalPictureBox.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppTema1.Properties.Resources.Arsenal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 572);
            this.Controls.Add(this.arsenalPictureBox);
            this.Controls.Add(this.btn_pozaArsenal);
            this.Controls.Add(this.tb_afiseazaArsenalAntrenor);
            this.Controls.Add(this.tb_arsenalTopPlayer);
            this.Controls.Add(this.tb_arsenalHighestValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArsenalTopPlayer_label1);
            this.Controls.Add(this.btn_arsenalBest);
            this.Controls.Add(this.btn_clearArsenal);
            this.Controls.Add(this.btn_mutarezervaArsenal);
            this.Controls.Add(this.btn_mutatitularArsenal);
            this.Controls.Add(this.lb_arsenalRezerve);
            this.Controls.Add(this.lb_arsenalTitularii);
            this.Controls.Add(this.btn_arsenalRezerve);
            this.Controls.Add(this.btn_arsenalTitularii);
            this.Controls.Add(this.btn_arsenalAntrenor);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arsenalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_arsenalAntrenor;
        private System.Windows.Forms.Button btn_arsenalTitularii;
        private System.Windows.Forms.Button btn_arsenalRezerve;
        private System.Windows.Forms.ListBox lb_arsenalRezerve;
        private System.Windows.Forms.Button btn_mutatitularArsenal;
        private System.Windows.Forms.Button btn_mutarezervaArsenal;
        private System.Windows.Forms.Button btn_clearArsenal;
        private System.Windows.Forms.Button btn_arsenalBest;
        private System.Windows.Forms.Label ArsenalTopPlayer_label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_arsenalHighestValue;
        private System.Windows.Forms.TextBox tb_arsenalTopPlayer;
        private System.Windows.Forms.TextBox tb_afiseazaArsenalAntrenor;
        private System.Windows.Forms.Button btn_pozaArsenal;
        private System.Windows.Forms.PictureBox arsenalPictureBox;
        public System.Windows.Forms.ListBox lb_arsenalTitularii;
    }
}