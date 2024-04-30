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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_antrenorCity_Click(object sender, EventArgs e)
        {
            tb_antrenorCity.Text = "Pep Guardiola";
        }

        private void btn_afiseazaLot_Click(object sender, EventArgs e)
        {
            string[] portari = new string[3];
            portari[0] = "Ederson";
            portari[1] = "Caballero";
            portari[2] = "Claudio_Bravo";
            string[] fundasi = new string[5];
            fundasi[0] = "Manuel_Akanji";
            fundasi[1] = "Nathan_Ake";
            fundasi[2] = "Ruben_Dias";
            fundasi[3] = "John_Stones";
            fundasi[4] = "Kyle_Walker";
            string[] mijlocasiAtacanti = new string[7];
            mijlocasiAtacanti[0] = "Kevin_DeBruyne";
            mijlocasiAtacanti[1] = "Phill_Foden";
            mijlocasiAtacanti[2] = "Jack_Grealish";
            mijlocasiAtacanti[3] = "Iikay_Gundogan";
            mijlocasiAtacanti[4] = "Erling_Haaland";
            mijlocasiAtacanti[5] = "Bernardo_Silva";
            mijlocasiAtacanti[6] = "Rodri";
            for(int i=0;i<3;i++)
            {
                lb_portari.Items.Add(portari[i]);
            }
            for(int i=0;i<5;i++)
            {
                lb_fundasi.Items.Add(fundasi[i]);
            }
            for(int i=0;i<7;i++)
            {
                lb_mijlocasiAndAtacanti.Items.Add(mijlocasiAtacanti[i]);
            }
        }

        private void btn_adaugaPlayer_Click(object sender, EventArgs e)
        {
            if(tb_pozitie.Text=="fundas")
            {
                lb_fundasi.Items.Add(tb_numeJucator.Text);
            }
            if(tb_pozitie.Text=="portar")
            {
                lb_portari.Items.Add(tb_numeJucator.Text);
            }
            if(tb_pozitie.Text=="mijlocas" || tb_pozitie.Text=="atacant")
            {
                lb_mijlocasiAndAtacanti.Items.Add(tb_numeJucator.Text);
            }
        }

        private void btn_clearInregistrare_Click(object sender, EventArgs e)
        {
            tb_numeJucator.Text = "";
            tb_pozitie.Text = "";
        }

        private void btn_clearCity_Click(object sender, EventArgs e)
        {
            tb_antrenorCity.Text = "";
            lb_fundasi.Items.Clear();
            lb_portari.Items.Clear();
            lb_mijlocasiAndAtacanti.Items.Clear();
            tb_numeJucator.Text = "";
            tb_pozitie.Text = "";
        }
    }
}
