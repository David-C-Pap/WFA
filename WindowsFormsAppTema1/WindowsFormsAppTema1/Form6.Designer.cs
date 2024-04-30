namespace WindowsFormsAppTema1
{
    partial class Form6
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
            this.btn_liverpoolAntrenor = new System.Windows.Forms.Button();
            this.tb_antrenorLiverpool = new System.Windows.Forms.TextBox();
            this.btn_liverpoolStadium = new System.Windows.Forms.Button();
            this.tb_liverpoolStadium = new System.Windows.Forms.TextBox();
            this.lb_actualPlayers = new System.Windows.Forms.ListBox();
            this.btn_actualPlayers = new System.Windows.Forms.Button();
            this.lb_unusedPlayers = new System.Windows.Forms.ListBox();
            this.btn_unusedPlayers = new System.Windows.Forms.Button();
            this.group_position = new System.Windows.Forms.GroupBox();
            this.Fundas_radioButton = new System.Windows.Forms.RadioButton();
            this.Mijlocas_radioButton = new System.Windows.Forms.RadioButton();
            this.Atacant_radioButton = new System.Windows.Forms.RadioButton();
            this.group_jucatori = new System.Windows.Forms.GroupBox();
            this.Robertson_radioButton = new System.Windows.Forms.RadioButton();
            this.Henderson_radioButton = new System.Windows.Forms.RadioButton();
            this.Salah_radioButton = new System.Windows.Forms.RadioButton();
            this.group_tipPozitie = new System.Windows.Forms.GroupBox();
            this.Defensiv_radioButton = new System.Windows.Forms.RadioButton();
            this.Ofensiv_radioButton = new System.Windows.Forms.RadioButton();
            this.AripaDreapta_radioButton = new System.Windows.Forms.RadioButton();
            this.AripaStanga_radioButton = new System.Windows.Forms.RadioButton();
            this.Central_radioButton = new System.Windows.Forms.RadioButton();
            this.btn_moveToUnused = new System.Windows.Forms.Button();
            this.btn_selectatiJucator = new System.Windows.Forms.Button();
            this.contextMenuStripPlayers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firminoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hendersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxNational = new System.Windows.Forms.PictureBox();
            this.btn_displayFormula = new System.Windows.Forms.Button();
            this.btn_clearLiverpool = new System.Windows.Forms.Button();
            this.nationalitateaJucatorului_label = new System.Windows.Forms.Label();
            this.group_position.SuspendLayout();
            this.group_jucatori.SuspendLayout();
            this.group_tipPozitie.SuspendLayout();
            this.contextMenuStripPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNational)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_liverpoolAntrenor
            // 
            this.btn_liverpoolAntrenor.Location = new System.Drawing.Point(56, 39);
            this.btn_liverpoolAntrenor.Name = "btn_liverpoolAntrenor";
            this.btn_liverpoolAntrenor.Size = new System.Drawing.Size(105, 24);
            this.btn_liverpoolAntrenor.TabIndex = 0;
            this.btn_liverpoolAntrenor.Text = "Liverpool_Antrenor";
            this.btn_liverpoolAntrenor.UseVisualStyleBackColor = true;
            this.btn_liverpoolAntrenor.Click += new System.EventHandler(this.btn_liverpoolAntrenor_Click);
            // 
            // tb_antrenorLiverpool
            // 
            this.tb_antrenorLiverpool.Location = new System.Drawing.Point(182, 39);
            this.tb_antrenorLiverpool.Name = "tb_antrenorLiverpool";
            this.tb_antrenorLiverpool.Size = new System.Drawing.Size(100, 20);
            this.tb_antrenorLiverpool.TabIndex = 1;
            // 
            // btn_liverpoolStadium
            // 
            this.btn_liverpoolStadium.Location = new System.Drawing.Point(56, 79);
            this.btn_liverpoolStadium.Name = "btn_liverpoolStadium";
            this.btn_liverpoolStadium.Size = new System.Drawing.Size(105, 23);
            this.btn_liverpoolStadium.TabIndex = 2;
            this.btn_liverpoolStadium.Text = "Liverpool_stadium";
            this.btn_liverpoolStadium.UseVisualStyleBackColor = true;
            this.btn_liverpoolStadium.Click += new System.EventHandler(this.btn_liverpoolStadium_Click);
            // 
            // tb_liverpoolStadium
            // 
            this.tb_liverpoolStadium.Location = new System.Drawing.Point(182, 81);
            this.tb_liverpoolStadium.Name = "tb_liverpoolStadium";
            this.tb_liverpoolStadium.Size = new System.Drawing.Size(100, 20);
            this.tb_liverpoolStadium.TabIndex = 3;
            // 
            // lb_actualPlayers
            // 
            this.lb_actualPlayers.FormattingEnabled = true;
            this.lb_actualPlayers.Location = new System.Drawing.Point(41, 153);
            this.lb_actualPlayers.Name = "lb_actualPlayers";
            this.lb_actualPlayers.Size = new System.Drawing.Size(120, 186);
            this.lb_actualPlayers.TabIndex = 4;
            // 
            // btn_actualPlayers
            // 
            this.btn_actualPlayers.Location = new System.Drawing.Point(41, 124);
            this.btn_actualPlayers.Name = "btn_actualPlayers";
            this.btn_actualPlayers.Size = new System.Drawing.Size(93, 23);
            this.btn_actualPlayers.TabIndex = 5;
            this.btn_actualPlayers.Text = "Actual_Players";
            this.btn_actualPlayers.UseVisualStyleBackColor = true;
            this.btn_actualPlayers.Click += new System.EventHandler(this.btn_actualPlayers_Click);
            // 
            // lb_unusedPlayers
            // 
            this.lb_unusedPlayers.FormattingEnabled = true;
            this.lb_unusedPlayers.Location = new System.Drawing.Point(213, 153);
            this.lb_unusedPlayers.Name = "lb_unusedPlayers";
            this.lb_unusedPlayers.Size = new System.Drawing.Size(120, 186);
            this.lb_unusedPlayers.TabIndex = 6;
            // 
            // btn_unusedPlayers
            // 
            this.btn_unusedPlayers.Location = new System.Drawing.Point(225, 124);
            this.btn_unusedPlayers.Name = "btn_unusedPlayers";
            this.btn_unusedPlayers.Size = new System.Drawing.Size(97, 23);
            this.btn_unusedPlayers.TabIndex = 7;
            this.btn_unusedPlayers.Text = "Unused_Players";
            this.btn_unusedPlayers.UseVisualStyleBackColor = true;
            this.btn_unusedPlayers.Click += new System.EventHandler(this.btn_unusedPlayers_Click);
            // 
            // group_position
            // 
            this.group_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.group_position.Controls.Add(this.Fundas_radioButton);
            this.group_position.Controls.Add(this.Mijlocas_radioButton);
            this.group_position.Controls.Add(this.Atacant_radioButton);
            this.group_position.Location = new System.Drawing.Point(262, 402);
            this.group_position.Name = "group_position";
            this.group_position.Size = new System.Drawing.Size(166, 85);
            this.group_position.TabIndex = 8;
            this.group_position.TabStop = false;
            this.group_position.Text = "Pozitie";
            // 
            // Fundas_radioButton
            // 
            this.Fundas_radioButton.AutoSize = true;
            this.Fundas_radioButton.Location = new System.Drawing.Point(7, 62);
            this.Fundas_radioButton.Name = "Fundas_radioButton";
            this.Fundas_radioButton.Size = new System.Drawing.Size(60, 17);
            this.Fundas_radioButton.TabIndex = 2;
            this.Fundas_radioButton.TabStop = true;
            this.Fundas_radioButton.Text = "Fundas";
            this.Fundas_radioButton.UseVisualStyleBackColor = true;
            // 
            // Mijlocas_radioButton
            // 
            this.Mijlocas_radioButton.AutoSize = true;
            this.Mijlocas_radioButton.Location = new System.Drawing.Point(7, 44);
            this.Mijlocas_radioButton.Name = "Mijlocas_radioButton";
            this.Mijlocas_radioButton.Size = new System.Drawing.Size(63, 17);
            this.Mijlocas_radioButton.TabIndex = 1;
            this.Mijlocas_radioButton.TabStop = true;
            this.Mijlocas_radioButton.Text = "Mijlocas";
            this.Mijlocas_radioButton.UseVisualStyleBackColor = true;
            // 
            // Atacant_radioButton
            // 
            this.Atacant_radioButton.AutoSize = true;
            this.Atacant_radioButton.Location = new System.Drawing.Point(6, 20);
            this.Atacant_radioButton.Name = "Atacant_radioButton";
            this.Atacant_radioButton.Size = new System.Drawing.Size(62, 17);
            this.Atacant_radioButton.TabIndex = 0;
            this.Atacant_radioButton.TabStop = true;
            this.Atacant_radioButton.Text = "Atacant";
            this.Atacant_radioButton.UseVisualStyleBackColor = true;
            // 
            // group_jucatori
            // 
            this.group_jucatori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.group_jucatori.Controls.Add(this.Robertson_radioButton);
            this.group_jucatori.Controls.Add(this.Henderson_radioButton);
            this.group_jucatori.Controls.Add(this.Salah_radioButton);
            this.group_jucatori.Location = new System.Drawing.Point(56, 402);
            this.group_jucatori.Name = "group_jucatori";
            this.group_jucatori.Size = new System.Drawing.Size(166, 85);
            this.group_jucatori.TabIndex = 9;
            this.group_jucatori.TabStop = false;
            this.group_jucatori.Text = "Jucatori";
            // 
            // Robertson_radioButton
            // 
            this.Robertson_radioButton.AutoSize = true;
            this.Robertson_radioButton.Location = new System.Drawing.Point(6, 62);
            this.Robertson_radioButton.Name = "Robertson_radioButton";
            this.Robertson_radioButton.Size = new System.Drawing.Size(74, 17);
            this.Robertson_radioButton.TabIndex = 2;
            this.Robertson_radioButton.TabStop = true;
            this.Robertson_radioButton.Text = "Robertson";
            this.Robertson_radioButton.UseVisualStyleBackColor = true;
            // 
            // Henderson_radioButton
            // 
            this.Henderson_radioButton.AutoSize = true;
            this.Henderson_radioButton.Location = new System.Drawing.Point(7, 43);
            this.Henderson_radioButton.Name = "Henderson_radioButton";
            this.Henderson_radioButton.Size = new System.Drawing.Size(77, 17);
            this.Henderson_radioButton.TabIndex = 1;
            this.Henderson_radioButton.TabStop = true;
            this.Henderson_radioButton.Text = "Henderson";
            this.Henderson_radioButton.UseVisualStyleBackColor = true;
            // 
            // Salah_radioButton
            // 
            this.Salah_radioButton.AutoSize = true;
            this.Salah_radioButton.Location = new System.Drawing.Point(7, 20);
            this.Salah_radioButton.Name = "Salah_radioButton";
            this.Salah_radioButton.Size = new System.Drawing.Size(52, 17);
            this.Salah_radioButton.TabIndex = 0;
            this.Salah_radioButton.TabStop = true;
            this.Salah_radioButton.Text = "Salah";
            this.Salah_radioButton.UseVisualStyleBackColor = true;
            // 
            // group_tipPozitie
            // 
            this.group_tipPozitie.BackColor = System.Drawing.SystemColors.Info;
            this.group_tipPozitie.Controls.Add(this.Defensiv_radioButton);
            this.group_tipPozitie.Controls.Add(this.Ofensiv_radioButton);
            this.group_tipPozitie.Controls.Add(this.AripaDreapta_radioButton);
            this.group_tipPozitie.Controls.Add(this.AripaStanga_radioButton);
            this.group_tipPozitie.Controls.Add(this.Central_radioButton);
            this.group_tipPozitie.Location = new System.Drawing.Point(481, 402);
            this.group_tipPozitie.Name = "group_tipPozitie";
            this.group_tipPozitie.Size = new System.Drawing.Size(176, 84);
            this.group_tipPozitie.TabIndex = 10;
            this.group_tipPozitie.TabStop = false;
            this.group_tipPozitie.Text = "Tip_pozitie";
            // 
            // Defensiv_radioButton
            // 
            this.Defensiv_radioButton.AutoSize = true;
            this.Defensiv_radioButton.Location = new System.Drawing.Point(91, 44);
            this.Defensiv_radioButton.Name = "Defensiv_radioButton";
            this.Defensiv_radioButton.Size = new System.Drawing.Size(67, 17);
            this.Defensiv_radioButton.TabIndex = 4;
            this.Defensiv_radioButton.TabStop = true;
            this.Defensiv_radioButton.Text = "Defensiv";
            this.Defensiv_radioButton.UseVisualStyleBackColor = true;
            // 
            // Ofensiv_radioButton
            // 
            this.Ofensiv_radioButton.AutoSize = true;
            this.Ofensiv_radioButton.Location = new System.Drawing.Point(91, 19);
            this.Ofensiv_radioButton.Name = "Ofensiv_radioButton";
            this.Ofensiv_radioButton.Size = new System.Drawing.Size(61, 17);
            this.Ofensiv_radioButton.TabIndex = 3;
            this.Ofensiv_radioButton.TabStop = true;
            this.Ofensiv_radioButton.Text = "Ofensiv";
            this.Ofensiv_radioButton.UseVisualStyleBackColor = true;
            // 
            // AripaDreapta_radioButton
            // 
            this.AripaDreapta_radioButton.AutoSize = true;
            this.AripaDreapta_radioButton.Location = new System.Drawing.Point(7, 66);
            this.AripaDreapta_radioButton.Name = "AripaDreapta_radioButton";
            this.AripaDreapta_radioButton.Size = new System.Drawing.Size(87, 17);
            this.AripaDreapta_radioButton.TabIndex = 2;
            this.AripaDreapta_radioButton.TabStop = true;
            this.AripaDreapta_radioButton.Text = "AripaDreapta";
            this.AripaDreapta_radioButton.UseVisualStyleBackColor = true;
            // 
            // AripaStanga_radioButton
            // 
            this.AripaStanga_radioButton.AutoSize = true;
            this.AripaStanga_radioButton.Location = new System.Drawing.Point(7, 44);
            this.AripaStanga_radioButton.Name = "AripaStanga_radioButton";
            this.AripaStanga_radioButton.Size = new System.Drawing.Size(83, 17);
            this.AripaStanga_radioButton.TabIndex = 1;
            this.AripaStanga_radioButton.TabStop = true;
            this.AripaStanga_radioButton.Text = "AripaStanga";
            this.AripaStanga_radioButton.UseVisualStyleBackColor = true;
            // 
            // Central_radioButton
            // 
            this.Central_radioButton.AutoSize = true;
            this.Central_radioButton.Location = new System.Drawing.Point(7, 20);
            this.Central_radioButton.Name = "Central_radioButton";
            this.Central_radioButton.Size = new System.Drawing.Size(58, 17);
            this.Central_radioButton.TabIndex = 0;
            this.Central_radioButton.TabStop = true;
            this.Central_radioButton.Text = "Central";
            this.Central_radioButton.UseVisualStyleBackColor = true;
            // 
            // btn_moveToUnused
            // 
            this.btn_moveToUnused.Location = new System.Drawing.Point(137, 362);
            this.btn_moveToUnused.Name = "btn_moveToUnused";
            this.btn_moveToUnused.Size = new System.Drawing.Size(122, 23);
            this.btn_moveToUnused.TabIndex = 11;
            this.btn_moveToUnused.Text = "Move_toUnused";
            this.btn_moveToUnused.UseVisualStyleBackColor = true;
            this.btn_moveToUnused.Click += new System.EventHandler(this.btn_moveToUnused_Click);
            // 
            // btn_selectatiJucator
            // 
            this.btn_selectatiJucator.Location = new System.Drawing.Point(545, 32);
            this.btn_selectatiJucator.Name = "btn_selectatiJucator";
            this.btn_selectatiJucator.Size = new System.Drawing.Size(98, 27);
            this.btn_selectatiJucator.TabIndex = 12;
            this.btn_selectatiJucator.Text = "Selectati_jucator";
            this.btn_selectatiJucator.UseVisualStyleBackColor = true;
            this.btn_selectatiJucator.Click += new System.EventHandler(this.btn_selectatiJucator_Click);
            // 
            // contextMenuStripPlayers
            // 
            this.contextMenuStripPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salahToolStripMenuItem,
            this.firminoToolStripMenuItem,
            this.hendersonToolStripMenuItem});
            this.contextMenuStripPlayers.Name = "contextMenuStripPlayers";
            this.contextMenuStripPlayers.Size = new System.Drawing.Size(133, 70);
            this.contextMenuStripPlayers.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripPlayers_ItemClicked);
            // 
            // salahToolStripMenuItem
            // 
            this.salahToolStripMenuItem.Name = "salahToolStripMenuItem";
            this.salahToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.salahToolStripMenuItem.Text = "Salah";
            // 
            // firminoToolStripMenuItem
            // 
            this.firminoToolStripMenuItem.Name = "firminoToolStripMenuItem";
            this.firminoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.firminoToolStripMenuItem.Text = "Firmino";
            // 
            // hendersonToolStripMenuItem
            // 
            this.hendersonToolStripMenuItem.Name = "hendersonToolStripMenuItem";
            this.hendersonToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.hendersonToolStripMenuItem.Text = "Henderson";
            // 
            // pictureBoxNational
            // 
            this.pictureBoxNational.Location = new System.Drawing.Point(556, 182);
            this.pictureBoxNational.Name = "pictureBoxNational";
            this.pictureBoxNational.Size = new System.Drawing.Size(205, 157);
            this.pictureBoxNational.TabIndex = 15;
            this.pictureBoxNational.TabStop = false;
            // 
            // btn_displayFormula
            // 
            this.btn_displayFormula.Location = new System.Drawing.Point(269, 507);
            this.btn_displayFormula.Name = "btn_displayFormula";
            this.btn_displayFormula.Size = new System.Drawing.Size(91, 34);
            this.btn_displayFormula.TabIndex = 16;
            this.btn_displayFormula.Text = "Display_formula";
            this.btn_displayFormula.UseVisualStyleBackColor = true;
            this.btn_displayFormula.Click += new System.EventHandler(this.btn_displayFormula_Click);
            // 
            // btn_clearLiverpool
            // 
            this.btn_clearLiverpool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clearLiverpool.Location = new System.Drawing.Point(495, 507);
            this.btn_clearLiverpool.Name = "btn_clearLiverpool";
            this.btn_clearLiverpool.Size = new System.Drawing.Size(144, 53);
            this.btn_clearLiverpool.TabIndex = 17;
            this.btn_clearLiverpool.Text = "Clear_Liverpool";
            this.btn_clearLiverpool.UseVisualStyleBackColor = false;
            this.btn_clearLiverpool.Click += new System.EventHandler(this.btn_clearLiverpool_Click);
            // 
            // nationalitateaJucatorului_label
            // 
            this.nationalitateaJucatorului_label.AutoSize = true;
            this.nationalitateaJucatorului_label.Location = new System.Drawing.Point(495, 153);
            this.nationalitateaJucatorului_label.Name = "nationalitateaJucatorului_label";
            this.nationalitateaJucatorului_label.Size = new System.Drawing.Size(129, 13);
            this.nationalitateaJucatorului_label.TabIndex = 18;
            this.nationalitateaJucatorului_label.Text = "Nationalitatea_Jucatorului";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppTema1.Properties.Resources.Liverpool;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 572);
            this.Controls.Add(this.nationalitateaJucatorului_label);
            this.Controls.Add(this.btn_clearLiverpool);
            this.Controls.Add(this.btn_displayFormula);
            this.Controls.Add(this.pictureBoxNational);
            this.Controls.Add(this.btn_selectatiJucator);
            this.Controls.Add(this.btn_moveToUnused);
            this.Controls.Add(this.group_tipPozitie);
            this.Controls.Add(this.group_jucatori);
            this.Controls.Add(this.group_position);
            this.Controls.Add(this.btn_unusedPlayers);
            this.Controls.Add(this.lb_unusedPlayers);
            this.Controls.Add(this.btn_actualPlayers);
            this.Controls.Add(this.lb_actualPlayers);
            this.Controls.Add(this.tb_liverpoolStadium);
            this.Controls.Add(this.btn_liverpoolStadium);
            this.Controls.Add(this.tb_antrenorLiverpool);
            this.Controls.Add(this.btn_liverpoolAntrenor);
            this.Name = "Form6";
            this.Text = "Form6";
            this.group_position.ResumeLayout(false);
            this.group_position.PerformLayout();
            this.group_jucatori.ResumeLayout(false);
            this.group_jucatori.PerformLayout();
            this.group_tipPozitie.ResumeLayout(false);
            this.group_tipPozitie.PerformLayout();
            this.contextMenuStripPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNational)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_liverpoolAntrenor;
        private System.Windows.Forms.TextBox tb_antrenorLiverpool;
        private System.Windows.Forms.Button btn_liverpoolStadium;
        private System.Windows.Forms.TextBox tb_liverpoolStadium;
        private System.Windows.Forms.ListBox lb_actualPlayers;
        private System.Windows.Forms.Button btn_actualPlayers;
        private System.Windows.Forms.ListBox lb_unusedPlayers;
        private System.Windows.Forms.Button btn_unusedPlayers;
        private System.Windows.Forms.GroupBox group_position;
        private System.Windows.Forms.GroupBox group_jucatori;
        private System.Windows.Forms.GroupBox group_tipPozitie;
        private System.Windows.Forms.Button btn_moveToUnused;
        private System.Windows.Forms.RadioButton Fundas_radioButton;
        private System.Windows.Forms.RadioButton Mijlocas_radioButton;
        private System.Windows.Forms.RadioButton Atacant_radioButton;
        private System.Windows.Forms.RadioButton Robertson_radioButton;
        private System.Windows.Forms.RadioButton Henderson_radioButton;
        private System.Windows.Forms.RadioButton Salah_radioButton;
        private System.Windows.Forms.RadioButton Defensiv_radioButton;
        private System.Windows.Forms.RadioButton Ofensiv_radioButton;
        private System.Windows.Forms.RadioButton AripaDreapta_radioButton;
        private System.Windows.Forms.RadioButton AripaStanga_radioButton;
        private System.Windows.Forms.RadioButton Central_radioButton;
        private System.Windows.Forms.Button btn_selectatiJucator;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlayers;
        private System.Windows.Forms.ToolStripMenuItem salahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firminoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hendersonToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxNational;
        private System.Windows.Forms.Button btn_displayFormula;
        private System.Windows.Forms.Button btn_clearLiverpool;
        private System.Windows.Forms.Label nationalitateaJucatorului_label;
    }
}