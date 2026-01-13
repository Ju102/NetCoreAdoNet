namespace NetCoreAdoNet
{
    partial class Form02BuscadorEmpleados
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
            label1 = new Label();
            label2 = new Label();
            btnSearchEmpleado = new Button();
            Empleados = new ListBox();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 144);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Lista";
            // 
            // btnSearchEmpleado
            // 
            btnSearchEmpleado.Location = new Point(31, 75);
            btnSearchEmpleado.Name = "btnSearchEmpleado";
            btnSearchEmpleado.Size = new Size(172, 35);
            btnSearchEmpleado.TabIndex = 2;
            btnSearchEmpleado.Text = "Buscar";
            btnSearchEmpleado.UseVisualStyleBackColor = true;
            btnSearchEmpleado.Click += btnSearchEmpleado_Click;
            // 
            // Empleados
            // 
            Empleados.FormattingEnabled = true;
            Empleados.Location = new Point(31, 162);
            Empleados.Name = "Empleados";
            Empleados.Size = new Size(172, 184);
            Empleados.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 4;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(235, 365);
            Controls.Add(txtSearch);
            Controls.Add(Empleados);
            Controls.Add(btnSearchEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSearchEmpleado;
        private ListBox Empleados;
        private TextBox txtSearch;
    }
}