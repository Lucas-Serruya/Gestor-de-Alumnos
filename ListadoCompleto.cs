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
    public partial class ListadoCompleto : Form
    {
        int DNI, telefono, celu;
        short borrar, filtroId;
       // string Nombre, Apellido, direccion;
        public ListadoCompleto()
        {
            InitializeComponent();
        }
        static public int ComprobarInt(int i, int j)
        {
            int numero;
            while (int.TryParse(Console.ReadLine(), out numero) == false || numero > j || numero < i)
            {
                Console.WriteLine("Valor incorrecto, vuelva a ingresar");
            }
            return numero; //numero es donde se guarda el valor que se pide por consola
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoCompleto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.alumnosDBDataSet.Alumno);

        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
             alumnoTableAdapter.Fill(alumnosDBDataSet.Alumno);
            
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            alumnoTableAdapter.Fill(alumnosDBDataSet.Alumno);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            alumnoTableAdapter.borrar(borrar);
            alumnoTableAdapter.Fill(alumnosDBDataSet.Alumno);
        }

        private void BtnFiltrarId_Click(object sender, EventArgs e)
        {
           
            alumnoTableAdapter.FillBy(alumnosDBDataSet.Alumno, borrar);
        }

        private void BtnFiltrarCurso_Click(object sender, EventArgs e)
        {
            
            alumnoTableAdapter.Fill(alumnosDBDataSet.Alumno);
        }

        




        private void TxtBorrar_TextChanged(object sender, EventArgs e)
        {
            int salida;
            if (int.TryParse(TxtBorrar.Text, out salida))
            {
                filtroId = Convert.ToInt16(TxtBorrar.Text);
                borrar = Convert.ToInt16(TxtBorrar.Text);
            }
        }

        private void BtnRetorno_Click(object sender, EventArgs e)
        {
            Form1 formu = new Form1();
            this.Hide();
            formu.Show();
        }

        private void TxtBorrar_MouseClick(object sender, MouseEventArgs e)
        {
            TxtBorrar.Text = "";
        }

       

        private void LblHora_Click(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void ListadoCompleto_MouseEnter(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
