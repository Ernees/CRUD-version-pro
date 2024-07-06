using System.Drawing;
using System.Windows.Forms;

namespace Formularios
{
    partial class FrmPrincipal
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
            btnAgregar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(130, 110);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 44);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(130, 204);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(159, 44);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 332);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnMostrar;
    }
}