namespace NetCoreAdoNet
{
    partial class Form13ParametrosSalida
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
            lstEmpleados = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnMostrarDatos = new Button();
            cmbDepartamentos = new ComboBox();
            txtSumaSalarial = new TextBox();
            txtMediaSalarial = new TextBox();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(229, 57);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(208, 244);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 145);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma salarial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 200);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 5;
            label4.Text = "Media salarial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 257);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "Personas:";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(63, 90);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(86, 39);
            btnMostrarDatos.TabIndex = 7;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(33, 57);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(148, 23);
            cmbDepartamentos.TabIndex = 8;
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Enabled = false;
            txtSumaSalarial.Location = new Point(33, 163);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(148, 23);
            txtSumaSalarial.TabIndex = 9;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Enabled = false;
            txtMediaSalarial.Location = new Point(33, 218);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(148, 23);
            txtMediaSalarial.TabIndex = 10;
            // 
            // txtPersonas
            // 
            txtPersonas.Enabled = false;
            txtPersonas.Location = new Point(33, 275);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(148, 23);
            txtPersonas.TabIndex = 11;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(466, 327);
            Controls.Add(txtPersonas);
            Controls.Add(txtMediaSalarial);
            Controls.Add(txtSumaSalarial);
            Controls.Add(cmbDepartamentos);
            Controls.Add(btnMostrarDatos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnMostrarDatos;
        private ComboBox cmbDepartamentos;
        private TextBox txtSumaSalarial;
        private TextBox txtMediaSalarial;
        private TextBox txtPersonas;
    }
}