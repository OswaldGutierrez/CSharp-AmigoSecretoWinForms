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
        public FormInformacionDeJuego()
        {
            InitializeComponent();
            labelCantidadDeJugadores.Text = FormPrincipal.txt1;
        }

        private void FormInformacionDeJuego_Load(object sender, EventArgs e)
        {
        }
    }
}
