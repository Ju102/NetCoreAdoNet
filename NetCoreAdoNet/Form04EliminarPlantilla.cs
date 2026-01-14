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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            cn = new SqlConnection(connectionString);
            com = new SqlCommand();
            this.LoadPlantilla();
        }

        private void LoadPlantilla()
        {
            this.Plantilla.Items.Clear();

            string sql = "select * from PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string empleadono = this.reader["EMPLEADO_NO"].ToString();
                this.Plantilla.Items.Add(empleadono + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnDeletePlantilla_Click(object sender, EventArgs e)
        {
            string sql = "delete from PLANTILLA where EMPLEADO_NO = " + this.txtPlantilla.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.LoadPlantilla();
            MessageBox.Show(registros.ToString() + " empleado/s eliminado/s con éxito");
        }
    }
}
