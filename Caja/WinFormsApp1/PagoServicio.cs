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
    public partial class PagoServicio : Form
    {
        public PagoServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void PagoServicio_Load(object sender, EventArgs e)
        {
            // Obtiene el área de trabajo de la pantalla principal (excluye barra de tareas)
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;

            // Calcula el 75% del ancho y alto
            this.Width = (int)(areaTrabajo.Width * .50);
            this.Height = (int)(areaTrabajo.Height * .50);

            // Centra el formulario manualmente
            this.Left = (areaTrabajo.Width - this.Width) / 2;
            this.Top = (areaTrabajo.Height - this.Height) / 2;
        }
    }
}
