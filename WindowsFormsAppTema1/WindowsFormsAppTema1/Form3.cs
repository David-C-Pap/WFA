using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTema1
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Antrenor_Click(object sender, EventArgs e)
        {
            tb_afiseazaAntrenor.Text = "Antonio Conte";
        }

        private void btn_titulari_Click(object sender, EventArgs e)
        {
            string[] titulari = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Tottenham.txt");
            foreach (string titular in titulari)
            {
                lb_titularii.Items.Add(titular);
            }
        }

        private void btn_rezerve_Click(object sender, EventArgs e)
        {
            string[] rezerve = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Tottenhamr.txt");
            foreach (string rezerva in rezerve)
            {
                lb_rezerve.Items.Add(rezerva);
            }
        }

        private void btn_mutaTitular_Click(object sender, EventArgs e)
        {
            if (lb_titularii.SelectedItem != null)
            {
                object selectedItem = lb_titularii.SelectedItem;
                lb_rezerve.Items.Add(selectedItem);
                lb_titularii.Items.Remove(selectedItem);
            }
        }

        private void btn_mutaRezerva_Click(object sender, EventArgs e)
        {
            if (lb_rezerve.SelectedItem != null)
            {
                object selectedItem1 = lb_rezerve.SelectedItem;
                lb_titularii.Items.Add(selectedItem1);
                lb_rezerve.Items.Remove(selectedItem1);
            }
        }

        private void btn_theBest_Click(object sender, EventArgs e)
        {
            string[] linii = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Tottenham.txt");
            int contor1 = 0;
            string[] nume_fotbalisti = new string[15];
            int[] valoare_fotbalisti = new int[15];
            for(int contor=0;contor<linii.Length;contor++)
            {
                string[] auxiliar = new string[2];
                auxiliar = linii[contor].Split(',');
                nume_fotbalisti[contor1] = auxiliar[0].ToString();
                valoare_fotbalisti[contor1] = Convert.ToInt16(auxiliar[1]);
                contor1++;
            }
            for(int i=0;i<contor1-1;i++)
            {
                for(int j=i+1;j<contor1;j++)
                {
                    if(valoare_fotbalisti[i]>=valoare_fotbalisti[j])
                    {
                        int aux = valoare_fotbalisti[i];
                        valoare_fotbalisti[i] =valoare_fotbalisti[j];
                        valoare_fotbalisti[j] = aux;
                        string aux1 = nume_fotbalisti[i];
                        nume_fotbalisti[i] = nume_fotbalisti[j];
                        nume_fotbalisti[j] = aux1;
                    }
                }
            }
            tb_marketValue.Text = valoare_fotbalisti[contor1 - 1].ToString();
            tb_topPlayer.Text = nume_fotbalisti[contor1 - 1].ToString();
        }

        private void btn_clearSpurs_Click(object sender, EventArgs e)
        {
            lb_rezerve.Items.Clear();
            lb_titularii.Items.Clear();
            tb_afiseazaAntrenor.Text = "";
            tb_marketValue.Text = "";
            tb_topPlayer.Text = "";
            pictureBoxspurs.Image = null;
        }

        private void btn_afisareImagine1_Click(object sender, EventArgs e)
        {
            Image imagine_spurs = Image.FromFile(@"C:\Users\user\Desktop\Poze_II2\SpursPlayer.jpg");
            pictureBoxspurs.Image = imagine_spurs;
            pictureBoxspurs.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_transferToArsenal_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            if (lb_titularii.SelectedItems.Count > 0)
                {
                    object selectedItem = lb_titularii.SelectedItem;
                    lb_titularii.Items.Remove(selectedItem);
                    form4.lb_arsenalTitularii.Items.Add(selectedItem);
                }  
        }
    }
}
