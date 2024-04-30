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
    public partial class Form2 : Form
    {
        public static object lb_arsenalTitularii { get; internal set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void btn_selectati_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btn_selectati, 0, 0);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string item_selectat = e.ClickedItem.Text;
            if(item_selectat=="2010-2011" || item_selectat=="2012-2013")
            {
                tb_rezultat.Text = "Man-United";
            }
            if (item_selectat == "2011-2012" || item_selectat == "2013-2014" || item_selectat == "2017-2018" || item_selectat == "2018-2019" || item_selectat == "2020-2021" || item_selectat == "2021-2022")
            {
                tb_rezultat.Text = "Man-City";
            }
            if(item_selectat=="2019-2020")
            {
                tb_rezultat.Text = "Liverpool";
            }
            if(item_selectat=="2014-2015" || item_selectat=="2016-2017")
            {
                tb_rezultat.Text = "Chelsea";
            }
            if(item_selectat=="2015-2016")
            {
                tb_rezultat.Text = "Leicester-City";
            }
        }

        private void btn_playersel_Click(object sender, EventArgs e)
        {
            string[] jucatori = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Jucatori.txt");
            foreach(string jucator in jucatori)
            {
                lb_top_players.Items.Add(jucator);
            }
        }

        private void btn_coachessel_Click(object sender, EventArgs e)
        {
            string[] antrenori = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Antrenori.txt");
            foreach(string antrenor in antrenori)
            {
                lb_top_coaches.Items.Add(antrenor);
            }
        }

        private void btn_bugetEchipe_Click(object sender, EventArgs e)
        {
            tb_echipe15.Text = "4.595";
            tb_echipe610.Text = "2.505";
            tb_echipe1115.Text = "1.837";
            tb_echipe1620.Text = "1.441";
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            tb_bugettotal.Text = (Convert.ToDouble(tb_echipe15.Text) + Convert.ToDouble(tb_echipe610.Text) + Convert.ToDouble(tb_echipe1115.Text) + Convert.ToDouble(tb_echipe1620.Text)).ToString();
            double medium;
            medium = (Convert.ToDouble(tb_echipe15.Text) + Convert.ToDouble(tb_echipe610.Text) + Convert.ToDouble(tb_echipe1115.Text) + Convert.ToDouble(tb_echipe1620.Text)) / 5;
            tb_bugetmediu.Text = medium.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_echipe15.Text = "";
            tb_echipe610.Text = "";
            tb_echipe1115.Text = "";
            tb_echipe1620.Text = "";
            tb_bugetmediu.Text = "";
            tb_bugettotal.Text = "";
            lb_top_coaches.Items.Clear();
            lb_top_players.Items.Clear();
            tb_rezultat.Text = "";
        }
    }
}
