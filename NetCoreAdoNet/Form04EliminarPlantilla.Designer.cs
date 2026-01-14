namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            btnDeletePlantilla = new Button();
            label1 = new Label();
            Plantilla = new ListBox();
            txtPlantilla = new TextBox();
            SuspendLayout();
            // 
            // btnDeletePlantilla
            // 
            btnDeletePlantilla.Location = new Point(65, 88);
            btnDeletePlantilla.Name = "btnDeletePlantilla";
            btnDeletePlantilla.Size = new Size(75, 33);
            btnDeletePlantilla.TabIndex = 0;
            btnDeletePlantilla.Text = "Eliminar";
            btnDeletePlantilla.UseVisualStyleBackColor = true;
            btnDeletePlantilla.Click += btnDeletePlantilla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 41);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Nº Empleado";
            // 
            // Plantilla
            // 
            Plantilla.FormattingEnabled = true;
            Plantilla.Location = new Point(205, 41);
            Plantilla.Name = "Plantilla";
            Plantilla.Size = new Size(187, 229);
            Plantilla.TabIndex = 2;
            // 
            // txtPlantilla
            // 
            txtPlantilla.Location = new Point(44, 59);
            txtPlantilla.Name = "txtPlantilla";
            txtPlantilla.Size = new Size(120, 23);
            txtPlantilla.TabIndex = 3;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(435, 311);
            Controls.Add(txtPlantilla);
            Controls.Add(Plantilla);
            Controls.Add(label1);
            Controls.Add(btnDeletePlantilla);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletePlantilla;
        private Label label1;
        private ListBox Plantilla;
        private TextBox txtPlantilla;
    }
}