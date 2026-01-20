namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLeerSettings = new Button();
            lblConnection = new Label();
            btnLeerHelper = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(195, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(440, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnLeerSettings
            // 
            btnLeerSettings.Location = new Point(327, 23);
            btnLeerSettings.Name = "btnLeerSettings";
            btnLeerSettings.Size = new Size(87, 36);
            btnLeerSettings.TabIndex = 2;
            btnLeerSettings.Text = "Leer Settings";
            btnLeerSettings.UseVisualStyleBackColor = true;
            btnLeerSettings.Click += btnLeerSettings_Click;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new Point(23, 316);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(82, 15);
            lblConnection.TabIndex = 3;
            lblConnection.Text = "lblConnection";
            // 
            // btnLeerHelper
            // 
            btnLeerHelper.Location = new Point(420, 23);
            btnLeerHelper.Name = "btnLeerHelper";
            btnLeerHelper.Size = new Size(87, 36);
            btnLeerHelper.TabIndex = 4;
            btnLeerHelper.Text = "Leer Helper";
            btnLeerHelper.UseVisualStyleBackColor = true;
            btnLeerHelper.Click += btnLeerHelper_Click;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 353);
            Controls.Add(btnLeerHelper);
            Controls.Add(lblConnection);
            Controls.Add(btnLeerSettings);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLeerSettings;
        private Label lblConnection;
        private Button btnLeerHelper;
    }
}