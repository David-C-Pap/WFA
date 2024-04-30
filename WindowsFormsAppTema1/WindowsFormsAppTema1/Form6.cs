using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTema1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn_liverpoolAntrenor_Click(object sender, EventArgs e)
        {
            tb_antrenorLiverpool.Text = "Jurgen Klopp";

        }

        private void btn_liverpoolStadium_Click(object sender, EventArgs e)
        {
            tb_liverpoolStadium.Text = "Anfield Road";
        }

        private void btn_actualPlayers_Click(object sender, EventArgs e)
        {
            string[] nume_jucatori = new string[7];
            nume_jucatori[0] = "Alexander-Arnold";
            nume_jucatori[1] = "Joel Matip";
            nume_jucatori[2] = "Virgil Van Dijk";
            nume_jucatori[3] = "Alisson Becker";
            nume_jucatori[4] = "Darwin Nunez";
            nume_jucatori[5] = "Diogo Jota";
            nume_jucatori[6] = "Roberto-Firmino";
            for(int i=0;i<7;i++)
            {
                lb_actualPlayers.Items.Add(nume_jucatori[i]);
            }
        }

        private void btn_unusedPlayers_Click(object sender, EventArgs e)
        {
            string[] jucatori_nefolositi = new string[4];
            jucatori_nefolositi[0] = "Oxlade-Chamberlain";
            jucatori_nefolositi[1] = "Jordan Henderson";
            jucatori_nefolositi[2] = "James Milner";
            jucatori_nefolositi[3] = "Luis Diaz";
            for (int i = 0;i<4;i++)
            {
                lb_unusedPlayers.Items.Add(jucatori_nefolositi[i]);
            }
        }

        private void btn_moveToUnused_Click(object sender, EventArgs e)
        {
            if(lb_actualPlayers.SelectedItem!=null)
            {
                object selectedItem = lb_actualPlayers.SelectedItem;
                lb_unusedPlayers.Items.Add(selectedItem);
                lb_actualPlayers.Items.Remove(selectedItem);
            }
        }

        private void btn_displayFormula_Click(object sender, EventArgs e)
        {
            RadioButton[] butoane_jucatori = new RadioButton[3];
            butoane_jucatori[0] = Salah_radioButton;
            butoane_jucatori[1] = Henderson_radioButton;
            butoane_jucatori[2] = Robertson_radioButton;

            RadioButton[] butoane_pozitie = new RadioButton[3];
            butoane_pozitie[0] = Atacant_radioButton;
            butoane_pozitie[1] = Mijlocas_radioButton;
            butoane_pozitie[2] = Fundas_radioButton;

            RadioButton[] butoane_tip_pozitie = new RadioButton[5];
            butoane_tip_pozitie[0] = Central_radioButton;
            butoane_tip_pozitie[1] = AripaStanga_radioButton;
            butoane_tip_pozitie[2] = AripaDreapta_radioButton;
            butoane_tip_pozitie[3] = Ofensiv_radioButton;
            butoane_tip_pozitie[4] = Defensiv_radioButton;
            foreach(RadioButton rj in butoane_jucatori)
            {
                foreach(RadioButton rp in butoane_pozitie)
                {
                    foreach(RadioButton rtp in butoane_tip_pozitie)
                    {
                        if(rj.Checked && rp.Checked && rtp.Checked)
                        {
                            MessageBox.Show(" Jurgen Klopp a selectat jucatorul " + rj.Text + " pe pozitia de  " + rp.Text + " " + rtp.Text);
                        }
                    }
                }
            }

        }

        private void btn_selectatiJucator_Click(object sender, EventArgs e)
        {
            contextMenuStripPlayers.Show(btn_selectatiJucator, 0, 0);
        }

        private void contextMenuStripPlayers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Image[] imagini_tari = new Image[3];
            imagini_tari[0] = Image.FromFile(@"C:\Users\user\Desktop\Poze_II2\Egipt.jpg");
            imagini_tari[1] = Image.FromFile(@"C:\Users\user\Desktop\Poze_II2\Brazilia.jpg");
            imagini_tari[2] = Image.FromFile(@"C:\Users\user\Desktop\Poze_II2\Anglia.jpg");
            string obiect_selectat = e.ClickedItem.Text;
            if(obiect_selectat=="Salah")
            {
                pictureBoxNational.Image = imagini_tari[0];
                pictureBoxNational.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if(obiect_selectat=="Firmino")
            {
                pictureBoxNational.Image = imagini_tari[1];
                pictureBoxNational.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if(obiect_selectat=="Henderson")
            {
                pictureBoxNational.Image = imagini_tari[2];
                pictureBoxNational.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            

        }

        private void btn_clearLiverpool_Click(object sender, EventArgs e)
        {
            tb_antrenorLiverpool.Text = "";
            tb_liverpoolStadium.Text = "";
            lb_actualPlayers.Items.Clear();
            lb_unusedPlayers.Items.Clear();
            pictureBoxNational.Image = null;
        }
    }
}
