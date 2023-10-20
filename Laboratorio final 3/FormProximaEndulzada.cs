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

            // Inicializar la instancia de AmigoSecreto
            amigoSecreto = new AmigoSecreto();

            // Configurar los valores en la instancia de AmigoSecreto
            amigoSecreto.FechaDeInicio = FechaInicio;
            amigoSecreto.NumeroDeEndulzadas = NumeroEndulzadas;
            amigoSecreto.FrecuenciaDeEndulzadas = FrecuenciaEndulzadas;
        }

        public FormProximaEndulzada()
        {
            InitializeComponent();
        }

        private void buttonCalcularProxEndulzada_Click(object sender, EventArgs e)
        {
            // Obtén la fecha ingresada por el usuario en el DateTimePicker
            DateTime fechaIngresada = dateCalcularFecha.Value;

            // Llama a la función de AmigoSecreto para calcular los días hasta la próxima endulzada
            int diasHastaProximaEndulzada = amigoSecreto.DiasHastaProximaEndulzada(fechaIngresada);

            // Muestra un mensaje con la cantidad de días
            MessageBox.Show($"Días hasta la próxima endulzada: {diasHastaProximaEndulzada}");
        }
    }
}
