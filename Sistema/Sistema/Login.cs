using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class Login : Form

       
    {

        Splash logeo;
        public Login()
        {
            InitializeComponent();

        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-UNRAGT2;database=colegio; integrated security=true ");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta = "select * from Usuario where Usuario='" +txtusuario.Text+ "'and contraseña='" +txtcontra.Text+ "'";
            SqlCommand  comando= new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if(lector.HasRows ==true)
            {
                Splash entrada = new Splash();
                this.Hide();
                entrada.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            conexion.Close();
        }
    }
}
