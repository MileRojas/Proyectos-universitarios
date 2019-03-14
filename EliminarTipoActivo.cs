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
    public partial class EliminarTipoActivo : Form
    {
        public EliminarTipoActivo()
        {
            InitializeComponent();
            Cargar_Datos();
            cargartipo();
        }
        public void Cargar_Datos()
        {
            //-***************************Cargar textbox 1 de todos los colores
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            String strSql;
            strSql = "SPSelectTA";

            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            SqlDataAdapter da1 = new SqlDataAdapter(strSql, conexion);

            conexion.Open();
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;

            da1.Fill(dt1);
            conexion.Close();

            //DataRow fila = dt.NewRow();
            DataRow fila1 = dt1.NewRow();
            //dt1.Rows.InsertAt(fila1, 0);
            comboBox1.ValueMember = "CodTipoActivo";
            comboBox1.DisplayMember = "TipoActivo";
            comboBox1.DataSource = dt1;
        }
        private void cargartipo()
        {
            try
            {
                //textBox1.Text = Convert.ToString(s);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("SPSelectTA1", conexion);
                da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                da1.Fill(dt1);
                dgvTipoActivo.DataSource = dt1;
                dgvTipoActivo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");
        
        private void button1_Click(object sender, EventArgs e)
        {
            //***********************MODIFICAR COLOR**----------------
            DataTable dt = new DataTable();
            String strSql;
            strSql = "SPTipoActivoE";

            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);

            conexion.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@codTipoActivo", SqlDbType.VarChar).Value = comboBox1.SelectedValue;
            da.Fill(dt);

            conexion.Close();
            //volvemos a cargar datos
            Cargar_Datos();
            MessageBox.Show("Se Eliminó Correctamente");
            cargartipo();
            
        }
    }
}
