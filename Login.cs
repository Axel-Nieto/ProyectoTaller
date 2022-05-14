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

namespace ProyectoTaller
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=taller; Integrated Security=True;");

        public void logear(string user, string pass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM Usuarios WHERE Usuario = @usr AND Password = @pwd",con);
                cmd.Parameters.AddWithValue("usr", user);
                cmd.Parameters.AddWithValue("pwd", pass);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][1].ToString() == "Admin")
                {
                    MessageBox.Show("Se abre la ventana de Admin");
                }
                else if (dt.Rows[0][1].ToString() == "Usuario")
                {
                    MessageBox.Show("Se abre la ventana de Usuario");
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.TextboxUsuario.Text,this.TextboxPassword.Text);
        }

        private void TextboxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
