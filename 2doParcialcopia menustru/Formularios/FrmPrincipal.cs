﻿using Clases;
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
    public partial class FrmPrincipal : Form
    {
        DatoEmpleado data;
        Taller miEmpresa;
        public FrmPrincipal()
        {
            InitializeComponent();
            miEmpresa = new Taller("UTN221");
            data = new DatoEmpleado("localhost", "barcos");
            miEmpresa.Barcos = data.SeleccionarEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregar frmAgregar = new FrmAgregar();
                if (frmAgregar.ShowDialog() == DialogResult.OK)
                {
                    data.InsertarEmpleado(frmAgregar.BarcoFormulario);
                    this.miEmpresa.IngresarBarco(frmAgregar.BarcoFormulario);
                    //limpiarTextBoxes();
                    MessageBox.Show("Empleado cargado exitosamente");
                }
                else
                {
                    MessageBox.Show("Accion cancelada por el usuario. Desarrollador no cargado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //private void limpiarTextBoxes()
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            TextBox txtBox = (TextBox)c;
        //            txtBox.Clear();
        //        }
        //    }
        //}

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.miEmpresa);
            frmMostrar.Show();
        }
    }
}
