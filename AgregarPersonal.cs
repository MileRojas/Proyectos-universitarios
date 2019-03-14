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
    public partial class AgregarPersonal : Form
    {

        string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
        public AgregarPersonal()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtApeM.Clear();
            txtApeP.Clear();
            txtCargo.Clear();
            txtFuncion.Clear();
            txtNom.Clear();
            txtNumEmpleado.Clear();
            txtSN.Clear();
            txtSocio.Clear();
                    
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool success = false;
            SqlConnection LaConexion = null;
            SqlTransaction LaTransaccion = null;
            int Valor_Retornado = 0;
            try
            {
                LaConexion = new SqlConnection();
                LaConexion.ConnectionString = cadenaconexion;
                LaConexion.Open();
                LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                SqlCommand comando = new SqlCommand("SPPersonalA", LaConexion, LaTransaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@numEmpleado", txtNumEmpleado.Text);
                comando.Parameters.AddWithValue("@Nombre", txtNom.Text);
                comando.Parameters.AddWithValue("@SegundoNombre", txtSN.Text);
                comando.Parameters.AddWithValue("@ApPaterno", txtApeP.Text);
                comando.Parameters.AddWithValue("@ApMaterno", txtApeM.Text);
                comando.Parameters.AddWithValue("@Funcion", txtFuncion.Text);
                comando.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                comando.Parameters.AddWithValue("@SocioNegocio", txtSocio.Text);
                comando.Parameters.AddWithValue("@TipoEmpleado", cmbTipoEmpleado.SelectedItem);
                SqlParameter ValorRetorno = new SqlParameter("@Comprobacion", SqlDbType.Int);
                ValorRetorno.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ValorRetorno);
                comando.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                if (Valor_Retornado == 1)
                    success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error en la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (success)
                {
                    LaTransaccion.Commit();
                    LaConexion.Close();
                    MessageBox.Show("Guardado\nsatisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    LaTransaccion.Rollback();
                    LaConexion.Close();
                }
            }

        }
    }
}
