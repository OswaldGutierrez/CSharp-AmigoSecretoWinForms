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
    public partial class FormProximaEndulzada : Form
    {
        AmigoSecreto amigoSecreto;

        public DateTime FechaInicio { get; set; }
        public int NumeroEndulzadas { get; set; }
        public int FrecuenciaEndulzadas { get; set; }

        public FormProximaEndulzada(DateTime fechaInicio, int numeroEndulzadas, int frecuenciaEndulzadas)
        {
            InitializeComponent();

            // Asignar los valores recibidos a las propiedades de la clase
            FechaInicio = fechaInicio;
            NumeroEndulzadas = numeroEndulzadas;
            FrecuenciaEndulzadas = frecuenciaEndulzadas;
        }

        public FormProximaEndulzada()
        {
            InitializeComponent();
        }

        private void buttonCalcularProxEndulzada_Click(object sender, EventArgs e)
        {
            amigoSecreto = new AmigoSecreto();
            amigoSecreto.DiasHastaProximaEndulzada(dateCalcularFecha.Value);


        }
    }
}
