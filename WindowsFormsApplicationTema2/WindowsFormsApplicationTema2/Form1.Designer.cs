namespace WindowsFormsApplicationTema2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_refreshEchipe = new System.Windows.Forms.Button();
            this.btn_refreshJucatori = new System.Windows.Forms.Button();
            this.btn_modifyTeam = new System.Windows.Forms.Button();
            this.label_No_trophies = new System.Windows.Forms.Label();
            this.label_Code = new System.Windows.Forms.Label();
            this.tb_No_trophies = new System.Windows.Forms.TextBox();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.btn_deleteTeam = new System.Windows.Forms.Button();
            this.label_CodeToDelete = new System.Windows.Forms.Label();
            this.tb_CodeToDelete = new System.Windows.Forms.TextBox();
            this.btn_modifyPlayer = new System.Windows.Forms.Button();
            this.label_Position = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_CodeofTeam = new System.Windows.Forms.Label();
            this.tb_Position = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_CodeofTeam = new System.Windows.Forms.TextBox();
            this.btn_deletePlayer = new System.Windows.Forms.Button();
            this.label_IdtoDelete = new System.Windows.Forms.Label();
            this.tb_IdtoDelete = new System.Windows.Forms.TextBox();
            this.label_IdtoInsert = new System.Windows.Forms.Label();
            this.label_NumeEchipatoInsert = new System.Windows.Forms.Label();
            this.label_StadiontoInsert = new System.Windows.Forms.Label();
            this.label_CitytoInsert = new System.Windows.Forms.Label();
            this.label_TrofeutoInsert = new System.Windows.Forms.Label();
            this.label_CodtoInsert = new System.Windows.Forms.Label();
            this.tb_IdtoInsert = new System.Windows.Forms.TextBox();
            this.tb_NumeEchipatoInsert = new System.Windows.Forms.TextBox();
            this.tb_StadiontoInsert = new System.Windows.Forms.TextBox();
            this.tb_CitytoInsert = new System.Windows.Forms.TextBox();
            this.tb_TrofeutoInsert = new System.Windows.Forms.TextBox();
            this.tb_CodtoInsert = new System.Windows.Forms.TextBox();
            this.label_IdPlayertoInsert = new System.Windows.Forms.Label();
            this.label_NumeJucatortoInsert = new System.Windows.Forms.Label();
            this.label_CountrytoInsert = new System.Windows.Forms.Label();
            this.label_PositiontoInsert = new System.Windows.Forms.Label();
            this.label_CodPtoInsert = new System.Windows.Forms.Label();
            this.tb_IdPlayertoInsert = new System.Windows.Forms.TextBox();
            this.tb_NumeJucatortoInsert = new System.Windows.Forms.TextBox();
            this.tb_CountrytoInsert = new System.Windows.Forms.TextBox();
            this.tb_PositiontoInsert = new System.Windows.Forms.TextBox();
            this.tb_CodPtoInsert = new System.Windows.Forms.TextBox();
            this.btn_InsertTeam = new System.Windows.Forms.Button();
            this.btn_InsertPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(507, 286);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(305, 172);
            this.dataGridView2.TabIndex = 1;
            // 
            // btn_refreshEchipe
            // 
            this.btn_refreshEchipe.Location = new System.Drawing.Point(142, 474);
            this.btn_refreshEchipe.Name = "btn_refreshEchipe";
            this.btn_refreshEchipe.Size = new System.Drawing.Size(92, 29);
            this.btn_refreshEchipe.TabIndex = 2;
            this.btn_refreshEchipe.Text = "Refresh_Echipe";
            this.btn_refreshEchipe.UseVisualStyleBackColor = true;
            this.btn_refreshEchipe.Click += new System.EventHandler(this.btn_refreshEchipe_Click);
            // 
            // btn_refreshJucatori
            // 
            this.btn_refreshJucatori.Location = new System.Drawing.Point(618, 474);
            this.btn_refreshJucatori.Name = "btn_refreshJucatori";
            this.btn_refreshJucatori.Size = new System.Drawing.Size(109, 28);
            this.btn_refreshJucatori.TabIndex = 3;
            this.btn_refreshJucatori.Text = "Refresh_Jucatori";
            this.btn_refreshJucatori.UseVisualStyleBackColor = true;
            this.btn_refreshJucatori.Click += new System.EventHandler(this.btn_refreshJucatori_Click);
            // 
            // btn_modifyTeam
            // 
            this.btn_modifyTeam.Location = new System.Drawing.Point(38, 13);
            this.btn_modifyTeam.Name = "btn_modifyTeam";
            this.btn_modifyTeam.Size = new System.Drawing.Size(79, 25);
            this.btn_modifyTeam.TabIndex = 4;
            this.btn_modifyTeam.Text = "Modify_team";
            this.btn_modifyTeam.UseVisualStyleBackColor = true;
            this.btn_modifyTeam.Click += new System.EventHandler(this.btn_modifyTeam_Click);
            // 
            // label_No_trophies
            // 
            this.label_No_trophies.AutoSize = true;
            this.label_No_trophies.Location = new System.Drawing.Point(12, 61);
            this.label_No_trophies.Name = "label_No_trophies";
            this.label_No_trophies.Size = new System.Drawing.Size(64, 13);
            this.label_No_trophies.TabIndex = 5;
            this.label_No_trophies.Text = "No_trophies";
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Location = new System.Drawing.Point(15, 89);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(32, 13);
            this.label_Code.TabIndex = 6;
            this.label_Code.Text = "Code";
            // 
            // tb_No_trophies
            // 
            this.tb_No_trophies.Location = new System.Drawing.Point(94, 54);
            this.tb_No_trophies.Name = "tb_No_trophies";
            this.tb_No_trophies.Size = new System.Drawing.Size(100, 20);
            this.tb_No_trophies.TabIndex = 7;
            // 
            // tb_Code
            // 
            this.tb_Code.Location = new System.Drawing.Point(94, 81);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(100, 20);
            this.tb_Code.TabIndex = 8;
            // 
            // btn_deleteTeam
            // 
            this.btn_deleteTeam.Location = new System.Drawing.Point(271, 14);
            this.btn_deleteTeam.Name = "btn_deleteTeam";
            this.btn_deleteTeam.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteTeam.TabIndex = 9;
            this.btn_deleteTeam.Text = "Delete_team";
            this.btn_deleteTeam.UseVisualStyleBackColor = true;
            this.btn_deleteTeam.Click += new System.EventHandler(this.btn_deleteTeam_Click);
            // 
            // label_CodeToDelete
            // 
            this.label_CodeToDelete.AutoSize = true;
            this.label_CodeToDelete.Location = new System.Drawing.Point(257, 54);
            this.label_CodeToDelete.Name = "label_CodeToDelete";
            this.label_CodeToDelete.Size = new System.Drawing.Size(76, 13);
            this.label_CodeToDelete.TabIndex = 11;
            this.label_CodeToDelete.Text = "CodeToDelete";
            // 
            // tb_CodeToDelete
            // 
            this.tb_CodeToDelete.Location = new System.Drawing.Point(351, 47);
            this.tb_CodeToDelete.Name = "tb_CodeToDelete";
            this.tb_CodeToDelete.Size = new System.Drawing.Size(100, 20);
            this.tb_CodeToDelete.TabIndex = 12;
            // 
            // btn_modifyPlayer
            // 
            this.btn_modifyPlayer.Location = new System.Drawing.Point(526, 14);
            this.btn_modifyPlayer.Name = "btn_modifyPlayer";
            this.btn_modifyPlayer.Size = new System.Drawing.Size(95, 23);
            this.btn_modifyPlayer.TabIndex = 13;
            this.btn_modifyPlayer.Text = "Modify_Player";
            this.btn_modifyPlayer.UseVisualStyleBackColor = true;
            this.btn_modifyPlayer.Click += new System.EventHandler(this.btn_modifyPlayer_Click);
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(526, 53);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(44, 13);
            this.label_Position.TabIndex = 14;
            this.label_Position.Text = "Position";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(529, 81);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(16, 13);
            this.label_Id.TabIndex = 15;
            this.label_Id.Text = "Id";
            // 
            // label_CodeofTeam
            // 
            this.label_CodeofTeam.AutoSize = true;
            this.label_CodeofTeam.Location = new System.Drawing.Point(523, 113);
            this.label_CodeofTeam.Name = "label_CodeofTeam";
            this.label_CodeofTeam.Size = new System.Drawing.Size(68, 13);
            this.label_CodeofTeam.TabIndex = 16;
            this.label_CodeofTeam.Text = "CodeofTeam";
            // 
            // tb_Position
            // 
            this.tb_Position.Location = new System.Drawing.Point(597, 47);
            this.tb_Position.Name = "tb_Position";
            this.tb_Position.Size = new System.Drawing.Size(100, 20);
            this.tb_Position.TabIndex = 17;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(597, 74);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 20);
            this.tb_Id.TabIndex = 18;
            // 
            // tb_CodeofTeam
            // 
            this.tb_CodeofTeam.Location = new System.Drawing.Point(597, 106);
            this.tb_CodeofTeam.Name = "tb_CodeofTeam";
            this.tb_CodeofTeam.Size = new System.Drawing.Size(100, 20);
            this.tb_CodeofTeam.TabIndex = 19;
            // 
            // btn_deletePlayer
            // 
            this.btn_deletePlayer.Location = new System.Drawing.Point(756, 14);
            this.btn_deletePlayer.Name = "btn_deletePlayer";
            this.btn_deletePlayer.Size = new System.Drawing.Size(87, 23);
            this.btn_deletePlayer.TabIndex = 20;
            this.btn_deletePlayer.Text = "Delete_Player";
            this.btn_deletePlayer.UseVisualStyleBackColor = true;
            this.btn_deletePlayer.Click += new System.EventHandler(this.btn_deletePlayer_Click);
            // 
            // label_IdtoDelete
            // 
            this.label_IdtoDelete.AutoSize = true;
            this.label_IdtoDelete.Location = new System.Drawing.Point(723, 50);
            this.label_IdtoDelete.Name = "label_IdtoDelete";
            this.label_IdtoDelete.Size = new System.Drawing.Size(56, 13);
            this.label_IdtoDelete.TabIndex = 21;
            this.label_IdtoDelete.Text = "IdtoDelete";
            // 
            // tb_IdtoDelete
            // 
            this.tb_IdtoDelete.Location = new System.Drawing.Point(785, 46);
            this.tb_IdtoDelete.Name = "tb_IdtoDelete";
            this.tb_IdtoDelete.Size = new System.Drawing.Size(36, 20);
            this.tb_IdtoDelete.TabIndex = 22;
            // 
            // label_IdtoInsert
            // 
            this.label_IdtoInsert.AutoSize = true;
            this.label_IdtoInsert.Location = new System.Drawing.Point(18, 113);
            this.label_IdtoInsert.Name = "label_IdtoInsert";
            this.label_IdtoInsert.Size = new System.Drawing.Size(57, 13);
            this.label_IdtoInsert.TabIndex = 23;
            this.label_IdtoInsert.Text = "Id_toInsert";
            // 
            // label_NumeEchipatoInsert
            // 
            this.label_NumeEchipatoInsert.AutoSize = true;
            this.label_NumeEchipatoInsert.Location = new System.Drawing.Point(12, 145);
            this.label_NumeEchipatoInsert.Name = "label_NumeEchipatoInsert";
            this.label_NumeEchipatoInsert.Size = new System.Drawing.Size(109, 13);
            this.label_NumeEchipatoInsert.TabIndex = 24;
            this.label_NumeEchipatoInsert.Text = "NumeEchipa_toInsert";
            // 
            // label_StadiontoInsert
            // 
            this.label_StadiontoInsert.AutoSize = true;
            this.label_StadiontoInsert.Location = new System.Drawing.Point(18, 175);
            this.label_StadiontoInsert.Name = "label_StadiontoInsert";
            this.label_StadiontoInsert.Size = new System.Drawing.Size(84, 13);
            this.label_StadiontoInsert.TabIndex = 25;
            this.label_StadiontoInsert.Text = "Stadion_toInsert";
            // 
            // label_CitytoInsert
            // 
            this.label_CitytoInsert.AutoSize = true;
            this.label_CitytoInsert.Location = new System.Drawing.Point(18, 203);
            this.label_CitytoInsert.Name = "label_CitytoInsert";
            this.label_CitytoInsert.Size = new System.Drawing.Size(65, 13);
            this.label_CitytoInsert.TabIndex = 26;
            this.label_CitytoInsert.Text = "City_toInsert";
            // 
            // label_TrofeutoInsert
            // 
            this.label_TrofeutoInsert.AutoSize = true;
            this.label_TrofeutoInsert.Location = new System.Drawing.Point(15, 230);
            this.label_TrofeutoInsert.Name = "label_TrofeutoInsert";
            this.label_TrofeutoInsert.Size = new System.Drawing.Size(79, 13);
            this.label_TrofeutoInsert.TabIndex = 27;
            this.label_TrofeutoInsert.Text = "Trofeu_toInsert";
            // 
            // label_CodtoInsert
            // 
            this.label_CodtoInsert.AutoSize = true;
            this.label_CodtoInsert.Location = new System.Drawing.Point(18, 257);
            this.label_CodtoInsert.Name = "label_CodtoInsert";
            this.label_CodtoInsert.Size = new System.Drawing.Size(67, 13);
            this.label_CodtoInsert.TabIndex = 28;
            this.label_CodtoInsert.Text = "Cod_toInsert";
            // 
            // tb_IdtoInsert
            // 
            this.tb_IdtoInsert.Location = new System.Drawing.Point(94, 110);
            this.tb_IdtoInsert.Name = "tb_IdtoInsert";
            this.tb_IdtoInsert.Size = new System.Drawing.Size(82, 20);
            this.tb_IdtoInsert.TabIndex = 29;
            // 
            // tb_NumeEchipatoInsert
            // 
            this.tb_NumeEchipatoInsert.Location = new System.Drawing.Point(134, 142);
            this.tb_NumeEchipatoInsert.Name = "tb_NumeEchipatoInsert";
            this.tb_NumeEchipatoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_NumeEchipatoInsert.TabIndex = 30;
            // 
            // tb_StadiontoInsert
            // 
            this.tb_StadiontoInsert.Location = new System.Drawing.Point(134, 168);
            this.tb_StadiontoInsert.Name = "tb_StadiontoInsert";
            this.tb_StadiontoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_StadiontoInsert.TabIndex = 31;
            // 
            // tb_CitytoInsert
            // 
            this.tb_CitytoInsert.Location = new System.Drawing.Point(134, 196);
            this.tb_CitytoInsert.Name = "tb_CitytoInsert";
            this.tb_CitytoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_CitytoInsert.TabIndex = 32;
            // 
            // tb_TrofeutoInsert
            // 
            this.tb_TrofeutoInsert.Location = new System.Drawing.Point(134, 223);
            this.tb_TrofeutoInsert.Name = "tb_TrofeutoInsert";
            this.tb_TrofeutoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_TrofeutoInsert.TabIndex = 33;
            // 
            // tb_CodtoInsert
            // 
            this.tb_CodtoInsert.Location = new System.Drawing.Point(134, 250);
            this.tb_CodtoInsert.Name = "tb_CodtoInsert";
            this.tb_CodtoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_CodtoInsert.TabIndex = 34;
            // 
            // label_IdPlayertoInsert
            // 
            this.label_IdPlayertoInsert.AutoSize = true;
            this.label_IdPlayertoInsert.Location = new System.Drawing.Point(532, 157);
            this.label_IdPlayertoInsert.Name = "label_IdPlayertoInsert";
            this.label_IdPlayertoInsert.Size = new System.Drawing.Size(86, 13);
            this.label_IdPlayertoInsert.TabIndex = 35;
            this.label_IdPlayertoInsert.Text = "IdPlayer_toInsert";
            // 
            // label_NumeJucatortoInsert
            // 
            this.label_NumeJucatortoInsert.AutoSize = true;
            this.label_NumeJucatortoInsert.Location = new System.Drawing.Point(535, 187);
            this.label_NumeJucatortoInsert.Name = "label_NumeJucatortoInsert";
            this.label_NumeJucatortoInsert.Size = new System.Drawing.Size(111, 13);
            this.label_NumeJucatortoInsert.TabIndex = 36;
            this.label_NumeJucatortoInsert.Text = "NumeJucator_toInsert";
            // 
            // label_CountrytoInsert
            // 
            this.label_CountrytoInsert.AutoSize = true;
            this.label_CountrytoInsert.Location = new System.Drawing.Point(538, 213);
            this.label_CountrytoInsert.Name = "label_CountrytoInsert";
            this.label_CountrytoInsert.Size = new System.Drawing.Size(84, 13);
            this.label_CountrytoInsert.TabIndex = 37;
            this.label_CountrytoInsert.Text = "Country_toInsert";
            // 
            // label_PositiontoInsert
            // 
            this.label_PositiontoInsert.AutoSize = true;
            this.label_PositiontoInsert.Location = new System.Drawing.Point(538, 239);
            this.label_PositiontoInsert.Name = "label_PositiontoInsert";
            this.label_PositiontoInsert.Size = new System.Drawing.Size(85, 13);
            this.label_PositiontoInsert.TabIndex = 38;
            this.label_PositiontoInsert.Text = "Position_toInsert";
            // 
            // label_CodPtoInsert
            // 
            this.label_CodPtoInsert.AutoSize = true;
            this.label_CodPtoInsert.Location = new System.Drawing.Point(541, 267);
            this.label_CodPtoInsert.Name = "label_CodPtoInsert";
            this.label_CodPtoInsert.Size = new System.Drawing.Size(74, 13);
            this.label_CodPtoInsert.TabIndex = 39;
            this.label_CodPtoInsert.Text = "CodP_toInsert";
            // 
            // tb_IdPlayertoInsert
            // 
            this.tb_IdPlayertoInsert.Location = new System.Drawing.Point(643, 150);
            this.tb_IdPlayertoInsert.Name = "tb_IdPlayertoInsert";
            this.tb_IdPlayertoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_IdPlayertoInsert.TabIndex = 40;
            // 
            // tb_NumeJucatortoInsert
            // 
            this.tb_NumeJucatortoInsert.Location = new System.Drawing.Point(652, 180);
            this.tb_NumeJucatortoInsert.Name = "tb_NumeJucatortoInsert";
            this.tb_NumeJucatortoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_NumeJucatortoInsert.TabIndex = 41;
            // 
            // tb_CountrytoInsert
            // 
            this.tb_CountrytoInsert.Location = new System.Drawing.Point(652, 206);
            this.tb_CountrytoInsert.Name = "tb_CountrytoInsert";
            this.tb_CountrytoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_CountrytoInsert.TabIndex = 42;
            // 
            // tb_PositiontoInsert
            // 
            this.tb_PositiontoInsert.Location = new System.Drawing.Point(652, 236);
            this.tb_PositiontoInsert.Name = "tb_PositiontoInsert";
            this.tb_PositiontoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_PositiontoInsert.TabIndex = 43;
            // 
            // tb_CodPtoInsert
            // 
            this.tb_CodPtoInsert.Location = new System.Drawing.Point(652, 262);
            this.tb_CodPtoInsert.Name = "tb_CodPtoInsert";
            this.tb_CodPtoInsert.Size = new System.Drawing.Size(100, 20);
            this.tb_CodPtoInsert.TabIndex = 44;
            // 
            // btn_InsertTeam
            // 
            this.btn_InsertTeam.BackColor = System.Drawing.Color.Red;
            this.btn_InsertTeam.Location = new System.Drawing.Point(271, 473);
            this.btn_InsertTeam.Name = "btn_InsertTeam";
            this.btn_InsertTeam.Size = new System.Drawing.Size(88, 30);
            this.btn_InsertTeam.TabIndex = 45;
            this.btn_InsertTeam.Text = "Insert_team";
            this.btn_InsertTeam.UseVisualStyleBackColor = false;
            this.btn_InsertTeam.Click += new System.EventHandler(this.btn_InsertTeam_Click);
            // 
            // btn_InsertPlayer
            // 
            this.btn_InsertPlayer.BackColor = System.Drawing.Color.Red;
            this.btn_InsertPlayer.Location = new System.Drawing.Point(756, 473);
            this.btn_InsertPlayer.Name = "btn_InsertPlayer";
            this.btn_InsertPlayer.Size = new System.Drawing.Size(75, 29);
            this.btn_InsertPlayer.TabIndex = 46;
            this.btn_InsertPlayer.Text = "Insert_player";
            this.btn_InsertPlayer.UseVisualStyleBackColor = false;
            this.btn_InsertPlayer.Click += new System.EventHandler(this.btn_InsertPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 536);
            this.Controls.Add(this.btn_InsertPlayer);
            this.Controls.Add(this.btn_InsertTeam);
            this.Controls.Add(this.tb_CodPtoInsert);
            this.Controls.Add(this.tb_PositiontoInsert);
            this.Controls.Add(this.tb_CountrytoInsert);
            this.Controls.Add(this.tb_NumeJucatortoInsert);
            this.Controls.Add(this.tb_IdPlayertoInsert);
            this.Controls.Add(this.label_CodPtoInsert);
            this.Controls.Add(this.label_PositiontoInsert);
            this.Controls.Add(this.label_CountrytoInsert);
            this.Controls.Add(this.label_NumeJucatortoInsert);
            this.Controls.Add(this.label_IdPlayertoInsert);
            this.Controls.Add(this.tb_CodtoInsert);
            this.Controls.Add(this.tb_TrofeutoInsert);
            this.Controls.Add(this.tb_CitytoInsert);
            this.Controls.Add(this.tb_StadiontoInsert);
            this.Controls.Add(this.tb_NumeEchipatoInsert);
            this.Controls.Add(this.tb_IdtoInsert);
            this.Controls.Add(this.label_CodtoInsert);
            this.Controls.Add(this.label_TrofeutoInsert);
            this.Controls.Add(this.label_CitytoInsert);
            this.Controls.Add(this.label_StadiontoInsert);
            this.Controls.Add(this.label_NumeEchipatoInsert);
            this.Controls.Add(this.label_IdtoInsert);
            this.Controls.Add(this.tb_IdtoDelete);
            this.Controls.Add(this.label_IdtoDelete);
            this.Controls.Add(this.btn_deletePlayer);
            this.Controls.Add(this.tb_CodeofTeam);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.tb_Position);
            this.Controls.Add(this.label_CodeofTeam);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.btn_modifyPlayer);
            this.Controls.Add(this.tb_CodeToDelete);
            this.Controls.Add(this.label_CodeToDelete);
            this.Controls.Add(this.btn_deleteTeam);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.tb_No_trophies);
            this.Controls.Add(this.label_Code);
            this.Controls.Add(this.label_No_trophies);
            this.Controls.Add(this.btn_modifyTeam);
            this.Controls.Add(this.btn_refreshJucatori);
            this.Controls.Add(this.btn_refreshEchipe);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_refreshEchipe;
        private System.Windows.Forms.Button btn_refreshJucatori;
        private System.Windows.Forms.Button btn_modifyTeam;
        private System.Windows.Forms.Label label_No_trophies;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.TextBox tb_No_trophies;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Button btn_deleteTeam;
        private System.Windows.Forms.Label label_CodeToDelete;
        private System.Windows.Forms.TextBox tb_CodeToDelete;
        private System.Windows.Forms.Button btn_modifyPlayer;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_CodeofTeam;
        private System.Windows.Forms.TextBox tb_Position;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_CodeofTeam;
        private System.Windows.Forms.Button btn_deletePlayer;
        private System.Windows.Forms.Label label_IdtoDelete;
        private System.Windows.Forms.TextBox tb_IdtoDelete;
        private System.Windows.Forms.Label label_IdtoInsert;
        private System.Windows.Forms.Label label_NumeEchipatoInsert;
        private System.Windows.Forms.Label label_StadiontoInsert;
        private System.Windows.Forms.Label label_CitytoInsert;
        private System.Windows.Forms.Label label_TrofeutoInsert;
        private System.Windows.Forms.Label label_CodtoInsert;
        private System.Windows.Forms.TextBox tb_IdtoInsert;
        private System.Windows.Forms.TextBox tb_NumeEchipatoInsert;
        private System.Windows.Forms.TextBox tb_StadiontoInsert;
        private System.Windows.Forms.TextBox tb_CitytoInsert;
        private System.Windows.Forms.TextBox tb_TrofeutoInsert;
        private System.Windows.Forms.TextBox tb_CodtoInsert;
        private System.Windows.Forms.Label label_IdPlayertoInsert;
        private System.Windows.Forms.Label label_NumeJucatortoInsert;
        private System.Windows.Forms.Label label_CountrytoInsert;
        private System.Windows.Forms.Label label_PositiontoInsert;
        private System.Windows.Forms.Label label_CodPtoInsert;
        private System.Windows.Forms.TextBox tb_IdPlayertoInsert;
        private System.Windows.Forms.TextBox tb_NumeJucatortoInsert;
        private System.Windows.Forms.TextBox tb_CountrytoInsert;
        private System.Windows.Forms.TextBox tb_PositiontoInsert;
        private System.Windows.Forms.TextBox tb_CodPtoInsert;
        private System.Windows.Forms.Button btn_InsertTeam;
        private System.Windows.Forms.Button btn_InsertPlayer;
    }
}

