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
        
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salva\source\repos\Semana-7-Login-con-base-de-datos\basededatosaccess\Database1.mdb");
        
        public Form1()
        {
            InitializeComponent();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {



                conexion.Open();
                MessageBox.Show("Conectada");
           
            }
            catch (Exception a)
            {

                MessageBox.Show("Error por: " + a.ToString());
            
            }


        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            string consulta = "select clave, usuario from usuarios where clave ='" + txtpass.Text + "' and usuario = '" + txtusuario.Text + "';";
            OleDbCommand comando = new OleDbCommand(consulta , conexion);
            OleDbDataReader leedb;
            leedb = comando.ExecuteReader();
            Boolean existereg = leedb.HasRows;
            if (existereg)
            {
                MessageBox.Show("bienvenido al sistema" + txtusuario.Text);
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto trate de nuevo");
                return;
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
  }
