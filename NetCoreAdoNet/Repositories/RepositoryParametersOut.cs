using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text;

#region STORED PROCEDURES
//create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre NVARCHAR(50), @suma int OUT, @media int OUT, @personas int OUT)
//as
//	declare @iddept int
//	select @iddept = DEPT_NO from DEPT
//		where DNOMBRE = @nombre
//	-- Consulta del procedimiento
//	select * from EMP where DEPT_NO = @iddept
//	-- Rellenamos las variables de salida
//	select @suma = isnull(SUM(SALARIO),0), @media = isnull(AVG(SALARIO), 0), @personas = isnull(COUNT(EMP_NO), 0) from EMP where DEPT_NO = @iddept
//go
#endregion

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryParametersOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryParametersOut()
        {
            IConfigurationRoot config = HelperConfiguration.GetConfiguration();

            // string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            string connectionString = config.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            List<string> lista = new List<string>();

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                lista.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return lista;
        }

        public async Task<EmpleadosParametersOut> GetEmpleadosModelByDeptAsync(string nombreDepartamento)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            EmpleadosParametersOut datosEmpleados = new EmpleadosParametersOut();
            // datosEmpleados.Apellidos = new List<string>();  1ºforma: inicializar la lista aqui. La segunda es el constructor.

            // Tenemos un parametro de entrada. Por defecto, todos son de entrada. Perfectamente podemos utilizar AddWithValue con dicho parametro
            // this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter paramNombre = new SqlParameter();
            paramNombre.ParameterName = "@nombre";
            paramNombre.Value = nombreDepartamento;
            this.com.Parameters.Add(paramNombre);

            // Los parametros de salida debemos crearlos de forma explicita
            // En este ejemplo, no hemos puesto valores por defecto a los parametros, por lo que son obligatorios.
            SqlParameter paramSuma = new SqlParameter();
            paramSuma.ParameterName = "@suma";
            // ¿Qué value de suma enviamos al procedimiento?  => todos los parametros deben tener un valor por defecto.
            paramSuma.Value = 0;
            paramSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);

            SqlParameter paramMedia = new SqlParameter();
            paramMedia.ParameterName = "@media";
            paramMedia.Value = 0;
            paramMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramMedia);

            SqlParameter paramPersonas = new SqlParameter();
            paramPersonas.ParameterName = "@personas";
            paramPersonas.Value = 0;
            paramPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                datosEmpleados.Apellidos.Add(apellido);
            }

            await this.reader.CloseAsync();

            // Dibujamos los parametros DESPUÉS de cerrar el reader
            datosEmpleados.SumaSalarial = int.Parse(paramSuma.Value.ToString());
            datosEmpleados.MediaSalarial = int.Parse(paramMedia.Value.ToString());
            datosEmpleados.NumeroPersonas = int.Parse(paramPersonas.Value.ToString());

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return datosEmpleados;
        }
    }
}
