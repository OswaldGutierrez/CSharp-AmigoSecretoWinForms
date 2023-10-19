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

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonInformacionDeJuego_Click(object sender, EventArgs e)
        {
            txt1 = textBoxCantidadDeJugadores.Text;
            new FormInformacionDeJuego().ShowDialog();
        }
    }
}
