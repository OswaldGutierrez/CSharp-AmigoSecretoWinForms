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
    public partial class FormPrincipal : Form
    {

        AmigoSecreto amigoSecreto;
        private FormProximaEndulzada formProximaEndulzada;


        // Creamos textos para mostrarlos
        public static string txt1 = "";
        public static string txt2 = "";
        public static string txt3 = "";
        public static string txt4 = "";
        public static string txt5 = "";

        public FormPrincipal()
        {
            InitializeComponent();
            amigoSecreto = new AmigoSecreto();
        }


        /**
         * Al hacer click en este botón, aparecerá una nueva interfaz que mostrará la información ingresada por el usuario.
         */
        private void buttonInformacionDeJuego_Click(object sender, EventArgs e)
        {
            txt1 = textBoxCantidadDeJugadores.Text;
            txt2 = textBoxNumeroDeEndulzadas.Text;
            txt3 = textBoxFrecuenciaDeEndulzadas.Text;
            txt4 = textBoxValorDeEndulzadas.Text;
            txt5 = textBoxValorDeRegalo.Text;

            FormInformacionDeJuego formInformacion = new FormInformacionDeJuego();
            formInformacion.FechaInicio = dateFechaDeInicio.Value;
            formInformacion.FechaDescubrimiento = dateFechaDeDescubrimiento.Value;


            new FormInformacionDeJuego().ShowDialog();
        }


        private void buttonProximaEndulzada_Click(object sender, EventArgs e)
        {
            // Obtener los valores de Fecha de Inicio, Número de Endulzadas y Frecuencia de Endulzadas
            DateTime fechaInicio = dateFechaDeInicio.Value; // Suponiendo que tengas un DateTimePicker en FormPrincipal
            int numeroEndulzadas = int.Parse(textBoxNumeroDeEndulzadas.Text); // Suponiendo que el número se muestra en un TextBox
            int frecuenciaEndulzadas = int.Parse(textBoxFrecuenciaDeEndulzadas.Text); // Suponiendo que la frecuencia se muestra en un TextBox

            // Crear una nueva instancia de FormProximaEndulzada y pasar los valores como argumentos
            FormProximaEndulzada formProximaEndulzada = new FormProximaEndulzada(fechaInicio, numeroEndulzadas, frecuenciaEndulzadas);

            // Mostrar la ventana de FormProximaEndulzada
            formProximaEndulzada.Show();
        }


        /**
         * Permite al usuario especificar la cantidad de jugadores que desea crear y luego los muestra una lista de los jugadores en un cuadro de diálogo.
         */
        private void buttonCrearJugadores_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxCantidadDeJugadores.Text, out int cantidad))
            {
                // Llama a la función de la instancia de AmigoSecreto para crear jugadores
                Jugador[] jugadores = amigoSecreto.CrearJugadores(cantidad);

                if (jugadores != null)
                {
                    string mensaje = "Jugadores creados:\n";
                    foreach (Jugador jugador in jugadores)
                    {
                        mensaje += jugador.mostrarJugador() + "\n";
                    }

                    MessageBox.Show(mensaje, "Jugadores Creados");
                }
                else
                {
                    MessageBox.Show("La creación de jugadores ha fallado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido en el TextBox.");
            }
        }


        /**
         * Permite asignar amigos secretos a los jugadores creados anteriormente, siempre y cuando se hayan creado los jugadores previamente.
         */
        private void buttonAsignarAmigosSecretos_Click(object sender, EventArgs e)
        {
            if (amigoSecreto.Jugadores != null)
            {
                amigoSecreto.AsignarAmigosSecretos();

                MessageBox.Show("Amigos secretos asignados con éxito.");
            }
            else
            {
                MessageBox.Show("Primero debes crear los jugadores antes de asignar amigos secretos.");
            }
        }

        private void textBoxValorDeEndulzadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, el carácter de retroceso (borrar) y el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Asegura que solo haya un punto decimal en el valor
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxValorDeRegalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, el carácter de retroceso (borrar) y el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Asegura que solo haya un punto decimal en el valor
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxNumeroDeEndulzadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y el carácter de retroceso (para borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFrecuenciaDeEndulzadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y el carácter de retroceso (para borrar)
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
    {
        e.Handled = true;
    }
        }
    }
}
