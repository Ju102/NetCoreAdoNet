namespace NetCoreAdoNet
{
    partial class Form03EliminarEnfermo
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
            lblInscripcion = new Label();
            label2 = new Label();
            txtInscripcion = new TextBox();
            btnDeleteEnfermo = new Button();
            Enfermos = new ListBox();
            SuspendLayout();
            // 
            // lblInscripcion
            // 
            lblInscripcion.AutoSize = true;
            lblInscripcion.Location = new Point(31, 29);
            lblInscripcion.Name = "lblInscripcion";
            lblInscripcion.Size = new Size(65, 15);
            lblInscripcion.TabIndex = 0;
            lblInscripcion.Text = "Inscripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Enfermos";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(31, 47);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(176, 23);
            txtInscripcion.TabIndex = 2;
            // 
            // btnDeleteEnfermo
            // 
            btnDeleteEnfermo.Location = new Point(66, 76);
            btnDeleteEnfermo.Name = "btnDeleteEnfermo";
            btnDeleteEnfermo.Size = new Size(100, 37);
            btnDeleteEnfermo.TabIndex = 0;
            btnDeleteEnfermo.Text = "Borrar Enfermo";
            btnDeleteEnfermo.UseVisualStyleBackColor = true;
            btnDeleteEnfermo.Click += btnDeleteEnfermo_Click;
            // 
            // Enfermos
            // 
            Enfermos.Location = new Point(238, 47);
            Enfermos.Name = "Enfermos";
            Enfermos.Size = new Size(229, 199);
            Enfermos.TabIndex = 0;
            // 
            // Form03EliminarEnfermo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(497, 274);
            Controls.Add(Enfermos);
            Controls.Add(btnDeleteEnfermo);
            Controls.Add(txtInscripcion);
            Controls.Add(label2);
            Controls.Add(lblInscripcion);
            Name = "Form03EliminarEnfermo";
            Text = "Form03EliminarEnfermo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInscripcion;
        private Label label2;
        private TextBox txtInscripcion;
        private Button btnDeleteEnfermo;
        private ListBox Enfermos;
    }
}