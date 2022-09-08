using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Login
{
    public partial class Form1 : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                connect.Open();
                MessageBox.Show("Conectada");
           
            }
            catch (Exception a)
            {

                MessageBox.Show("Error por: " + a.ToString());
            
            }


        }
    }
}
