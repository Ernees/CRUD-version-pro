﻿using Clases;
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
        Taller miTaller;
        DatoEmpleado data;

        public FrmMostrar(Taller empresa)
        {
            InitializeComponent();
            this.miTaller = empresa;
            data = new DatoEmpleado("localhost", "barcos");
            this.miTaller.Barcos = data.SeleccionarEmpleados();
            dataGridEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmpleados.DataSource = this.miTaller.Barcos;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Barco barco;
                DataGridViewRow row = dataGridEmpleados.SelectedRows[0];
                barco = CrearEmpleadoConDatos(row);

                FrmAgregar formModificar = new FrmAgregar(barco);
                formModificar.Text = "Modificar";
                if (formModificar.ShowDialog() == DialogResult.OK)
                {
                    data.ModificarEmpleado(formModificar.BarcoFormulario);
                    MessageBox.Show("(...) Modificado con exito!");
                    refrescarDataGrid(formModificar.BarcoFormulario, row);
                    dataGridEmpleados.DataSource = this.miTaller.Barcos;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Se intento agregar un valor incorrecto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridEmpleados.SelectedRows[0];
            Barco emp;
            int indice;
            indice = dataGridEmpleados.SelectedRows[0].Index;
            emp = CrearEmpleadoConDatos(row);

            FrmAgregar frmDel = new FrmAgregar(emp);
            frmDel.bloquearTextboxes();
            frmDel.bloquearComboBox();
            frmDel.Text = "Eliminar";

            if (frmDel.ShowDialog() == DialogResult.OK)
            { 
                this.miTaller.Barcos.RemoveAt(indice);
                data.EliminarEmpleado(frmDel.BarcoFormulario.Id);
                MessageBox.Show("(..) Eliminado con exito");
                this.miTaller.Barcos = data.SeleccionarEmpleados();
                dataGridEmpleados.DataSource = this.miTaller.Barcos;
            }
        }
        private void refrescarDataGrid(Barco barco, DataGridViewRow fila)
        {
            fila.Cells["Id"].Value = barco.Id;
            fila.Cells["Nombre"].Value = barco.Nombre;
            fila.Cells["Estado"].Value = barco.Estado;
            fila.Cells["operacion"].Value = barco.Operacion;
            fila.Cells["Tripulacion"].Value = barco.Tripulacion;
            fila.Cells["Costo"].Value = barco.Costo;
            fila.Cells["Tipo"].Value = barco.Tipo;
        }
        private Barco CrearEmpleadoConDatos(DataGridViewRow fila)
        {
            Barco barco = null;
            string id = fila.Cells["Id"].Value.ToString();
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string estado = fila.Cells["Estado"].Value.ToString();
            EOperacion operacion = (EOperacion)fila.Cells["operacion"].Value;
            string tripulacion = fila.Cells["Tripulacion"].Value.ToString();
            string costo = fila.Cells["Costo"].Value.ToString();
            ETipo tipo = (ETipo)fila.Cells["Tipo"].Value;
            string tipoString = fila.Cells["Tipo"].Value.ToString();
            if (tipoString == "Pirata")
            {
                barco = new Pirata(nombre, estado, operacion, int.Parse(tripulacion), tipo);
            }
            else if (tipoString == "Marina")
            {
                barco = new Marina(nombre, estado, operacion, int.Parse(tripulacion), tipo);
            }
            barco.Id = int.Parse(id);

            return barco;
        }
    }
}
