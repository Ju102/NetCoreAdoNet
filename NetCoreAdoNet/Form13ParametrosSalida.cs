using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
//	select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) from EMP where DEPT_NO = @iddept
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";

            // Tenemos un parametro de entrada. Por defecto, todos son de entrada. Perfectamente podemos utilizar AddWithValue con dicho parametro
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            // this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter paramNombre = new SqlParameter();
            paramNombre.ParameterName = "@nombre";
            paramNombre.Value = nombre;
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
            this.lstEmpleados.Items.Clear();

            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }

            await this.reader.CloseAsync();

            // Dibujamos los parametros DESPUÉS de cerrar el reader
            this.txtSumaSalarial.Text = paramSuma.Value.ToString();
            this.txtMediaSalarial.Text = paramMedia.Value.ToString();
            this.txtPersonas.Text = paramPersonas.Value.ToString();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.cmbDepartamentos.Items.Clear();

            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

        }
    }
}
