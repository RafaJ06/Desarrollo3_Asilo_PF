using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class InicioCaja : Form
    {
        public InicioCaja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void InicioCaja_Load(object sender, EventArgs e)
        {
            // Obtiene el área de trabajo de la pantalla principal (excluye barra de tareas)
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;

            // Calcula el 75% del ancho y alto
            this.Width = (int)(areaTrabajo.Width * .30);
            this.Height = (int)(areaTrabajo.Height * .50);

            // Centra el formulario manualmente
            this.Left = (areaTrabajo.Width - this.Width) / 2;
            this.Top = (areaTrabajo.Height - this.Height) / 2;
        }
    }
}
