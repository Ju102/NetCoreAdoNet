using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            List<string> oficios = new List<string>();
            string sql = "select distinct OFICIO from EMP";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

            return oficios;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            List<string> empleados = new List<string>();
            string sql = "select APELLIDO from EMP where OFICIO = @oficio";

            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string empleado = this.reader["APELLIDO"].ToString();
                empleados.Add(empleado);
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

            this.com.Parameters.Clear();

            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleados(string oficio, int incremento)
        {
            int registros;
            string sql = "update EMP set SALARIO = SALARIO + @incremento where OFICIO = @oficio";

            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();

            this.com.Parameters.Clear();

            return registros;
        }

        public async Task<List<int>> GetSalariosByOficioAsync(string oficio)
        {
            List<int> salarios = new List<int>();
            string sql = "select SALARIO from EMP where OFICIO = @oficio";

            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync(); 
            while (await this.reader.ReadAsync())
            {
                salarios.Add(int.Parse(this.reader["SALARIO"].ToString()));
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            this.com.Parameters.Clear();

            return salarios;
        }

    }
}
