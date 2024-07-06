using System.Drawing;
using System.Windows.Forms;

namespace Formularios
{
    partial class FrmMostrar
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
            btnModificar = new Button();
            btnEliminar = new Button();
            dataGridEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(201, 326);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 45);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(424, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 45);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridEmpleados
            // 
            dataGridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleados.Location = new Point(51, 29);
            dataGridEmpleados.Name = "dataGridEmpleados";
            dataGridEmpleados.RowTemplate.Height = 25;
            dataGridEmpleados.Size = new Size(652, 255);
            dataGridEmpleados.TabIndex = 3;
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 437);
            Controls.Add(dataGridEmpleados);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmMostrar";
            Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dataGridEmpleados;
    }
}