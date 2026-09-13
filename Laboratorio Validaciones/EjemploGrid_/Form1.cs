using System;
using System.Windows.Forms;
using System.Collections;

namespace EjemploGrid_
{
    public partial class Form1 : Form
    {
        // Lista donde se van guardando todos los empleados capturados
        ArrayList listaPersonas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dato de ejemplo para que el grid no arranque vacío (opcional)
            Persona miEmpleado1 = new Persona();
            miEmpleado1.Id = 1;
            miEmpleado1.Nombres = "Elena Carolina";
            miEmpleado1.Apellidos = "Gonzalez Rodriguez";
            miEmpleado1.Correo = "elena.gonzalez@ejemplo.com";
            miEmpleado1.FechaNacimiento = new DateTime(1990, 5, 15);
            miEmpleado1.Salario = 850.00m;

            listaPersonas.Add(miEmpleado1);
            dgvDatos.DataSource = listaPersonas;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Validar IdEmpleado
            if (txtIdEmpleado.Text == "")
            {
                errorProvider1.SetError(txtIdEmpleado, "Ingrese un ID");
                txtIdEmpleado.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtIdEmpleado, "");
            }

            // Validar Nombre
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del empleado");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            // Validar Apellido
            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese el apellido del empleado");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }

            // Validar Email (usa la clase Utilidades del paso 2)
            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // Validar Salario (decimal.TryParse evita que truene si escriben texto)
            decimal salarioValidado;
            if (!decimal.TryParse(txtSalario.Text, out salarioValidado))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            // Si todo pasó la validación, arma el objeto y lo agrega a la lista
            Persona nuevoEmpleado = new Persona();
            nuevoEmpleado.Id = int.Parse(txtIdEmpleado.Text);
            nuevoEmpleado.Nombres = txtNombre.Text;
            nuevoEmpleado.Apellidos = txtApellido.Text;
            nuevoEmpleado.Correo = txtEmail.Text;
            nuevoEmpleado.Salario = salarioValidado;
            nuevoEmpleado.FechaNacimiento = dtpFNacimiento.Value;   // viene del DateTimePicker

            listaPersonas.Add(nuevoEmpleado);

            // Refrescar el grid (hay que "resetear" el DataSource para que se vea el nuevo dato)
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaPersonas;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtIdEmpleado.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSalario.Text = string.Empty;
            dtpFNacimiento.Value = DateTime.Now;
        }
    }
    
}


