using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTema2
{
    public partial class Form1 : Form
    {
        DataTable table_forGrid;
        private string conexiune_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Valean_II\WebApplicationTema2\WebApplicationTema2\App_Data\Database1.mdf;Integrated Security=True";
        WindowsFormsApplicationTema2.ServiceReference1.WebServiceTema2SoapClient serviciu_form = new WindowsFormsApplicationTema2.ServiceReference1.WebServiceTema2SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_refreshEchipe_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Valean_II\WebApplicationTema2\WebApplicationTema2\App_Data\Database1.mdf;Integrated Security=True");
            conexiune.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM echipePremierLeague", conexiune);
            SqlCommandBuilder sqlcommandBuilder = new SqlCommandBuilder(adapter);
            table_forGrid = new DataTable();
            adapter.Fill(table_forGrid);
            dataGridView1.DataSource = table_forGrid;
            adapter.Update(table_forGrid);
            conexiune.Close();
        }

        private void btn_refreshJucatori_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Valean_II\WebApplicationTema2\WebApplicationTema2\App_Data\Database1.mdf;Integrated Security=True");
            conexiune.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM jucatoriPremierLeague", conexiune);
            SqlCommandBuilder sqlcommandBuilder = new SqlCommandBuilder(adapter);
            table_forGrid = new DataTable();
            adapter.Fill(table_forGrid);
            dataGridView2.DataSource = table_forGrid;
            adapter.Update(table_forGrid);
            conexiune.Close();
        }

        private void btn_modifyTeam_Click(object sender, EventArgs e)
        {
            try
            {
                serviciu_form.modificare(Convert.ToInt16(tb_No_trophies.Text), Convert.ToInt16(tb_Code.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Eroare la introducerea datelor");
            }
        }

        private void btn_deleteTeam_Click(object sender, EventArgs e)
        {
            try
            {
                serviciu_form.stergere(Convert.ToInt16(tb_CodeToDelete.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Eroare la introducerea datelor");
            }
        }

        private void btn_modifyPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                serviciu_form.modificare_jucatori(tb_Position.Text, Convert.ToInt16(tb_Id.Text), Convert.ToInt16(tb_CodeofTeam.Text));

            }catch(Exception ex)
            {
                MessageBox.Show("Eroare la introducerea datelor");
            }
        }

        private void btn_deletePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                serviciu_form.stergere_jucatori(Convert.ToInt16(tb_IdtoDelete.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Eroare la introducerea datelor");
            }
        }

        private void btn_InsertTeam_Click(object sender, EventArgs e)
        {
            try
            {
                serviciu_form.adaugare(Convert.ToInt16(tb_IdtoInsert.Text), tb_NumeEchipatoInsert.Text, tb_StadiontoInsert.Text, tb_CitytoInsert.Text, Convert.ToInt16(tb_TrofeutoInsert.Text), Convert.ToInt16(tb_CodtoInsert.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Eroare la introducerea datelor ");
            }
        }

        private void btn_InsertPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                serviciu_form.adaugare_jucatori(Convert.ToInt16(tb_IdPlayertoInsert.Text), tb_NumeJucatortoInsert.Text, tb_CountrytoInsert.Text, tb_PositiontoInsert.Text, Convert.ToInt16(tb_CodPtoInsert.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Eroare la introducerea datelor");
            }
        }
    }
}
