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

namespace Activos
{
    public partial class Activos : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");

        public Activos()
        {
            InitializeComponent();
            Cargar_Datos();
            
        }
        public void Cargar_Datos()
        {
            //-***************************Cargar TIPO DE ACTIVO
            DataTable dt = new DataTable();
            String strSql;
            strSql = "SPPersonal";
            SqlDataAdapter da1 = new SqlDataAdapter(strSql, conexion);
            conexion.Open();
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.Fill(dt);
            conexion.Close();
            DataRow fila1 = dt.NewRow();
            cmbResponsable.ValueMember = "numEmpleado";
            cmbResponsable.DisplayMember = "numEmpleado";
            cmbResponsable.DataSource = dt;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = conexion.CreateCommand())
                {
                    conexion.Open();
                    cmd.CommandText = "Select imagen from activos where codGenerado=@codGenerado ";
                    cmd.Parameters.Add("@codGenerado", SqlDbType.VarChar).Value = txtCodigo.Text;
                    byte[] arrImg = (byte[])cmd.ExecuteScalar();
                    conexion.Close();
                    MemoryStream ms = new MemoryStream(arrImg);
                    Image img = Image.FromStream(ms);
                    ms.Close();
                    PBFOTO.Image = img;
                    PBFOTO.SizeMode = PictureBoxSizeMode.StretchImage;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                
                //*****MUESTRA LOS DATOS DEL ELEMENTO SELECCIONADO EN LOS TEXTBOX
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_CodigoBarras", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = txtCodigo.Text;
                SqlDataReader Leer = cmd.ExecuteReader();
                if (Leer.Read() == true)
                {
                    txtNombre.Text = Leer["Nombre"].ToString();
                    txtDescripcion.Text = Leer["Descripcion"].ToString();
                    cmbUbicacion.SelectedItem = Leer["Ubicacion"].ToString();
                    cmbResponsable.SelectedItem = Leer["Responsable"].ToString();
                    dtpFecha.Text = Leer["FechaCompra"].ToString();
                    txtValor.Text = Leer["ValorCompra"].ToString();

                }
                else {
                    MessageBox.Show("El codigo Buscado NO EXISTE!");
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
                //*******PARA LA FOTOGRAFIA*********
                /*string filefoto = "";
                
                filefoto = lblFotografia.Text;
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(filefoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                ms.SetLength(fs.Length);
                fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                byte[] arrimg = ms.GetBuffer();
                ms.Flush();
                fs.Close();*/
                ////*******************************
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SPActivoM";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
                conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@cod", SqlDbType.VarChar).Value = txtCodigo.Text;
                da.SelectCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                da.SelectCommand.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                da.SelectCommand.Parameters.AddWithValue("@Ubicacion", cmbUbicacion.SelectedItem);
                da.SelectCommand.Parameters.AddWithValue("@Responsable", cmbResponsable.SelectedValue);
                da.SelectCommand.Parameters.AddWithValue("@FechaCompra", dtpFecha.Text);
                //da.SelectCommand.Parameters.AddWithValue("@Imagen", arrimg);
                da.SelectCommand.Parameters.AddWithValue("@ValorCompra", txtValor.Text);
                da.Fill(dt);
                conexion.Close();
                MessageBox.Show("Se Guardo Correctamente");
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                //txtResponsable.Clear();
                //txtUbicacion.Clear();
                txtValor.Clear();
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Activos_Load(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            txtValor.Enabled = true;
            dtpFecha.Enabled = true;
            cmbResponsable.Enabled = true;
            cmbUbicacion.Enabled = true;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
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
                PBFOTO.Image = Image.FromFile(Abrir.FileName);
                PBFOTO.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                lblFotografia.Text = "";
                PBFOTO.Image = null;
            }
        }
    }
}
