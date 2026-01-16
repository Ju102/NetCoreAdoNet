using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NetCoreAdoNet.Models;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospital
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospital()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            List<Hospital> hospitales = new List<Hospital>();
            string sql = "select * from HOSPITAL";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                Hospital hos = new Hospital();
                hos.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hos.Nombre = this.reader["NOMBRE"].ToString();
                hos.Direccion = this.reader["DIRECCION"].ToString();
                hos.Telefono = this.reader["TELEFONO"].ToString();
                hos.NumeroCamas = int.Parse(this.reader["NUM_CAMA"].ToString());

                hospitales.Add(hos);
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

            return hospitales;
        }

        public async Task InsertHospitalAsync(int id, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "insert into HOSPITAL values(@id, @nombre, @direccion, @telefono, @numcamas)";

            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@numcamas", numCamas);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();

            this.com.Parameters.Clear();
        }

        public async Task UpdateHospitalAsync(int id, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "update HOSPITAL set NOMBRE = @nombre, DIRECCION = @direccion, " +
                "TELEFONO = @telefono, NUM_CAMA = @numcamas where HOSPITAL_COD = @id";

            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@numcamas", numCamas);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();

            this.com.Parameters.Clear();
        }

        public async Task DeleteHospitalAsync(int id)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD = @id";

            this.com.Parameters.AddWithValue("@id", id);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();

            this.com.Parameters.Clear();
        }
    }
}
