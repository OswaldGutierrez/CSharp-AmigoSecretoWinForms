using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_final_3
{
    internal class AmigoSecreto
    {

        public int CantidadDeJugadores { get; set; }                        // Propiedad que almacena la cantidad de jugadores

        public DateTime FechaDeInicio { get; set; }                         // Fecha en la que comienza el juego

        public DateTime FechaDeDescubrimiento { get; set; }                 // Fecha en que se revelan su amigo secreto

        public int NumeroDeEndulzadas { get; set; }                         // Almacena el número de veces que se darán endulzadas

        public int FrecuenciaDeEndulzadas { get; set; }

        public double ValorDeEndulzadas { get; set; }

        public double ValorDeRegalo { get; set; }

        public Jugador[] Jugadores { get; set; }



        // Creamos un constructor para la clase 'AmigoSecreto'
        public AmigoSecreto(int cantidadJugadores, DateTime fechaInicio, DateTime fechaFin, int numeroEndulzadas, int frecuenciaEndulzadasDias, double valorEndulzada, double valorRegalo)
        {
            CantidadDeJugadores = cantidadJugadores;
            FechaDeInicio = fechaInicio;
            FechaDeDescubrimiento = fechaFin;
            NumeroDeEndulzadas = numeroEndulzadas;
            FrecuenciaDeEndulzadas = frecuenciaEndulzadasDias;
            ValorDeEndulzadas = valorEndulzada;
            ValorDeRegalo = valorRegalo;
            Jugadores = new Jugador[cantidadJugadores];
        }


        public void AsignarJugadores(Jugador[] jugadores)
        {
            if (jugadores.Length == CantidadDeJugadores)
            {
                Jugadores = jugadores;
            }
            else
            {
                Console.WriteLine("La cantidad de jugadores no coincide con la cantidad especificada en el juego.");
            }
        }


        // Creamos un método que se encargue de asignar amigos secretos a los jugadores del juego y simular el envío de correos electrónicos
        public void AsignarAmigosSecretos()
        {

            // Crea una copia desordenada de la lista de jugadores
            List<Jugador> jugadoresDesordenados = new List<Jugador>(Jugadores);
            Random rng = new Random();

            int n = jugadoresDesordenados.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Jugador temp = jugadoresDesordenados[k];
                jugadoresDesordenados[k] = jugadoresDesordenados[n];
                jugadoresDesordenados[n] = temp;
            }

            // Asignar amigos secretos y enviar correos electrónicos
            for (int i = 0; i < jugadoresDesordenados.Count; i++)
            {
                Jugador jugadorActual = jugadoresDesordenados[i];
                Jugador amigoSecreto = jugadoresDesordenados[(i + 1) % jugadoresDesordenados.Count];

                jugadorActual.AmigoSecreto = amigoSecreto.ToString();
            }

        }


        public void ImprimirInformacionJuego()
        {
            MessageBox.Show($"Fecha de Inicio: {FechaDeInicio}\n" +
                $"Fecha de Fin: {FechaDeDescubrimiento}\n" +
                $"Número de Endulzadas: {NumeroDeEndulzadas}\n" +
                $"Frecuencia de Endulzadas en días: {FrecuenciaDeEndulzadas}\n" +
                $"Valor de la Endulzada: {ValorDeEndulzadas:C}\n" +
                $"Valor del Regalo: {ValorDeRegalo:C}");
        }



        public void ImprimirGustosJugadores()
        {
            foreach (Jugador jugador in Jugadores)
            {
                string mensaje = $"Jugador: {jugador.Nombre}\n" +
                                 $"Gusto Endulzada Ideal: {jugador.EndulzadaIdeal}\n" +
                                 $"Gusto Regalo Ideal: {jugador.RegaloIdeal}\n";

                MessageBox.Show(mensaje, "Gustos del Jugador");
            }
        }

        public int DiasHastaProximaEndulzada(DateTime fechaActual)
        {
            // Calcula la diferencia en días entre la fecha actual y la fecha de inicio del juego
            TimeSpan diferencia = FechaDeInicio - fechaActual;

            // Calcula el número de días restantes hasta la próxima endulzada
            int diasRestantes = (int)diferencia.TotalDays % FrecuenciaDeEndulzadas;

            if (diasRestantes < 0)
            {
                // Si es negativo, significa que ya pasó una endulzada, por lo que se calcula la próxima endulzada
                diasRestantes = FrecuenciaDeEndulzadas + diasRestantes;
            }

            return diasRestantes;
        }

    }
}
