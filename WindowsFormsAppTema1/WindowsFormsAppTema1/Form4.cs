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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_arsenalAntrenor_Click(object sender, EventArgs e)
        {
            tb_afiseazaArsenalAntrenor.Text = "Mikel-Arteta";
        }

        private void btn_arsenalTitularii_Click(object sender, EventArgs e)
        {
            string[] titulari = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Arsenal.txt");
            foreach (string titular in titulari)
            {
                lb_arsenalTitularii.Items.Add(titular);
            }
        }

        private void btn_arsenalRezerve_Click(object sender, EventArgs e)
        {
            string[] rezerve = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Arsenalr.txt");
            foreach (string rezerva in rezerve)
            {
                lb_arsenalRezerve.Items.Add(rezerva);
            }
        }

        private void btn_mutatitularArsenal_Click(object sender, EventArgs e)
        {
            if (lb_arsenalTitularii.SelectedItem != null)
            {
                object selectedItem = lb_arsenalTitularii.SelectedItem;
                lb_arsenalRezerve.Items.Add(selectedItem);
                lb_arsenalTitularii.Items.Remove(selectedItem);
            }
        }

        private void btn_mutarezervaArsenal_Click(object sender, EventArgs e)
        {
            if (lb_arsenalRezerve.SelectedItem != null)
            {
                object selectedItem = lb_arsenalRezerve.SelectedItem;
                lb_arsenalTitularii.Items.Add(selectedItem);
                lb_arsenalRezerve.Items.Remove(selectedItem);
            }
        }

        private void btn_clearArsenal_Click(object sender, EventArgs e)
        {
            lb_arsenalRezerve.Items.Clear();
            lb_arsenalTitularii.Items.Clear();
            tb_afiseazaArsenalAntrenor.Text = "";
            tb_arsenalHighestValue.Text = "";
            tb_arsenalTopPlayer.Text = "";
            arsenalPictureBox.Image = null;

        }

        private void btn_arsenalBest_Click(object sender, EventArgs e)
        {
            string[] linii = System.IO.File.ReadAllLines("C:\\Users\\user\\Desktop\\Valean_II\\Arsenal.txt");
            int contor1 = 0;
            string[] nume_fotbalisti = new string[15];
            int[] valoare_fotbalisti = new int[15];
            for (int contor = 0; contor < linii.Length; contor++)
            {
                string[] auxiliar = new string[2];
                auxiliar = linii[contor].Split(',');
                nume_fotbalisti[contor1] = auxiliar[0].ToString();
                valoare_fotbalisti[contor1] = Convert.ToInt16(auxiliar[1]);
                contor1++;
            }
            for (int i = 0; i < contor1 - 1; i++)
            {
                for (int j = i + 1; j < contor1; j++)
                {
                    if (valoare_fotbalisti[i] >= valoare_fotbalisti[j])
                    {
                        int aux = valoare_fotbalisti[i];
                        valoare_fotbalisti[i] = valoare_fotbalisti[j];
                        valoare_fotbalisti[j] = aux;
                        string aux1 = nume_fotbalisti[i];
                        nume_fotbalisti[i] = nume_fotbalisti[j];
                        nume_fotbalisti[j] = aux1;
                    }
                }
            }
            tb_arsenalHighestValue.Text = valoare_fotbalisti[contor1 - 1].ToString();
            tb_arsenalTopPlayer.Text = nume_fotbalisti[contor1 - 1].ToString();
        }

        private void btn_pozaArsenal_Click(object sender, EventArgs e)
        {
            Image imagine_arsenal = Image.FromFile(@"C:\Users\user\Desktop\Poze_II2\ArsenalPlayer.jpg");
            arsenalPictureBox.Image = imagine_arsenal;
            arsenalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(Program1.TransferredItems.Count>0)
            {
                lb_arsenalTitularii.Items.AddRange(Program1.TransferredItems.ToArray());
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program1.TransferredItems = lb_arsenalTitularii.Items.Cast<object>().ToList();
        }
    }
}
