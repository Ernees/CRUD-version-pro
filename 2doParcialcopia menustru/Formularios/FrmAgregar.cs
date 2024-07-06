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

namespace Formularios
{
    public partial class FrmAgregar : Form
    {
        Empleado empleadoFormulario;
        int flag;
        public Empleado EmpleadoFormulario { get => empleadoFormulario; }

        public FrmAgregar()
        {
            InitializeComponent();
            txtId.Enabled = false;
            this.flag = 0;
        }
        public FrmAgregar(Empleado emp) : this()
        {
            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;
            cbDepartamento.Text = emp.Departamento;
            txtEdad.Text = emp.Edad.ToString();
            txtId.Text = emp.Id.ToString();
            this.flag = 1;
        }
        //public FrmAgregar(Empleado emp, string elim) : this(emp)
        //{
        //    txtNombre.Enabled = false;
        //    txtApellido.Enabled = false;
        //    txtEdad.Enabled = false;
        //    cbDepartamento.Enabled = false;
        //    this.flag = 1;
        //}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre;
                string apellido;
                string departamento;
                int edad;
                int id;
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                departamento = cbDepartamento.Text;
                edad = int.Parse(txtEdad.Text);
                empleadoFormulario = new Empleado(nombre, apellido, edad, departamento);
                if (this.flag == 1)
                {
                    id = int.Parse(txtId.Text);
                    empleadoFormulario.Id = id;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Se intento agregar un valor incorrecto");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void bloquearTextboxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                    //tb.ReadOnly = true;
                }
            }
        }
        public void bloquearComboBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox tb = (ComboBox)c;
                    tb.Enabled = false;
                    //tb.ReadOnly = true;
                }
            }
        }

    }
}
