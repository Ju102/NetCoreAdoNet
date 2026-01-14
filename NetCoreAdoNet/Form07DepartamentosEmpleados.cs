using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryEmpleadosDepartamentos repo;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosDepartamentos();
            LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                string delApellido = this.lstEmpleados.SelectedItem.ToString();
                await this.repo.DeleteEmpleado(delApellido);

                LoadDepartamentos();
            } else
            {
                MessageBox.Show("Debes seleccionar un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void LoadDepartamentos() // no es Task porque se usa en el constructor (de momento, luego aprenderemos)
        {
            this.lstDepartamentos.Items.Clear();

            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            foreach (string dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept);
            }
            this.lstDepartamentos.SelectedIndex = 0;
        }

        private async Task LoadEmpleados(string departamento)
        {
            this.lstEmpleados.Items.Clear();

            List<string> empleados = await this.repo.GetEmpleadosByDeptv2Async(departamento);
            foreach (string emp in empleados)
            {
                Console.WriteLine(emp);
                this.lstEmpleados.Items.Add(emp);
            }
        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = this.lstDepartamentos.SelectedItem.ToString();
            this.LoadEmpleados(dept);
        }
    }
}