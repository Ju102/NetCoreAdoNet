using Microsoft.Win32;
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
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;

        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
            this.lblMaximoSalarial.Text = "";
            this.lblMediaSalarial.Text = "";
            this.lblSumaSalarial.Text = "";
        }

        public async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();

            foreach(string of in oficios)
            {
                this.lstOficios.Items.Add(of);
            }
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                await this.CargarDatosSalarios();
                List<string> empleados = await this.repo.GetEmpleadosByOficioAsync(oficio);
                this.lstEmpleados.Items.Clear();

                foreach (string emp in empleados)
                {
                    this.lstEmpleados.Items.Add(emp);
                }
            }
        }

        private async void btnSubirSalario_Click(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                int incremento = int.Parse(this.txtIncrementoSalario.Text);
                string oficio = this.lstOficios.SelectedItem.ToString();

                int registros = await this.repo.UpdateSalarioEmpleados(oficio, incremento);

                MessageBox.Show(registros.ToString() + " registro/s actualizado/s.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await this.CargarDatosSalarios();
            } else if (this.txtIncrementoSalario.Text == "")
            {
                MessageBox.Show("Debes introducir un incremento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un oficio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task CargarDatosSalarios()
        {
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                DatosEmpleados data = await this.repo.GetDatosEmpleadosAsync(oficio);

                this.lblSumaSalarial.Text = "Suma Total: " + data.SumaSalarial.ToString("C");
                this.lblMediaSalarial.Text = "Salario Medio: " + data.MediaSalarial.ToString("C");
                this.lblMaximoSalarial.Text = "Salario Máximo: " + data.MaximoSalario.ToString("C");
            }



        }
    }
}
