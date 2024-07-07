using Clases;
using Clases_2doParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        AccesoDatos data;
        Taller miTaller;
        XmlManager manager;
        public FrmPrincipal()
        {
            InitializeComponent();
            miTaller = new Taller("UTN221");
            data = new AccesoDatos("localhost", "barcos");
            manager = new XmlManager();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists("Barcos.xml"))
            {
                miTaller.Barcos = manager.Leer("Barcos.xml");
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregar frmAgregar = new FrmAgregar();
                if (frmAgregar.ShowDialog() == DialogResult.OK)
                {
                    data.InsertarBarco(frmAgregar.BarcoFormulario);
                    this.miTaller.IngresarBarco(frmAgregar.BarcoFormulario);
                    MessageBox.Show("Barco cargado exitosamente");
                }
                else
                {
                    MessageBox.Show("Accion cancelada por el usuario. Barco no cargado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.miTaller);
            frmMostrar.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (manager.Guardar("Barcos.xml", this.miTaller.Barcos))
            {
                MessageBox.Show("Se serializo la lista correctamente");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
