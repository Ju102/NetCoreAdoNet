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
    public partial class Form06UpdateSalasClases : Form
    {
        RepositorySalas repo;
        public Form06UpdateSalasClases()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            this.LoadSalasAsync();
        }

        private async void LoadSalasAsync()
        {
            List<string> salas = await this.repo.GetNombreSalasAsync();
            this.lstSalas.Items.Clear();
            foreach (string nombre in salas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }

        private async void btnUpdateSalas_Click(object sender, EventArgs e)
        {
            string newName = this.txtNuevoNombre.Text;
            string oldName = this.lstSalas.SelectedItem.ToString();
            int registros = await this.repo.UpdateSalasAsync(newName, oldName);
            this.LoadSalasAsync();
            MessageBox.Show(registros.ToString() + " sala/s actualizada/s con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
