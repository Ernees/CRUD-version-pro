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
        Barco barcoFormulario;
        int flag;
        int flagReparado = 0;
        double costo;
        public Barco BarcoFormulario { get => barcoFormulario; }

        public FrmAgregar()
        {
            InitializeComponent();
            Array valoresOperacionees = Enum.GetValues(typeof(EOperacion));
            Array valoresTipo = Enum.GetValues(typeof(ETipo));
            cmbOperacion.DataSource = valoresOperacionees;
            cmbTipo.DataSource = valoresTipo;
            txtId.Enabled = false;
            this.flag = 0;
        }
        public FrmAgregar(Barco bar) : this()
        {
            txtNombre.Text = bar.Nombre;
            cmbOperacion.Text = bar.Operacion.ToString();
            cmbTipo.Text = bar.Tipo.ToString();
            txtTripulacion.Text = bar.Tripulacion.ToString();
            txtId.Text = bar.Id.ToString();
            cmbEstado.Text = bar.Estado;
            costo = bar.Costo;
            if (cmbEstado.Text == "Reparado")
            {
                this.flagReparado = 1;
            }
            if (this.flagReparado == 1)
            {
                cmbOperacion.Text = EOperacion.Sin_Operacion_Pendiente.ToString();
                cmbOperacion.Enabled = false;
            }
            this.flag = 1;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                int id;
                string nombre;
                string estado;
                EOperacion operacion;
                ETipo tipo;
                string tipoString;
                int tripulacion;
                nombre = txtNombre.Text;
                estado = cmbEstado.Text;
                operacion = (EOperacion)cmbOperacion.SelectedItem;
                tipo = (ETipo)cmbTipo.SelectedItem;
                tripulacion = int.Parse(txtTripulacion.Text);
                tipoString = cmbTipo.Text;

                if (tipoString.Equals("Pirata", StringComparison.OrdinalIgnoreCase))
                {
                    barcoFormulario = new Pirata(nombre, estado, operacion, tripulacion, tipo);

                }
                else if (tipoString.Equals("Marina", StringComparison.OrdinalIgnoreCase))
                {
                    barcoFormulario = new Marina(nombre, estado, operacion, tripulacion, tipo);
                    
                }
                if (this.flag == 1)
                {
                    id = int.Parse(txtId.Text);
                    barcoFormulario.Id = id;
                    barcoFormulario.Costo = this.costo;
                }
                else
                {
                    barcoFormulario.CalcularCosto();
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException ex)
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
                }
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstado.Text == "Reparado")
            {
                cmbOperacion.Enabled = false;
            }
            else
            {
                cmbOperacion.Enabled = true;
            }
        }
    }
}
