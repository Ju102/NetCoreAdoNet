using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Stored Procedures
//--Proced.para cargar todos los departamentos
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from DEPT
//go

//-- Proced. para insertar un departamento
//create procedure SP_INSERT_DEPARTAMENTOS
//(@numero int, @nombre NVARCHAR(50), @localidad NVARCHAR(50))
//as
//	insert into DEPT values(@numero, @nombre, @localidad)
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form12MensajesServidor : Form
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            // string connectionString = @"Data Source=sqlpaco3430.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=adminsql;Password=Admin123;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            // Agregamos el evento para capturar mensajes
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDatosDepartamentosAsync();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblServidor.Text = e.Message;
        }

        private async void btnAddDepartamento_Click(object sender, EventArgs e)
        {
            this.lblServidor.Text = "";
            await this.InsertDepartamentoAsync();
        }

        private async Task LoadDatosDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string id = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();

                this.lstDepartamentos.Items.Add(id + " - " + nombre + " - " + localidad);
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
        }

        private async Task InsertDepartamentoAsync()
        {
            string sql = "SP_INSERT_DEPARTAMENTO";

            int id = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombreDepartamento.Text;
            string localidad = this.txtLocalidadDepartamento.Text;

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@numero", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);

            await this.cn.OpenAsync();
            // int registros = await this.com.ExecuteNonQueryAsync();
            int registros = this.com.ExecuteNonQuery();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            MessageBox.Show(registros.ToString() + " registro/s insertado/s.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await this.LoadDatosDepartamentosAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await this.LoadDatosDepartamentosAsync();
        }
    }
}
