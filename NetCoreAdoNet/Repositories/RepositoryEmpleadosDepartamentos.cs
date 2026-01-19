using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NetCoreAdoNet.Models;
namespace NetCoreAdoNet.Repositories
{
    public class RepositoryEmpleadosDepartamentos
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryEmpleadosDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        /// <summary>
        /// Method that returns a list of strings asynchronously
        /// </summary>
        /// <returns>a List of strings</returns>
        public async Task<List<string>> GetDepartamentosAsync()
        {
            List<string> departamentos = new List<string>();

            string sql = "select DNOMBRE from DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return departamentos;
        }

        public async Task<List<string>> GetEmpleadosByDeptAsync(string departamento)
        {
            int departNo = await this.GetNumDeptAsync(departamento);
            List<string> empleados = new List<string>();

            string sql = "select APELLIDO from EMP where DEPT_NO = @departNo";

            SqlParameter paramDepartNo = new SqlParameter("@departNo", departNo);
            this.com.Parameters.Add(paramDepartNo);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                empleados.Add(this.reader["APELLIDO"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return empleados;
        }

        public async Task<List<string>> GetEmpleadosByDeptv2Async(string departamento)
        {
            List<string> empleados = new List<string>();

            string sql = "select APELLIDO from EMP where DEPT_NO = (select DEPT_NO from DEPT where DNOMBRE = @departamento)";

            SqlParameter paramDepartamento = new SqlParameter("@departamento", departamento);
            this.com.Parameters.Add(paramDepartamento);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                empleados.Add(this.reader["APELLIDO"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return empleados;
        }

        public async Task<int> GetNumDeptAsync(string dnombre)
        {
            int departNo = 0;
            string sql = "select DEPT_NO from DEPT where DNOMBRE = @nombre";

            SqlParameter paramNombre = new SqlParameter("@nombre", dnombre);
            this.com.Parameters.Add(paramNombre);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            if (await this.reader.ReadAsync())
            {
                departNo = int.Parse(this.reader["DEPT_NO"].ToString());
            }

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return departNo;
        }

        public async Task<int> DeleteEmpleado(string apellido)
        {
            string sql = "delete from EMP where APELLIDO = @apellido";
            
            SqlParameter paramApellido = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(paramApellido);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();

            return registros;
        }
    }
}