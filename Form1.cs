using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestor_De_Alumnos_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnCargarAlumnos.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCargarAlumnos_Click(object sender, EventArgs e)
        {
            AltaALumno alta = new AltaALumno();
            MessageBox.Show("A continuacion se le pedira que cargue un alumn");
            this.Hide();
            alta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionarAlumnoModificar Modi = new SeleccionarAlumnoModificar();
            this.Hide();
            Modi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Probador list = new Probador();
            ListadoCompleto lista = new ListadoCompleto();
            this.Hide();
            lista.Show();
 //           list.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
