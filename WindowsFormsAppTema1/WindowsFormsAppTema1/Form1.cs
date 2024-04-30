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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void History_btn_Click(object sender, EventArgs e)
        {
            Form2 historyform = new Form2();
            historyform.Show();
        }

        private void btn_Tottenham_Click(object sender, EventArgs e)
        {
            Form3 tottenhamform = new Form3();
            tottenhamform.Show();
        }

        private void Arsenal_btn_Click(object sender, EventArgs e)
        {
            Form4 arsenalform = new WindowsFormsAppTema1.Form4();
            arsenalform.Show();
        }

        private void ManCity_btn_Click(object sender, EventArgs e)
        {
            Form5 mancityform = new Form5();
            mancityform.Show();
        }

        private void Liverpool_btn_Click(object sender, EventArgs e)
        {
            Form6 liverpoolform = new WindowsFormsAppTema1.Form6();
            liverpoolform.Show();
        }
    }
}
