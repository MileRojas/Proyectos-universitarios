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
using BarcodeLib;

namespace Activos
{
    public partial class codigoDeBarras : Form
    {
        public codigoDeBarras()
        {
            InitializeComponent();

            
        }DataTable DTtipoactivo = new DataTable();
        /*string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
        bool success = false;
        SqlConnection LaConexion = null;
        SqlTransaction LaTransaccion = null;
        int Valor_Retornado = 0;*/

        private void codigoDeBarras_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas"))

                try
                {
                   
                    SqlDataAdapter da = new SqlDataAdapter("SPSelectTA", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(DTtipoactivo);
                    //this.dgvConsulta.DataSource = DTtipoactivo;
                    foreach (DataRow row in DTtipoactivo.Rows)
                    {
                        comboBox1.Items.Add(row[2].ToString());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
            codigo.IncludeLabel = true;
            panelResultado.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, textBox1.Text, Color.Black, Color.White, 400, 100);
            btnGuardar.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
            bool success = false;
            SqlConnection LaConexion = null;
            SqlTransaction LaTransaccion = null;
            //int Valor_Retornado = 0;
            try
            {
                LaConexion = new SqlConnection();
                LaConexion.ConnectionString = cadenaconexion;
                LaConexion.Open();
                LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                SqlCommand comando = new SqlCommand("SPSelectActivo", LaConexion, LaTransaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Seleccionado", "2");
                comando.ExecuteNonQuery();
                DataRow[] result = DTtipoactivo.Select("CodTA=''");

                DataTable dt = new DataTable();
                textBox1.Text = result[0].ItemArray[0].ToString();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                //   this.dgvConsulta.DataSource = dt;
                foreach (DataRow row in dt.Rows)
                {
                    comboBox2.Items.Add(row[2].ToString());

                }

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
                    MessageBox.Show("Persona guardada\nsatisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    LaTransaccion.Rollback();
                    LaConexion.Close();

                }

            }
        
            }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
         
    }

}
