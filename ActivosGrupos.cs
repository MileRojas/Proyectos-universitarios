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
    public partial class ActivosGrupos : Form
    {
        public ActivosGrupos()
        {
            InitializeComponent();
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            //-***************************Cargar textbox 1 de todos los colores
            //DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            String strSql;
            strSql = "SPSelectTA";
            SqlDataAdapter da1 = new SqlDataAdapter(strSql, conexion);
            conexion.Open();
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.Fill(dt1);
            conexion.Close();
            DataRow fila1 = dt1.NewRow();
            //dt1.Rows.InsertAt(fila1, 0);
            cbTipoActivo.ValueMember = "CodTipoActivo";
            cbTipoActivo.DisplayMember = "TipoActivo";
            cbTipoActivo.DataSource = dt1;

            DataTable dt = new DataTable();
            String strSql1;
            strSql1 = "SPPersonal";
            SqlDataAdapter da = new SqlDataAdapter(strSql1, conexion);
            conexion.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            conexion.Close();
            DataRow fila = dt.NewRow();
            cmbResponsable.ValueMember = "numEmpleado";
            cmbResponsable2.ValueMember = "numEmpleado";
            cmbResponsable.DisplayMember = "numEmpleado";
            cmbResponsable2.DisplayMember = "numEmpleado";
            cmbResponsable.DataSource = dt;
            cmbResponsable2.DataSource = dt;

        }
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-L27R9A5G\SISTEMAS;Initial Catalog=Sistemas1;User ID=sa; password=sistemas");

        private void cbTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cbTipoActivo_SelectedValueChanged(object sender, EventArgs e)
        {
   
        }

        private void cbTipoActivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //textBox1.Text = Convert.ToString(s);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SPSActivoTipoActivo", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@CodTipoActivo", SqlDbType.Int, 10);
                da.SelectCommand.Parameters["@CodTipoActivo"].Value = cbTipoActivo.SelectedValue;
                da.Fill(dt);
                dgvActivos.DataSource = dt;
                dgvActivos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[2].Value.ToString();
            cmbUbicacion.SelectedItem = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[3].Value.ToString();
            //cmbResponsable.SelectedItem = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[4].Value.ToString();
            if (cmbGrupo.SelectedIndex == 1)
            {
                cmbResponsable.SelectedItem = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[4].Value.ToString();
            }
            dtpFecha.Text = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[5].Value.ToString();
            txtValor.Text = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[6].Value.ToString();
            //PBFoto.BackgroundImage =Convert.ToSByte(dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[7].Value);
            try
            {
                using (SqlCommand cmd = conexion.CreateCommand())
                {
                    conexion.Open();
                    cmd.CommandText = "Select imagen from activos where codGenerado=@codGenerado ";
                    cmd.Parameters.Add("@codGenerado", SqlDbType.VarChar).Value = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[0].Value.ToString();
                    byte[] arrImg = (byte[])cmd.ExecuteScalar();
                    conexion.Close();
                    MemoryStream ms = new MemoryStream(arrImg);
                    Image img = Image.FromStream(ms);
                    ms.Close();
                    PBFoto.Image = img;
                    PBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }        

        private void btnFoto_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRutaFoto.Text == "")
            {

            }
            else
            {
                //para la fotografia
                string filefoto = "";
                filefoto = lblFotografia.Text;                
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(filefoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                ms.SetLength(fs.Length);
                fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                byte[] arrimg = ms.GetBuffer();
                ms.Flush();
                fs.Close();
                //acaba codigo de fotografia
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SPActualizarFoto";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
                conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@codGenerado", SqlDbType.VarChar).Value = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[0].Value.ToString();
                da.SelectCommand.Parameters.AddWithValue("@imagen", arrimg);
                da.Fill(dt);
                conexion.Close();
 
            }

            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SPActivoM";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
                conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@cod", SqlDbType.VarChar).Value = dgvActivos.Rows[dgvActivos.CurrentRow.Index].Cells[0].Value.ToString();
                da.SelectCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                da.SelectCommand.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                da.SelectCommand.Parameters.AddWithValue("@Ubicacion", cmbUbicacion.SelectedItem);
                da.SelectCommand.Parameters.AddWithValue("@Responsable", cmbResponsable.SelectedValue);
                da.SelectCommand.Parameters.AddWithValue("@FechaCompra", dtpFecha.Text);
                da.SelectCommand.Parameters.AddWithValue("@ValorCompra", txtValor.Text);
                da.Fill(dt);
                conexion.Close();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtValor.Clear();
                txtRutaFoto.Clear();
                lblFotografia.Text="";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                MessageBox.Show("Se guardo correctamente");
            }
        }

        private void cmbGrupo_TextChanged(object sender, EventArgs e)
        {
            if (cmbGrupo.SelectedIndex == 1)
            {
                cmbResponsable2.Enabled = false;
                cbTipoActivo.Enabled = true;
            }
            else
            {
                if (cmbGrupo.SelectedIndex == 0)
                {
                    cbTipoActivo.Enabled = false;
                    cmbResponsable2.Enabled = true;
                }
            }
        }

        private void cmbResponsable2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //textBox1.Text = Convert.ToString(s);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SPSelectResponsable", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Responsable", SqlDbType.Int, 10);
                da.SelectCommand.Parameters["@Responsable"].Value = cmbResponsable2.SelectedValue;
                da.Fill(dt);
                dgvActivos.DataSource = dt;
                dgvActivos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        
    }
}
