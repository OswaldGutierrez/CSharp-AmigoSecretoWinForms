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

        public static string txt1 = "";
        public static string txt2 = "";
        public static string txt3 = "";
        public static string txt4 = "";
        public static string txt5 = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonInformacionDeJuego_Click(object sender, EventArgs e)
        {
            txt1 = textBoxCantidadDeJugadores.Text;
            txt2 = textBoxNumeroDeEndulzadas.Text;
            txt3 = textBoxFrecuenciaDeEndulzadas.Text;
            txt4 = textBoxValorDeEndulzadas.Text;
            txt5 = textBoxValorDeRegalo.Text;

            new FormInformacionDeJuego().ShowDialog();
        }
    }
}
