using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositorySalas
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreSalasAsync()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> salas = new List<string>();

            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                salas.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return salas;
        }

        /// <summary>
        /// Method that updates the given old name with the given new name.
        /// </summary>
        public async Task<int> UpdateSalasAsync(string newName, string oldName)
        {
            string sql = "update SALA set NOMBRE = @newname where NOMBRE = @oldname";

            SqlParameter paramOld = new SqlParameter("@oldname", oldName);
            SqlParameter paramNew = new SqlParameter("@newname", newName);
            this.com.Parameters.Add(paramOld);
            this.com.Parameters.Add(paramNew);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return registros;
        }
    }
}
