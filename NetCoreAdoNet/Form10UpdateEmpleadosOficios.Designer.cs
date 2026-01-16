namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleadosOficios
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
            label3 = new Label();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            txtIncrementoSalario = new TextBox();
            btnSubirSalario = new Button();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalarial = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 35);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 35);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Incremento salarial:";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(45, 53);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(158, 169);
            lstOficios.TabIndex = 3;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(250, 53);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(201, 169);
            lstEmpleados.TabIndex = 4;
            // 
            // txtIncrementoSalario
            // 
            txtIncrementoSalario.Location = new Point(479, 53);
            txtIncrementoSalario.Name = "txtIncrementoSalario";
            txtIncrementoSalario.Size = new Size(110, 23);
            txtIncrementoSalario.TabIndex = 5;
            // 
            // btnSubirSalario
            // 
            btnSubirSalario.Location = new Point(495, 94);
            btnSubirSalario.Name = "btnSubirSalario";
            btnSubirSalario.Size = new Size(75, 23);
            btnSubirSalario.TabIndex = 6;
            btnSubirSalario.Text = "Subir";
            btnSubirSalario.UseVisualStyleBackColor = true;
            btnSubirSalario.Click += btnSubirSalario_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(479, 136);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(38, 15);
            lblSumaSalarial.TabIndex = 7;
            lblSumaSalarial.Text = "label4";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(479, 164);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(38, 15);
            lblMediaSalarial.TabIndex = 8;
            lblMediaSalarial.Text = "label5";
            // 
            // lblMaximoSalarial
            // 
            lblMaximoSalarial.AutoSize = true;
            lblMaximoSalarial.Location = new Point(479, 194);
            lblMaximoSalarial.Name = "lblMaximoSalarial";
            lblMaximoSalarial.Size = new Size(38, 15);
            lblMaximoSalarial.TabIndex = 9;
            lblMaximoSalarial.Text = "label6";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 266);
            Controls.Add(lblMaximoSalarial);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnSubirSalario);
            Controls.Add(txtIncrementoSalario);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private TextBox txtIncrementoSalario;
        private Button btnSubirSalario;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalarial;
    }
}