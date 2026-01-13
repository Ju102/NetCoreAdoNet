using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        // Siempre son las mismos tres objetos
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader; // si queremos leer. El unico que no podemos inicializar directamente
        string connectionString;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.lblConnection.BackColor = Color.LightCoral;
            this.lblConnection.Text = "Disconnected";
            this.cn.StateChange += Cn_StateChange;
            this.btnRead.Enabled = false;

        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblStatus.Text = "La conexión pasa de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                    this.lblConnection.BackColor = Color.LightGreen;
                    this.lblConnection.Text = "Connected";
                    this.btnRead.Enabled = true;
                }
            } catch(Exception ex)
            {
                this.lblConnection.Text = "Connection error: " + ex.Message.ToString();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblConnection.BackColor = Color.LightCoral;
            this.lblConnection.Text = "Disconnected";
            this.btnRead.Enabled = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.Columnas.Items.Clear();
            this.Datos.Items.Clear();
            this.Apellidos.Items.Clear();

            string sql = "select * from EMP";
            // Indicamos la conexion del command
            this.com.Connection = this.cn;
            // Tipo de consulta a realizar
            this.com.CommandType = CommandType.Text;
            // Incluimos la consulta en el command
            this.com.CommandText = sql;
            // Aqui deberiamos abrir la conexión, pero en este caso ya está abierta.
            // Ejecutar la consulta. Como es un select, utilizamos ExecuteReader(), que devuelve un DataReader.
            this.reader = this.com.ExecuteReader();
            
            for(int i = 0; i < this.reader.FieldCount; i++)
            {
                // Leemos las columnas
                string columna = this.reader.GetName(i);
                // Leemos el tipo de dato de las columnas
                string tipo = this.reader.GetDataTypeName(i);
                // Leemos el primer apellido
                this.Columnas.Items.Add(columna);
                this.Datos.Items.Add(tipo);
            }

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.Apellidos.Items.Add(apellido);
            }

            this.reader.Close();
        }
    }
}