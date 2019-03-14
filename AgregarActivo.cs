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
using System.IO;
using BarcodeLib;
using System.Drawing.Imaging;

namespace Activos
{
    public partial class AgregarActivo :Form
    {
        //string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");
        public AgregarActivo()
        {
            InitializeComponent();
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            //-***************************Cargar TIPO DE ACTIVO
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            String strSql1;
            String strSql;
            strSql = "SPSelectTA";
            strSql1 = "SPPersonal";
            SqlDataAdapter da = new SqlDataAdapter(strSql1, conexion);
            SqlDataAdapter da1 = new SqlDataAdapter(strSql, conexion);
            conexion.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            da1.Fill(dt1);
            conexion.Close();
            DataRow fila1 = dt1.NewRow();
            fila1["TipoActivo"] = "seleciona un tipo";
            dt1.Rows.InsertAt(fila1, 0);
            cmbResponsable.ValueMember = "numEmpleado";
            cmbResponsable.DisplayMember = "numEmpleado";
            cmbResponsable.DataSource = dt;
            comboBox1.ValueMember = "CodTipoActivo";
            comboBox1.DisplayMember = "TipoActivo";
            comboBox1.DataSource = dt1;
        }
        void limpiar()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtNombreActivo.Clear();
            txtRutaFoto.Clear();
            txtValorCompra.Clear();
            PBFoto.Image = null;
            lblFotografia.Text = "";
        }
        
        private void AgregarActivo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //para el codigo de barras
            try
            {
                BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
                codigo.IncludeLabel = true;
                panelResultado.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 400, 100);
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el codigo de barras");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Abrir = new OpenFileDialog();
                Abrir.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png";
                Abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                Abrir.Title = "Seleccionar la foto que desea guardar";
                Abrir.RestoreDirectory = true;

                if (Abrir.ShowDialog() == DialogResult.OK)
                {
                    lblFotografia.Text = Abrir.FileName;
                    txtRutaFoto.Text = Abrir.SafeFileName;
                    PBFoto.Image = Image.FromFile(Abrir.FileName);
                    PBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    lblFotografia.Text = "";
                    PBFoto.Image = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la imagen");
            }
        }

        private void cmbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = txtCodigo.Text + "-" + cmbUbicacion.SelectedItem;      
        }

        private void lblFotografia_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombreActivo.Text == "" || txtValorCompra.Text == "")
            {
                MessageBox.Show("LLene Todos Los Campos");
            }
            else
            {
                string cadenaconexion = @"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas";
                bool success = false;
                SqlConnection LaConexion = null;
                SqlTransaction LaTransaccion = null;
                int Valor_Retornado = 0;
                try
                {
                    //para la fotografia
                    string filefoto = "";
                    filefoto = lblFotografia.Text;
                    if (txtRutaFoto.Text == "")
                    {
                        lblFotografia.Text = "C:\\Users\\hp\\Downloads\\nubes.jpg";
                        filefoto = lblFotografia.Text;
                    }
                    MemoryStream ms = new MemoryStream();
                    FileStream fs = new FileStream(filefoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    ms.SetLength(fs.Length);
                    fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                    byte[] arrimg = ms.GetBuffer();
                    ms.Flush();
                    fs.Close();
                    //acaba codigo de fotografia
                    LaConexion = new SqlConnection();
                    LaConexion.ConnectionString = cadenaconexion;
                    LaConexion.Open();
                    LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    SqlCommand comando = new SqlCommand("SPActivos", LaConexion, LaTransaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@CodActivos", txtCodigo.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombreActivo.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@Ubicacion", cmbUbicacion.SelectedItem);
                    comando.Parameters.AddWithValue("@Responsable", cmbResponsable.SelectedValue);
                    comando.Parameters.AddWithValue("@FechaCompra", dtpFecha.Text);
                    comando.Parameters.AddWithValue("@imagen", arrimg);
                    //comando.Parameters.AddWithValue("@codBarras", arrimg1);
                    comando.Parameters.AddWithValue("@ValorCompra", txtValorCompra.Text);
                    comando.Parameters.AddWithValue("@CodTipoActivo", comboBox1.SelectedValue);
                    //comando.Parameters.AddWithValue("@Nombre", "txtTipoActivo.Text");
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

                }

                finally
                {
                    if (success)
                    {
                        LaTransaccion.Commit();
                        LaConexion.Close();
                        MessageBox.Show("Guardado\nsatisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        LaTransaccion.Rollback();
                        LaConexion.Close();
                    }

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
