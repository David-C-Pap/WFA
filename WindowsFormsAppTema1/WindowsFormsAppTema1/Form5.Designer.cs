namespace WindowsFormsAppTema1
{
    partial class Form5
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
            this.btn_antrenorCity = new System.Windows.Forms.Button();
            this.tb_antrenorCity = new System.Windows.Forms.TextBox();
            this.lb_portari = new System.Windows.Forms.ListBox();
            this.lb_fundasi = new System.Windows.Forms.ListBox();
            this.lb_mijlocasiAndAtacanti = new System.Windows.Forms.ListBox();
            this.btn_afiseazaLot = new System.Windows.Forms.Button();
            this.btn_adaugaPlayer = new System.Windows.Forms.Button();
            this.NumeJucator_label = new System.Windows.Forms.Label();
            this.Pozitie_label = new System.Windows.Forms.Label();
            this.tb_numeJucator = new System.Windows.Forms.TextBox();
            this.tb_pozitie = new System.Windows.Forms.TextBox();
            this.btn_clearCity = new System.Windows.Forms.Button();
            this.btn_clearInregistrare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_antrenorCity
            // 
            this.btn_antrenorCity.Location = new System.Drawing.Point(34, 29);
            this.btn_antrenorCity.Name = "btn_antrenorCity";
            this.btn_antrenorCity.Size = new System.Drawing.Size(85, 30);
            this.btn_antrenorCity.TabIndex = 0;
            this.btn_antrenorCity.Text = "City_Antrenor";
            this.btn_antrenorCity.UseVisualStyleBackColor = true;
            this.btn_antrenorCity.Click += new System.EventHandler(this.btn_antrenorCity_Click);
            // 
            // tb_antrenorCity
            // 
            this.tb_antrenorCity.Location = new System.Drawing.Point(139, 29);
            this.tb_antrenorCity.Name = "tb_antrenorCity";
            this.tb_antrenorCity.Size = new System.Drawing.Size(100, 20);
            this.tb_antrenorCity.TabIndex = 1;
            // 
            // lb_portari
            // 
            this.lb_portari.FormattingEnabled = true;
            this.lb_portari.Location = new System.Drawing.Point(12, 88);
            this.lb_portari.Name = "lb_portari";
            this.lb_portari.Size = new System.Drawing.Size(120, 160);
            this.lb_portari.TabIndex = 2;
            // 
            // lb_fundasi
            // 
            this.lb_fundasi.FormattingEnabled = true;
            this.lb_fundasi.Location = new System.Drawing.Point(12, 267);
            this.lb_fundasi.Name = "lb_fundasi";
            this.lb_fundasi.Size = new System.Drawing.Size(120, 160);
            this.lb_fundasi.TabIndex = 3;
            // 
            // lb_mijlocasiAndAtacanti
            // 
            this.lb_mijlocasiAndAtacanti.FormattingEnabled = true;
            this.lb_mijlocasiAndAtacanti.Location = new System.Drawing.Point(630, 88);
            this.lb_mijlocasiAndAtacanti.Name = "lb_mijlocasiAndAtacanti";
            this.lb_mijlocasiAndAtacanti.Size = new System.Drawing.Size(120, 160);
            this.lb_mijlocasiAndAtacanti.TabIndex = 4;
            // 
            // btn_afiseazaLot
            // 
            this.btn_afiseazaLot.BackColor = System.Drawing.Color.Aqua;
            this.btn_afiseazaLot.Location = new System.Drawing.Point(12, 457);
            this.btn_afiseazaLot.Name = "btn_afiseazaLot";
            this.btn_afiseazaLot.Size = new System.Drawing.Size(91, 27);
            this.btn_afiseazaLot.TabIndex = 5;
            this.btn_afiseazaLot.Text = "Afiseaza_Lot";
            this.btn_afiseazaLot.UseVisualStyleBackColor = false;
            this.btn_afiseazaLot.Click += new System.EventHandler(this.btn_afiseazaLot_Click);
            // 
            // btn_adaugaPlayer
            // 
            this.btn_adaugaPlayer.BackColor = System.Drawing.Color.Aqua;
            this.btn_adaugaPlayer.Location = new System.Drawing.Point(606, 352);
            this.btn_adaugaPlayer.Name = "btn_adaugaPlayer";
            this.btn_adaugaPlayer.Size = new System.Drawing.Size(88, 23);
            this.btn_adaugaPlayer.TabIndex = 6;
            this.btn_adaugaPlayer.Text = "Adauga_player";
            this.btn_adaugaPlayer.UseVisualStyleBackColor = false;
            this.btn_adaugaPlayer.Click += new System.EventHandler(this.btn_adaugaPlayer_Click);
            // 
            // NumeJucator_label
            // 
            this.NumeJucator_label.AutoSize = true;
            this.NumeJucator_label.Location = new System.Drawing.Point(533, 401);
            this.NumeJucator_label.Name = "NumeJucator_label";
            this.NumeJucator_label.Size = new System.Drawing.Size(76, 13);
            this.NumeJucator_label.TabIndex = 7;
            this.NumeJucator_label.Text = "Nume_Jucator";
            // 
            // Pozitie_label
            // 
            this.Pozitie_label.AutoSize = true;
            this.Pozitie_label.Location = new System.Drawing.Point(533, 431);
            this.Pozitie_label.Name = "Pozitie_label";
            this.Pozitie_label.Size = new System.Drawing.Size(38, 13);
            this.Pozitie_label.TabIndex = 8;
            this.Pozitie_label.Text = "Pozitie";
            // 
            // tb_numeJucator
            // 
            this.tb_numeJucator.Location = new System.Drawing.Point(630, 394);
            this.tb_numeJucator.Name = "tb_numeJucator";
            this.tb_numeJucator.Size = new System.Drawing.Size(100, 20);
            this.tb_numeJucator.TabIndex = 9;
            // 
            // tb_pozitie
            // 
            this.tb_pozitie.Location = new System.Drawing.Point(630, 431);
            this.tb_pozitie.Name = "tb_pozitie";
            this.tb_pozitie.Size = new System.Drawing.Size(100, 20);
            this.tb_pozitie.TabIndex = 10;
            // 
            // btn_clearCity
            // 
            this.btn_clearCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_clearCity.Location = new System.Drawing.Point(328, 500);
            this.btn_clearCity.Name = "btn_clearCity";
            this.btn_clearCity.Size = new System.Drawing.Size(104, 38);
            this.btn_clearCity.TabIndex = 11;
            this.btn_clearCity.Text = "Clear_City";
            this.btn_clearCity.UseVisualStyleBackColor = false;
            this.btn_clearCity.Click += new System.EventHandler(this.btn_clearCity_Click);
            // 
            // btn_clearInregistrare
            // 
            this.btn_clearInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clearInregistrare.Location = new System.Drawing.Point(586, 500);
            this.btn_clearInregistrare.Name = "btn_clearInregistrare";
            this.btn_clearInregistrare.Size = new System.Drawing.Size(108, 27);
            this.btn_clearInregistrare.TabIndex = 12;
            this.btn_clearInregistrare.Text = "Clear_inregistrare";
            this.btn_clearInregistrare.UseVisualStyleBackColor = false;
            this.btn_clearInregistrare.Click += new System.EventHandler(this.btn_clearInregistrare_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppTema1.Properties.Resources.ManCity;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 572);
            this.Controls.Add(this.btn_clearInregistrare);
            this.Controls.Add(this.btn_clearCity);
            this.Controls.Add(this.tb_pozitie);
            this.Controls.Add(this.tb_numeJucator);
            this.Controls.Add(this.Pozitie_label);
            this.Controls.Add(this.NumeJucator_label);
            this.Controls.Add(this.btn_adaugaPlayer);
            this.Controls.Add(this.btn_afiseazaLot);
            this.Controls.Add(this.lb_mijlocasiAndAtacanti);
            this.Controls.Add(this.lb_fundasi);
            this.Controls.Add(this.lb_portari);
            this.Controls.Add(this.tb_antrenorCity);
            this.Controls.Add(this.btn_antrenorCity);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_antrenorCity;
        private System.Windows.Forms.TextBox tb_antrenorCity;
        private System.Windows.Forms.ListBox lb_portari;
        private System.Windows.Forms.ListBox lb_fundasi;
        private System.Windows.Forms.ListBox lb_mijlocasiAndAtacanti;
        private System.Windows.Forms.Button btn_afiseazaLot;
        private System.Windows.Forms.Button btn_adaugaPlayer;
        private System.Windows.Forms.Label NumeJucator_label;
        private System.Windows.Forms.Label Pozitie_label;
        private System.Windows.Forms.TextBox tb_numeJucator;
        private System.Windows.Forms.TextBox tb_pozitie;
        private System.Windows.Forms.Button btn_clearCity;
        private System.Windows.Forms.Button btn_clearInregistrare;
    }
}