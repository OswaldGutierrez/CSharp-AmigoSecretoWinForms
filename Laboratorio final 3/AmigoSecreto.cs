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

        public AmigoSecreto()
        {
            
        }

        // Creamos un constructor para la clase 'AmigoSecreto'
        public AmigoSecreto(int cantidadJugadores, DateTime fechaInicio, DateTime fechaFin, int numeroEndulzadas, int frecuenciaEndulzadasDias, double valorEndulzada, double valorRegalo)
        {
            this.CantidadDeJugadores = cantidadJugadores;
            this.FechaDeInicio = fechaInicio;
            this.FechaDeDescubrimiento = fechaFin;
            this.NumeroDeEndulzadas = numeroEndulzadas;
            this.FrecuenciaDeEndulzadas = frecuenciaEndulzadasDias;
            this.ValorDeEndulzadas = valorEndulzada;
            this.ValorDeRegalo = valorRegalo;
            this.Jugadores = new Jugador[cantidadJugadores];
        }





        public Jugador[] CrearJugadores(int cantidad)
        {
            Jugadores = new Jugador[cantidad]; // Inicializa la propiedad Jugadores

            for (int i = 0; i < cantidad; i++)
            {
                // Crea y almacena cada jugador en la propiedad Jugadores
                string nombre = "Jugador " + (i + 1);
                string correo = "jugador" + (i + 1) + "@correo.com";
                string endulzadaIdeal = "Endulzada Ideal " + (i + 1);
                string regaloIdeal = "Regalo Ideal " + (i + 1);

                Jugadores[i] = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal);
            }

            return Jugadores;
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

            if (Jugadores == null || Jugadores.Length < 2)
            {
                MessageBox.Show("No hay suficientes jugadores para asignar amigos secretos.");
                return;
            }

            Random rng = new Random();
            List<int> disponibles = Enumerable.Range(0, Jugadores.Length).ToList();

            for (int i = 0; i < Jugadores.Length; i++)
            {
                Jugador jugadorActual = Jugadores[i];

                // Evita que el jugador se asigne a sí mismo como amigo secreto
                int indiceAmigoSecreto;
                do
                {
                    indiceAmigoSecreto = disponibles[rng.Next(disponibles.Count)];
                } while (indiceAmigoSecreto == i);

                Jugador amigoSecreto = Jugadores[indiceAmigoSecreto];

                // Agrega información de amigos secretos al mensaje
                MessageBox.Show($"{jugadorActual.Nombre} es el amigo secreto de {amigoSecreto.Nombre}");

                // Remueve el índice asignado de la lista de disponibles
                disponibles.Remove(indiceAmigoSecreto);
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
