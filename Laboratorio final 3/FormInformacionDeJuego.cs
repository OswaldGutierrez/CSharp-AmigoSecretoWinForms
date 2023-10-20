using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_final_3
{
    public partial class FormInformacionDeJuego : Form
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaDescubrimiento { get; set; }


        public FormInformacionDeJuego()
        {
            InitializeComponent();

            labelCantidadDeJugadores.Text = FormPrincipal.txt1;
            labelNumeroDeEndulzadas.Text = FormPrincipal.txt2;
            labelFrecuenciaDeEndulzadas.Text = FormPrincipal.txt3;
            labelValorEndulzada.Text = FormPrincipal.txt4;
            labelValorRegalo.Text = FormPrincipal.txt5;
            labelFechaInicio.Text = "Fecha de Inicio: " + FechaInicio.ToShortDateString();
            labelFechaFin.Text = "Fecha de Descubrimiento: " + FechaDescubrimiento.ToShortDateString();
        }

        private void FormInformacionDeJuego_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
