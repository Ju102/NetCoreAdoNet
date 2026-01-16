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
    public partial class Form09CrudHospital : Form
    {
        RepositoryHospital repo;

        public Form09CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();

            this.lstHospitales.Items.Clear();

            foreach (Hospital hos in hospitales)
            {
                this.lstHospitales.Items.Add(hos.IdHospital.ToString() + ";" + hos.Nombre + ";" +
                    hos.Direccion + ";" + hos.Telefono + ";" + hos.NumeroCamas.ToString());
            }
            this.lstHospitales.SelectedIndex = -1;
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            int idHospital = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);

            await this.repo.InsertHospitalAsync(idHospital, nombre, direccion, telefono, camas);
            await this.LoadHospitales();

            MessageBox.Show("El hospital se ha insertado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.LimpiarCajas();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int idHospital = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);

            await this.repo.UpdateHospitalAsync(idHospital, nombre, direccion, telefono, camas);
            await this.LoadHospitales();

            MessageBox.Show("El hospital se ha actualizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.LimpiarCajas();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int idHospital = int.Parse(this.txtId.Text);

            await this.repo.DeleteHospitalAsync(idHospital);
            await this.LoadHospitales();

            MessageBox.Show("El hospital se ha borrado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.LimpiarCajas();
        }

        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstHospitales.SelectedIndex != -1)
            {
                string[] datos = this.lstHospitales.SelectedItem.ToString().Split(";");

                Console.WriteLine(datos);
                this.txtId.Text = datos[0];
                this.txtNombre.Text = datos[1];
                this.txtDireccion.Text = datos[2];
                this.txtTelefono.Text = datos[3];
                this.txtCamas.Text = datos[4];
            }
        }

        private void LimpiarCajas()
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCamas.Text = "";
        }
    }
}
