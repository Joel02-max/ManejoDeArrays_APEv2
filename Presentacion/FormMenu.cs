using Entidades;
using LogicaNegocio;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormMenu : Form
    {
        private MatrizNegocio matrizNegocio = new MatrizNegocio();

        public FormMenu()
        {
            InitializeComponent();
        }

        private FormEjercicio1 ejercicio1; // Declaración global

        // Método para abrir formularios dinámicamente
        private void OpenForm(Type formType)
        {
            Form form = (Form)Activator.CreateInstance(formType); // Crear una instancia del formulario
            form.Owner = this; // Asignar el menú principal como propietario
            form.FormClosed += (s, e) => this.Show(); // Mostrar el menú principal cuando se cierre el formulario
            form.Show(); // Mostrar el formulario
            this.Hide(); // Esconder el menú principal
        }

        // Ejemplo de uso para un botón
        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormEjercicio1)); // Abre el formulario para el ejercicio 1
        }

        private void buttonResolucionEcuaciones_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormEjercicio2));
        }

        private void btnEjercicioQr_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormEjercicio3));
        }

        private void buttonJacoby_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormEjercicio4));
        }

        private void buttonDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta relativa al archivo PDF desde el ejecutable
                string rutaPDF = System.IO.Path.Combine(Application.StartupPath, "Documents", "DocumentacionProyecto.pdf");

                // Verifica que el archivo exista antes de intentar abrirlo
                if (System.IO.File.Exists(rutaPDF))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = rutaPDF,
                        UseShellExecute = true // Usa el visor predeterminado del sistema
                    });
                }
                else
                {
                    MessageBox.Show("No se encuentra el archivo de documentación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la documentación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializa lógica o recursos necesarios aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el menú: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}