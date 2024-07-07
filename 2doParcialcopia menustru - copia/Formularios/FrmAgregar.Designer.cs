using System.Drawing;
using System.Windows.Forms;

namespace Formularios
{
    partial class FrmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblEstado = new Label();
            lblOperacion = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblTripulacion = new Label();
            lblTipo = new Label();
            txtId = new TextBox();
            txtTripulacion = new TextBox();
            cmbOperacion = new ComboBox();
            label1 = new Label();
            cmbEstado = new ComboBox();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(23, 93);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(23, 130);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(62, 15);
            lblOperacion.TabIndex = 5;
            lblOperacion.Text = "Operacion";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(48, 305);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(95, 45);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(198, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTripulacion
            // 
            lblTripulacion.AutoSize = true;
            lblTripulacion.Location = new Point(23, 205);
            lblTripulacion.Name = "lblTripulacion";
            lblTripulacion.Size = new Size(65, 15);
            lblTripulacion.TabIndex = 12;
            lblTripulacion.Text = "Tripulacion";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(23, 170);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo";
            // 
            // txtId
            // 
            txtId.Location = new Point(208, 240);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 9;
            // 
            // txtTripulacion
            // 
            txtTripulacion.Location = new Point(208, 202);
            txtTripulacion.Name = "txtTripulacion";
            txtTripulacion.Size = new Size(121, 23);
            txtTripulacion.TabIndex = 8;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(208, 127);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 243);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Reparado", "No Reparado" });
            cmbEstado.Location = new Point(208, 90);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 15;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(208, 167);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 16;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 387);
            Controls.Add(cmbTipo);
            Controls.Add(cmbEstado);
            Controls.Add(label1);
            Controls.Add(cmbOperacion);
            Controls.Add(lblTripulacion);
            Controls.Add(lblTipo);
            Controls.Add(txtId);
            Controls.Add(txtTripulacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblOperacion);
            Controls.Add(lblEstado);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAgregar";
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblNombre;
        private Label lblEstado;
        private Label lblOperacion;
        private Label lblDepartamento;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblTripulacion;
        private Label lblId;
        private Label lblTipo;
        private TextBox txtId;
        private TextBox txtTripulacion;
        private ComboBox cmbOperacion;
        private Label label1;
        private ComboBox cmbEstado;
        private ComboBox cmbTipo;
    }
}