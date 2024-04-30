namespace WindowsFormsAppTema1
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
            this.btn_Tottenham = new System.Windows.Forms.Button();
            this.Arsenal_btn = new System.Windows.Forms.Button();
            this.ManCity_btn = new System.Windows.Forms.Button();
            this.Liverpool_btn = new System.Windows.Forms.Button();
            this.History_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Tottenham
            // 
            this.btn_Tottenham.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Tottenham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Tottenham.Location = new System.Drawing.Point(6, 106);
            this.btn_Tottenham.Name = "btn_Tottenham";
            this.btn_Tottenham.Size = new System.Drawing.Size(103, 65);
            this.btn_Tottenham.TabIndex = 0;
            this.btn_Tottenham.Text = "Tottenham";
            this.btn_Tottenham.UseVisualStyleBackColor = false;
            this.btn_Tottenham.Click += new System.EventHandler(this.btn_Tottenham_Click);
            // 
            // Arsenal_btn
            // 
            this.Arsenal_btn.ForeColor = System.Drawing.Color.Red;
            this.Arsenal_btn.Location = new System.Drawing.Point(12, 502);
            this.Arsenal_btn.Name = "Arsenal_btn";
            this.Arsenal_btn.Size = new System.Drawing.Size(107, 68);
            this.Arsenal_btn.TabIndex = 1;
            this.Arsenal_btn.Text = "Arsenal";
            this.Arsenal_btn.UseVisualStyleBackColor = true;
            this.Arsenal_btn.Click += new System.EventHandler(this.Arsenal_btn_Click);
            // 
            // ManCity_btn
            // 
            this.ManCity_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ManCity_btn.Location = new System.Drawing.Point(897, 101);
            this.ManCity_btn.Name = "ManCity_btn";
            this.ManCity_btn.Size = new System.Drawing.Size(113, 70);
            this.ManCity_btn.TabIndex = 2;
            this.ManCity_btn.Text = "Man-City";
            this.ManCity_btn.UseVisualStyleBackColor = true;
            this.ManCity_btn.Click += new System.EventHandler(this.ManCity_btn_Click);
            // 
            // Liverpool_btn
            // 
            this.Liverpool_btn.ForeColor = System.Drawing.Color.Red;
            this.Liverpool_btn.Location = new System.Drawing.Point(903, 502);
            this.Liverpool_btn.Name = "Liverpool_btn";
            this.Liverpool_btn.Size = new System.Drawing.Size(107, 68);
            this.Liverpool_btn.TabIndex = 3;
            this.Liverpool_btn.Text = "Liverpool";
            this.Liverpool_btn.UseVisualStyleBackColor = true;
            this.Liverpool_btn.Click += new System.EventHandler(this.Liverpool_btn_Click);
            // 
            // History_btn
            // 
            this.History_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.History_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.History_btn.Location = new System.Drawing.Point(484, 12);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(111, 45);
            this.History_btn.TabIndex = 4;
            this.History_btn.Text = "History";
            this.History_btn.UseVisualStyleBackColor = false;
            this.History_btn.Click += new System.EventHandler(this.History_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppTema1.Properties.Resources.Premier_League;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.History_btn);
            this.Controls.Add(this.Liverpool_btn);
            this.Controls.Add(this.ManCity_btn);
            this.Controls.Add(this.Arsenal_btn);
            this.Controls.Add(this.btn_Tottenham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Tottenham;
        private System.Windows.Forms.Button Arsenal_btn;
        private System.Windows.Forms.Button ManCity_btn;
        private System.Windows.Forms.Button Liverpool_btn;
        private System.Windows.Forms.Button History_btn;
    }
}

