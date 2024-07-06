using Clases;
using Clases_2doParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMostrar : Form
    {
        Entidad miEmpresa;
        DatoEmpleado data;

        public FrmMostrar(Entidad empresa)
        {
            InitializeComponent();
            this.miEmpresa = empresa;
            data = new DatoEmpleado("localhost", "empleados");
            this.miEmpresa.Empleados = data.SeleccionarEmpleados();
            dataGridEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmpleados.DataSource = this.miEmpresa.Empleados;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {

                Empleado emp;
                DataGridViewRow row = dataGridEmpleados.SelectedRows[0];
                emp = CrearEmpleadoConDatos(row);

                FrmAgregar formModificar = new FrmAgregar(emp);
                formModificar.Text = "Modificar";
                if (formModificar.ShowDialog() == DialogResult.OK)
                {
                    data.ModificarEmpleado(formModificar.EmpleadoFormulario);
                    MessageBox.Show("(...) Modificado con exito!");
                    refrescarDataGrid(formModificar.EmpleadoFormulario, row);
                    dataGridEmpleados.DataSource = this.miEmpresa.Empleados;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Se intento agregar un valor incorrecto");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error. Comunicarse con sistemas. Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridEmpleados.SelectedRows[0];
            Empleado emp;
            int indice;
            indice = dataGridEmpleados.SelectedRows[0].Index;
            emp = CrearEmpleadoConDatos(row);

            FrmAgregar frmDel = new FrmAgregar(emp);
            frmDel.bloquearTextboxes();
            frmDel.bloquearComboBox();
            frmDel.Text = "Eliminar";

            if (frmDel.ShowDialog() == DialogResult.OK)
            { 
                this.miEmpresa.Empleados.RemoveAt(indice);
                data.EliminarEmpleado(frmDel.EmpleadoFormulario.Id);
                MessageBox.Show("(..) Eliminado con exito");
                this.miEmpresa.Empleados = data.SeleccionarEmpleados();
                dataGridEmpleados.DataSource = this.miEmpresa.Empleados;
            }
        }
        private void refrescarDataGrid(Empleado emp, DataGridViewRow fila)
        {
            fila.Cells["Id"].Value = emp.Id;
            fila.Cells["Nombre"].Value = emp.Nombre;
            fila.Cells["Apellido"].Value = emp.Apellido;
            fila.Cells["Edad"].Value = emp.Edad;
            fila.Cells["Departamento"].Value = emp.Departamento;
        }
        private Empleado CrearEmpleadoConDatos(DataGridViewRow fila)
        {
            string id = fila.Cells["Id"].Value.ToString();
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string apellido = fila.Cells["Apellido"].Value.ToString();
            string edad = fila.Cells["Edad"].Value.ToString();
            string departamento = fila.Cells["Departamento"].Value.ToString();
            Empleado empleado = new Empleado(nombre, apellido, int.Parse(edad), departamento);
            empleado.Id = int.Parse(id);

            return empleado;
        }
    }
}
