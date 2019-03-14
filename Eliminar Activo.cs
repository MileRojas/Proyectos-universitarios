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

namespace Activos
{
    public partial class Eliminar_Activo : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");

        public Eliminar_Activo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            try
            {
                //*****MUESTRA LOS DATOS DEL ELEMENTO SELECCIONADO EN LOS TEXTBOX
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_CodigoBarras", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = codigo;
                SqlDataReader Leer = cmd.ExecuteReader();
                if (Leer.Read() == true)
                {
                    txtNombre.Text = Leer["Nombre"].ToString();
                    txtDescripcion.Text = Leer["Descripcion"].ToString();

                }
                else
                {
                    MessageBox.Show("El codigo Buscado NO EXISTE!");
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SPCodigoBarrasE";

                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);

                conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@cod", SqlDbType.VarChar).Value = txtCodigo.Text;
                da.Fill(dt);

                conexion.Close();
                //volvemos a cargar datos
                //Cargar_Datos();
                MessageBox.Show("Se Eliminó Correctamente");
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
