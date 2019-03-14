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
    public partial class Personal : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");
        
        public Personal()
        {
            InitializeComponent();
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            //-***************************Cargar TIPO DE ACTIVO
            DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            //String strSql1;
            String strSql;
            strSql = "SPPersonal";
            //strSql1 = "SPPersonal";
            //SqlDataAdapter da = new SqlDataAdapter(strSql1, conexion);
            SqlDataAdapter da1 = new SqlDataAdapter(strSql, conexion);
            conexion.Open();
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.Fill(dt);
            da1.Fill(dt);
            conexion.Close();
            DataRow fila1 = dt.NewRow();
            //fila1["TipoActivo"] = "seleciona un tipo";
            /*dt1.Rows.InsertAt(fila1, 0);
            cmbResponsable.ValueMember = "numEmpleado";
            cmbResponsable.DisplayMember = "numEmpleado";
            cmbResponsable.DataSource = dt;*/
            comboBox1.ValueMember = "numEmpleado";
            comboBox1.DisplayMember = "numEmpleado";
            comboBox1.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SPPersonalE";

                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);

                conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@codEmpleado", SqlDbType.VarChar).Value = comboBox1.SelectedValue;
                da.Fill(dt);

                conexion.Close();
                //volvemos a cargar datos
                //Cargar_Datos();
                MessageBox.Show("Se Eliminó Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
