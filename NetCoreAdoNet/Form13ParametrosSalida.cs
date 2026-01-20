using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        private RepositoryParametersOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametersOut();
            this.CargarDepartamentos();
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut datosEmpleados = await this.repo.GetEmpleadosModelByDeptAsync(nombreDepartamento);

            this.lstEmpleados.Items.Clear();

            foreach(string emp in datosEmpleados.Apellidos)
            {
                this.lstEmpleados.Items.Add(emp);
            }

            this.txtSumaSalarial.Text = datosEmpleados.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = datosEmpleados.MediaSalarial.ToString();
            this.txtPersonas.Text = datosEmpleados.NumeroPersonas.ToString();

        }
    
        private async Task CargarDepartamentos()
        {
            List<string> deptos = await this.repo.GetDepartamentosAsync();
            foreach(string depto in deptos)
            {
                this.cmbDepartamentos.Items.Add(depto);
            }
            
        }
    
    }
}
