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

namespace FrmPrincipal
{
    public partial class FrmCrear : Form
    {
        List<Empleado> listaEmpleados;
        DatoEmpleado data;
        public FrmCrear()
        {
            InitializeComponent();
            data = new DatoEmpleado("localhost", "212_organizacion");
            listaEmpleados = data.SeleccionarEmpleados();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            double sueldo;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            sueldo = double.Parse(txtSueldo.Text);

            Empleado miEmpleado = new Empleado(nombre, apellido, sueldo);

            try
            {
                data.InsertarEmpleado(miEmpleado);
                listaEmpleados.Add(miEmpleado);
                MessageBox.Show("Agregado");
                listaEmpleados = data.SeleccionarEmpleados();
                listBoxEmpleados.DataSource = listaEmpleados;
                limpiarTextBoxes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"ERROR AL INTENTAR DAR DE ALTA: {ex.Message}");
            }
        }
    }
}
