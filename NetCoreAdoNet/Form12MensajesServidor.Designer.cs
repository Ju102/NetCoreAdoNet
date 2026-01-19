namespace NetCoreAdoNet
{
    partial class Form12MensajesServidor
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
            label4 = new Label();
            lblServidor = new Label();
            txtIdDepartamento = new TextBox();
            txtNombreDepartamento = new TextBox();
            txtLocalidadDepartamento = new TextBox();
            lstDepartamentos = new ListBox();
            btnAddDepartamento = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Localidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 27);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Departamentos";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServidor.ForeColor = Color.Green;
            lblServidor.Location = new Point(12, 280);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(68, 15);
            lblServidor.TabIndex = 4;
            lblServidor.Text = "lblServidor";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(12, 45);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(129, 23);
            txtIdDepartamento.TabIndex = 5;
            // 
            // txtNombreDepartamento
            // 
            txtNombreDepartamento.Location = new Point(12, 100);
            txtNombreDepartamento.Name = "txtNombreDepartamento";
            txtNombreDepartamento.Size = new Size(129, 23);
            txtNombreDepartamento.TabIndex = 6;
            // 
            // txtLocalidadDepartamento
            // 
            txtLocalidadDepartamento.Location = new Point(12, 158);
            txtLocalidadDepartamento.Name = "txtLocalidadDepartamento";
            txtLocalidadDepartamento.Size = new Size(129, 23);
            txtLocalidadDepartamento.TabIndex = 7;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(172, 45);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(197, 199);
            lstDepartamentos.TabIndex = 8;
            // 
            // btnAddDepartamento
            // 
            btnAddDepartamento.Location = new Point(29, 190);
            btnAddDepartamento.Name = "btnAddDepartamento";
            btnAddDepartamento.Size = new Size(92, 44);
            btnAddDepartamento.TabIndex = 9;
            btnAddDepartamento.Text = "Nuevo Departamento";
            btnAddDepartamento.UseVisualStyleBackColor = true;
            btnAddDepartamento.Click += btnAddDepartamento_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(37, 240);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refrescar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddDepartamento);
            Controls.Add(lstDepartamentos);
            Controls.Add(txtLocalidadDepartamento);
            Controls.Add(txtNombreDepartamento);
            Controls.Add(txtIdDepartamento);
            Controls.Add(lblServidor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblServidor;
        private TextBox txtIdDepartamento;
        private TextBox txtNombreDepartamento;
        private TextBox txtLocalidadDepartamento;
        private ListBox lstDepartamentos;
        private Button btnAddDepartamento;
        private Button btnRefresh;
    }
}