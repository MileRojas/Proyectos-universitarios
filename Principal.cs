using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activos
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void tipoActToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTipo at = new AgregarTipo();
            at.MdiParent = this;
            at.Show();
        }

      
        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos a = new Activos();
            a.Show();
        }

        private void activoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarActivo aa = new AgregarActivo();
            aa.MdiParent = this;
            aa.Show();
        }

        private void codigoDeBarrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EliminarTipoActivo eta = new EliminarTipoActivo();
            eta.MdiParent = this;
            eta.Show();
        }

        private void tiposDeActivosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TiposActivos ta = new TiposActivos();
            ta.MdiParent = this;
            ta.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void acToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void activoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Eliminar_Activo ea = new Eliminar_Activo();
            ea.MdiParent = this;
            ea.Show();
        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersonal ap = new AgregarPersonal();
            ap.MdiParent = this;
            ap.Show();
        }

        private void personalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Personal p = new Personal();
            p.MdiParent = this;
            p.Show();
        }

        private void soloUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos a = new Activos();
            a.MdiParent = this;
            a.Show();
        }

        private void porGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivosGrupos ag = new ActivosGrupos();
            ag.MdiParent = this;
            ag.Show();
        }
    }
}
