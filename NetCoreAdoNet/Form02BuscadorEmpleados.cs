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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnSearchEmpleado_Click(object sender, EventArgs e)
        {
            // Vamos a concatenar, por lo que el salario será un string.
            string salario = this.txtSearch.Text;
            // Consulta SQL.
            string sql = "select * from EMP where SALARIO >= " + salario;

            // Configuramos el comando
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;

            // La consulta
            this.com.CommandText = sql;

            // Entrar y salir
            // Abrimos conexión
            this.cn.Open();

            // Ejecutamos la consulta
            this.reader = this.com.ExecuteReader();

            // Dibujamos los datos
            this.Empleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.Empleados.Items.Add(apellido + ": " + sal + "€");
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
