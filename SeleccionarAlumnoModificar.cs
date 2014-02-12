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
    public partial class SeleccionarAlumnoModificar : Form
    {
        int DNI;
        public SeleccionarAlumnoModificar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            alumnoTableAdapter.BuscarPorDni(alumnosDBDataSet.Alumno, DNI);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            int salida;
            if (int.TryParse(TxtBuscar.Text, out salida))
                DNI = Convert.ToInt32(TxtBuscar.Text);
        }

        private void SeleccionarAlumnoModificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Alumno' Puede moverla o quitarla según sea necesario.
          this.alumnoTableAdapter.Fill(this.alumnosDBDataSet.Alumno);

        }
       
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }
    }
}
