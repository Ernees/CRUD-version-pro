using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregar frmAgregar = new FrmAgregar();
                if (frmAgregar.ShowDialog() == DialogResult.OK)
                {
                    data.InsertarEmpleado(frmAgregar.EmpleadoForm);
                    listaEmpleados.Add(frmAgregar.EmpleadoForm);
                    listaEmpleados = data.SeleccionarEmpleados();
                    limpiarTextBoxes();
                    MessageBox.Show("Desarrollador cargado exitosamente");
                }
                else
                {
                    MessageBox.Show("Accion cancelada por el usuario. Desarrollador no cargado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refrescarLista()
        {
            listBox1.Items.Clear();
            foreach (Empleado emp in listaEmpleados)
            {
                listBox1.Items.Add(emp.ToString());
            }
        }
    }
}
