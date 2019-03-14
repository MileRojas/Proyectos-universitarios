using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BarcodeLib;
using System.Data.SqlClient;

namespace Activos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarTipo at = new AgregarTipo();
            at.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codigoDeBarras cb = new codigoDeBarras();
            cb.Show();
        }

        private void tipoActToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTipo at = new AgregarTipo();
            at.Show();
        }

        private void activoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarActivo aa = new AgregarActivo();
            aa.Show();
        }

        private void codigoDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codigoDeBarras cb = new codigoDeBarras();
            cb.Show();
        }

        private void tiposDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposActivos ta = new TiposActivos();
            ta.Show();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos a = new Activos();
            a.Show();
        }

    }
}
