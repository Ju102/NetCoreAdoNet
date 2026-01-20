using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form14Settings : Form
    {
        public Form14Settings()
        {
            InitializeComponent();
            this.lblConnection.Text = "";
        }

        private void btnLeerSettings_Click(object sender, EventArgs e)
        {
            // Necesitamos hacer un constructor de config.
            ConfigurationBuilder builder = new ConfigurationBuilder();
            // En este entorno de proyecto, settings no es nativo. A pesar de llamarlo appsettings.json, no lo reconoce.
            // Debemos indicar el nombre y ubicacion del archivo.
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true); // false da exception si no lo encuentra
            // Necesitamos el objeto para recuperar las keys
            IConfigurationRoot configuration = builder.Build();
            // Tambien existen keys ya configuradas, que se pueden recuperar con metodos nativos. Las keys diferencian mayus. de minus.
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");


            // Si no son conocidas, debemos navegar hasta las keys.
            // La navegacion entre keys se establece mediante:
            //  - KeyPrincipal:Subkey
            //  - KeyPrincipal:Subkey:OtraSubkey

            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorLetra = configuration.GetSection("Colores:letra").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;

            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
            this.BackColor = Color.FromName(colorFondo);
            this.btnLeerSettings.ForeColor = Color.FromName(colorLetra);
            this.btnLeerHelper.ForeColor = Color.Black;
            this.lblConnection.ForeColor = Color.FromName(colorLetra);
            this.lblConnection.Text = connectionString;

        }

        private void btnLeerHelper_Click(object sender, EventArgs e)
        {
            // No hace falta usar el constructor, solo llamar al metodo de la clase.
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();

            // Tambien existen keys ya configuradas, que se pueden recuperar con metodos nativos. Las keys diferencian mayus. de minus.
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");


            // Si no son conocidas, debemos navegar hasta las keys.
            // La navegacion entre keys se establece mediante:
            //  - KeyPrincipal:Subkey
            //  - KeyPrincipal:Subkey:OtraSubkey

            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorLetra = configuration.GetSection("Colores:letra").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;

            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
            this.BackColor = Color.FromName(colorFondo);
            this.btnLeerHelper.ForeColor = Color.FromName(colorLetra);
            this.btnLeerSettings.ForeColor = Color.Black;
            this.lblConnection.ForeColor = Color.FromName(colorLetra);
            this.lblConnection.Text = connectionString;
        }
    }
}
