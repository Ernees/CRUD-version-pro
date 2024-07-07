namespace FrmPrincipal
{
    partial class Mostrar
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
            listBoxEmpleados = new ListBox();
            btnModificar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxEmpleados
            // 
            listBoxEmpleados.FormattingEnabled = true;
            listBoxEmpleados.ItemHeight = 15;
            listBoxEmpleados.Location = new Point(72, 46);
            listBoxEmpleados.Name = "listBoxEmpleados";
            listBoxEmpleados.Size = new Size(510, 289);
            listBoxEmpleados.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(160, 403);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 45);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(363, 403);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 3;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Mostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(670, 520);
            Controls.Add(button1);
            Controls.Add(btnModificar);
            Controls.Add(listBoxEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mostrar";
            Text = "Mostrar";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEmpleados;
        private Button btnModificar;
        private Button button1;
    }
}