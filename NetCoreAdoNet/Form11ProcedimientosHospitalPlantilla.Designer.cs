namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
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
            txtIncrementoSalario = new TextBox();
            label2 = new Label();
            btnIncrementarSalarios = new Button();
            cmbHospitales = new ComboBox();
            lblPlantilla = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales:";
            // 
            // txtIncrementoSalario
            // 
            txtIncrementoSalario.Location = new Point(189, 46);
            txtIncrementoSalario.Name = "txtIncrementoSalario";
            txtIncrementoSalario.Size = new Size(141, 23);
            txtIncrementoSalario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 28);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Incremento:";
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(129, 84);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(102, 38);
            btnIncrementarSalarios.TabIndex = 4;
            btnIncrementarSalarios.Text = "Modificar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(26, 46);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(141, 23);
            cmbHospitales.TabIndex = 5;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // lblPlantilla
            // 
            lblPlantilla.AutoSize = true;
            lblPlantilla.Location = new Point(26, 150);
            lblPlantilla.Name = "lblPlantilla";
            lblPlantilla.Size = new Size(52, 15);
            lblPlantilla.TabIndex = 6;
            lblPlantilla.Text = "Plantilla:";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(26, 168);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(304, 214);
            lstPlantilla.TabIndex = 7;
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(lblPlantilla);
            Controls.Add(cmbHospitales);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(label2);
            Controls.Add(txtIncrementoSalario);
            Controls.Add(label1);
            Name = "Form11ProcedimientosHospitalPlantilla";
            Text = "Form11ProcedimientosHospitalPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIncrementoSalario;
        private Label label2;
        private Button btnIncrementarSalarios;
        private ComboBox cmbHospitales;
        private Label lblPlantilla;
        private ListBox lstPlantilla;
    }
}