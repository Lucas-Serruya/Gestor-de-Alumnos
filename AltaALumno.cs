using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestor_De_Alumnos_V1._0
{

    
    public partial class AltaALumno : Form
    {
        int DNI, telefono, celu;
        int provi;
       short curso;
         Boolean  Comprobar(string s)
        {
            bool retorno = false;
            int numero;
           if (int.TryParse(s,out numero) == false)
            {
                retorno = true;
            }
            return retorno;
        }
            
  
        public  bool ComprobarLetras(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public AltaALumno()
        {
            InitializeComponent();
        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarLetras(TxtNombre.Text) == true && ComprobarLetras(TxtApellido.Text) == true&& Comprobar(TxtDNI.Text) == false && Comprobar(TxtTelefono.Text) == false && Comprobar(TxtCelular.Text) == false && Comprobar(TxtCurso.Text) == false)
            {
                DNI = Convert.ToInt32(TxtDNI.Text);
                telefono = Convert.ToInt32(TxtTelefono.Text);
                curso = Convert.ToInt16(TxtCurso.Text);
                celu = Convert.ToInt32(TxtCelular.Text);
                
                
                alumnoTableAdapter.Insertar(DNI, TxtNombre.Text, TxtApellido.Text, BtnDirecc.Text, telefono, celu, 2);
                // BtnGuardar.Enabled = false;
                //limpio todo cuando presiono guardar
                TxtNombre.Text = "Ingrese aqui el/los nombre";
                TxtApellido.Text = "Ingrese aqui el/los apellido";
                TxtDNI.Text = "Ingrese aqui el DNI";
                BtnDirecc.Text = "Ingrese aqui la dirección";
                TxtTelefono.Text = "Ingrese aqui el teléfono";
                TxtCelular.Text = "Ingrese aqui el celular";
                TxtCurso.Text = "Ingrese aqui el curso";
                // if (ComprobarLetras(TxtNombre.Text)
            }
            else
            {
                MessageBox.Show("hay valores incorrectos");
            }
           
          
        }

        private void TxtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            TxtNombre.Text = string.Empty;
        }

        private void TxtApellido_MouseClick(object sender, MouseEventArgs e)
        {
            TxtApellido.Text = string.Empty;
        }

        private void TxtDNI_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDNI.Text = string.Empty;
        }

        private void BtnDirecc_MouseClick(object sender, MouseEventArgs e)
        {
            BtnDirecc.Text = string.Empty;
        }

        private void TxtTelefono_MouseClick(object sender, MouseEventArgs e)
        {
            TxtTelefono.Text = string.Empty;
        }

        private void TxtCelular_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCelular.Text = string.Empty;
        }

        private void TxtCurso_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCurso.Text = string.Empty;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
          
        
           
        }

        private void AltaALumno_Load_1(object sender, EventArgs e)
        {

        }

        private void Btnvolver_Click(object sender, EventArgs e)
        {
            Form1 formu = new Form1();
            this.Hide();
            formu.Show();
        }

        private void TxtCurso_TextChanged(object sender, EventArgs e)
        {
            if (Comprobar(TxtCurso.Text) == false && TxtCurso.Text != "")
            {
                provi = Convert.ToInt32(TxtCurso.Text);
                   if (provi > 9 || provi < 1)
                       MessageBox.Show("El curso es incorrecto, debe tener 1 solo digito");
            }
        }
    }
}
