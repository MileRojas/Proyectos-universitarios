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
    public partial class AgregarTipo : Form
    {
        public AgregarTipo()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtcodTipoActivo.Clear();
            txtTipoActivo.Clear();
        }
        string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
        bool success = false;
        SqlConnection LaConexion = null;
        SqlTransaction LaTransaccion = null;
        int Valor_Retornado = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodTipoActivo.Text == "" || txtTipoActivo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {

                try
                {
                    LaConexion = new SqlConnection();
                    LaConexion.ConnectionString = cadenaconexion;
                    LaConexion.Open();
                    LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    SqlCommand comando = new SqlCommand("SPTipoActivo", LaConexion, LaTransaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@CodTipoActivo", txtcodTipoActivo.Text);
                    comando.Parameters.AddWithValue("@TipoActivo", txtTipoActivo.Text);
                    SqlParameter ValorRetorno = new SqlParameter("@Comprobacion", SqlDbType.Int);
                    ValorRetorno.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(ValorRetorno);
                    comando.ExecuteNonQuery();
                    Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                    if (Valor_Retornado == 1)
                        success = true;
                }
                catch (Exception)
                {
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
                ////para que muestre todos los tipos de Activos

                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SPSelectTA1", cadenaconexion);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                    dgvTipoActivo.DataSource = dt;
                    dgvTipoActivo.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
