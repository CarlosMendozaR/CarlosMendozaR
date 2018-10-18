using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ActividadColas
{
    public partial class Form1 : Form
    {
        Queue<Alumno> colaAlumno = new Queue<Alumno>();
        Alumno alumnoNuevo;
        bool aprobado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if(float.Parse(txtbAciertos.Text) >10f || float.Parse(txtbAciertos.Text) < 0)
                {
                    throw new ApplicationException("Calificacion incorrecta");
                }
                if (float.Parse(txtbAciertos.Text) > 6f)
                {
                    aprobado = true;
                }
                else
                {
                    aprobado = false;
                }
                alumnoNuevo = new Alumno(float.Parse(txtbAciertos.Text), txtbNombre.Text, aprobado);
                colaAlumno.Enqueue(alumnoNuevo);
                txtbAlumnoCalificar.Text = colaAlumno.Peek().Nombre;
                txtbNombre.Clear();
                txtbAciertos.Clear();
                errorProvider1.Clear();
            }
            catch (ApplicationException error)
            {
                errorProvider1.SetError(btnAñadir, error.Message);
            }
            catch (FormatException)
            {
                errorProvider1.SetError(btnAñadir, "Formato incorrecto");
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(colaAlumno.Count == 0)
                {
                    txtbAlumnoCalificar.Clear();
                    throw new ApplicationException("No hay mas alumnos por calificar");
                }
                txtbAlumnoCalificar.Text = colaAlumno.Peek().Nombre;
                MessageBox.Show("Se ha calificado a: " + colaAlumno.Peek().Nombre + "\nAprovado: " + colaAlumno.Dequeue().Aprovado);
                if (colaAlumno.Count == 0)
                {
                    txtbAlumnoCalificar.Clear();
                }
            }
            catch (ApplicationException error)
            {
                errorProvider1.SetError(btnCalificar, error.Message);
            }
        }
    }
}
