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
            txtApellido = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDepartamento = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            lblEdad = new Label();
            txtId = new TextBox();
            txtEdad = new TextBox();
            cbDepartamento = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(208, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(121, 23);
            txtApellido.TabIndex = 1;
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
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(23, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(23, 117);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 5;
            lblDepartamento.Text = "Departamento";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(42, 273);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(95, 45);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(192, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 175);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(23, 146);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 11;
            lblEdad.Text = "Edad";
            // 
            // txtId
            // 
            txtId.Location = new Point(208, 172);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(208, 143);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(121, 23);
            txtEdad.TabIndex = 8;
            // 
            // cbDepartamento
            // 
            cbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Items.AddRange(new object[] { "Gerencia", "Finanzas", "Dev" });
            cbDepartamento.Location = new Point(208, 114);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(121, 23);
            cbDepartamento.TabIndex = 13;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 387);
            Controls.Add(cbDepartamento);
            Controls.Add(lblId);
            Controls.Add(lblEdad);
            Controls.Add(txtId);
            Controls.Add(txtEdad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblDepartamento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
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
        private Label lblApellido;
        private Label lblDepartamento;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblId;
        private Label lblEdad;
        private TextBox txtId;
        private TextBox txtEdad;
        private ComboBox cbDepartamento;
    }
}