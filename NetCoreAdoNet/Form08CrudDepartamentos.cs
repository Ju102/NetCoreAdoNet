using NetCoreAdoNet.Models;
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
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;

        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept.IdDepartamento.ToString() + " - " + dept.Nombre + " - " + dept.Localidad);
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            int idDept = int.Parse(this.txtId.Text);
            string nombreDept = this.txtNombre.Text;
            string localidadDept = this.txtLocalidad.Text;

            await this.repo.CreateDepartamentoAsync(idDept, nombreDept, localidadDept);
            await this.LoadDepartamentos();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int idDept = int.Parse(this.txtId.Text);
            string nombreDept = this.txtNombre.Text;
            string localidadDept = this.txtLocalidad.Text;

            await this.repo.UpdateDepartamentoAsync(idDept, nombreDept, localidadDept);
            await this.LoadDepartamentos();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int idDept = int.Parse(this.txtId.Text);

            await this.repo.DeleteDepartamentoAsync(idDept);
            await this.LoadDepartamentos();
        }
    }
}
