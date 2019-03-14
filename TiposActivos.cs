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
    public partial class TiposActivos : Form
    {
        //string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");
        
        public TiposActivos()
        {
            InitializeComponent();
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            //-*** CARGA EL COMBOBOX CON TODOS LOS TIPOS DE ACTIVOS
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            String strSql;
            strSql = "SPSelectTA";//nombre procedimiento

            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            SqlDataAdapter da1 = new SqlDataAdapter(strSql, conexion);

            conexion.Open();
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            da1.Fill(dt1);
            conexion.Close();

            //DataRow fila = dt.NewRow();
            DataRow fila1 = dt1.NewRow();
            //dt1.Rows.InsertAt(fila1, 0);
            comboBox1.ValueMember = "CodTA";
            comboBox1.DisplayMember = "TipoActivo";
            comboBox1.DataSource = dt1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable DTtipoactivo = new DataTable();
        private void TiposActivos_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //***GUARDA LOS DATOS MODIFICADOS
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SP_TActivosM1";

                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);

                conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@codTipoA", SqlDbType.VarChar).Value = comboBox1.SelectedValue;

                //  da.SelectCommand.Parameters.AddWithValue("@ID_color", maskedTextBox1.Text);

                da.SelectCommand.Parameters.AddWithValue("@codTA", txtCodigo.Text);
                da.SelectCommand.Parameters.AddWithValue("@TipoActivo", txtTipoActivo.Text);
                da.Fill(dt);

                conexion.Close();
                //volvemos a cargar datos
                Cargar_Datos();
                MessageBox.Show("Se Guardo Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //*****MUESTRA LOS DATOS DEL ELEMENTO SELECCIONADO EN LOS TEXTBOX
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_TipoActivoM", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.Add("@codta", SqlDbType.Int).Value = Convert.ToInt32(comboBox1.SelectedValue);
                
                // cmd.Parameters.Add("@Nombre_color", SqlDbType.Text).Value = textBox3.Text;

                SqlDataReader Leer = cmd.ExecuteReader();
                if (Leer.Read() == true)
                {
                    txtCodigo.Text = Leer["CodTipoActivo"].ToString();
                    txtTipoActivo.Text = Leer["TipoActivo"].ToString();

                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
