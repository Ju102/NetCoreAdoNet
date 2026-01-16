namespace NetCoreAdoNet
{
    partial class Form09CrudHospital
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            label4 = new Label();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstHospitales = new ListBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtCamas = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(677, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(596, 191);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(515, 191);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 30);
            btnInsert.TabIndex = 19;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 85);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 18;
            label4.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(505, 103);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 23);
            txtDireccion.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(636, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(505, 52);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 23);
            txtId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(636, 34);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 34);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 13;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 12;
            label1.Text = "Hospitales:";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(27, 52);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(398, 169);
            lstHospitales.TabIndex = 11;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(636, 85);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 23;
            label5.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(636, 103);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 23);
            txtTelefono.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 136);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 25;
            label6.Text = "Nº camas:";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(576, 154);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(125, 23);
            txtCamas.TabIndex = 24;
            // 
            // Form09CrudHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(952, 243);
            Controls.Add(label6);
            Controls.Add(txtCamas);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstHospitales);
            Name = "Form09CrudHospital";
            Text = "Form09CrudHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label4;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstHospitales;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtCamas;
    }
}