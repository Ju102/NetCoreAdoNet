namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            Apellidos = new ListBox();
            Columnas = new ListBox();
            Datos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConnect = new Button();
            btnDisconnect = new Button();
            btnRead = new Button();
            lblConnection = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // Apellidos
            // 
            Apellidos.FormattingEnabled = true;
            Apellidos.Location = new Point(163, 58);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(180, 259);
            Apellidos.TabIndex = 0;
            // 
            // Columnas
            // 
            Columnas.FormattingEnabled = true;
            Columnas.Location = new Point(363, 58);
            Columnas.Name = "Columnas";
            Columnas.Size = new Size(180, 259);
            Columnas.TabIndex = 1;
            // 
            // Datos
            // 
            Datos.FormattingEnabled = true;
            Datos.Location = new Point(564, 58);
            Datos.Name = "Datos";
            Datos.Size = new Size(180, 259);
            Datos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 40);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 40);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipos de dato";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(36, 52);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(102, 34);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(36, 92);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(102, 34);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.Text = "Desconectar";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(36, 133);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(102, 34);
            btnRead.TabIndex = 8;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new Point(36, 357);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(0, 15);
            lblConnection.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(564, 357);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 10;
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 398);
            Controls.Add(lblStatus);
            Controls.Add(lblConnection);
            Controls.Add(btnRead);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Datos);
            Controls.Add(Columnas);
            Controls.Add(Apellidos);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Apellidos;
        private ListBox Columnas;
        private ListBox Datos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConnect;
        private Button btnDisconnect;
        private Button btnRead;
        private Label lblConnection;
        private Label lblStatus;
    }
}