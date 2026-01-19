using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#region procedimientos
//create procedure SP_ALL_HOSPITALES
//as
//	select * from HOSPITAL
//go

//create procedure SP_UPDATE_PLANTILLA_HOSPITAL
//(@nombre NVARCHAR(50), @incremento int)
//as
//	declare @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD from HOSPITAL where NOMBRE = @nombre
//	update PLANTILLA set SALARIO = SALARIO + @incremento where HOSPITAL_COD = @hospitalcod
//go

//create procedure SP_PLANTILLA_HOSPITAL
//(@nombre nvarchar(50))
//as
//	select PLANTILLA.* FROM PLANTILLA inner join HOSPITAL on HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
//		where HOSPITAL.NOMBRE = @nombre
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form11ProcedimientosHospitalPlantilla : Form
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public Form11ProcedimientosHospitalPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitalesAsync();
        }

        private async Task LoadHospitalesAsync()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbHospitales.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
        }

        private async void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            // Si tenemos parametros, debemos incluirlos en el com, no en la consulta
            string sql = "SP_UPDATE_PLANTILLA_HOSPITAL";
            string nombreHospital = this.cmbHospitales.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncrementoSalario.Text);

            this.com.Parameters.AddWithValue("@incremento", incremento); // el nombre del parametro es el mismo que el dado en el procedimiento
            this.com.Parameters.AddWithValue("@nombre", nombreHospital);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            MessageBox.Show(registros.ToString() + " registro/s actualizado/s con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await this.LoadPlantillaHospitalAsync(nombreHospital);

            this.txtIncrementoSalario.Focus();
            this.txtIncrementoSalario.Text = "";
        }

        private async Task LoadPlantillaHospitalAsync(string nombreHospital)
        {
            string sql = "SP_PLANTILLA_HOSPITAL";

            this.com.Parameters.AddWithValue("@nombre", nombreHospital);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstPlantilla.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + salario);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            await this.LoadPlantillaHospitalAsync(nombre);
        }
    }
}
