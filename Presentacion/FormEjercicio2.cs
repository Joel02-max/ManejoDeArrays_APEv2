using Entidades;
using LogicaNegocio;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEjercicio2 : Form
    {
        private SistemaEcuacionesNegocio sistemaBL;
        private SistemaEcuacionesEntidad sistema;

        public FormEjercicio2()
        {
            InitializeComponent();
            sistemaBL = new SistemaEcuacionesNegocio();
        }
        private void FormEjercicio2_Load(object sender, EventArgs e)
        {
            int n = 2; // Número de ecuaciones
            ConfigurarDataGridView(dataGridViewMatrizA);
            // Limpiar cualquier dato previo en el DataGridView
            dataGridViewMatrizA.Columns.Clear();
            dataGridViewMatrizA.Rows.Clear();
            dataGridViewMatrizA.AllowUserToAddRows = false;


            // Agregar columnas (n incógnitas + 1 para el término independiente)
            for (int i = 0; i < n; i++)
            {
                dataGridViewMatrizA.Columns.Add($"x{i + 1}", $"x{i + 1}");
            }
            dataGridViewMatrizA.Columns.Add("Resultado", "Resultado");

            // Agregar filas (tantas como ecuaciones)
            dataGridViewMatrizA.RowCount = n;

        }


        private void ConfigurarDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración de celdas
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Regular); // Fuente tamaño 14

            dgv.GridColor = Color.Gray;
            dgv.AllowUserToResizeColumns = false; // Desactiva el ajuste de tamaño por el usuario
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Establecer el tamaño de las celdas a 30x30 píxeles
            dgv.RowTemplate.Height = 30;  // Altura de fila fija en 30 px
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Width = 3;  // Ancho de columna fijo en 30 px
            }

        }
        private MatrizEntidad ObtenerMatrizDesdeDataGridView(DataGridView dgv)
        {
            int n = dgv.RowCount;
            int[,] valores = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    valores[i, j] = Convert.ToInt32(dgv.Rows[i].Cells[j].Value);
                }
            }

            return new MatrizEntidad { N = n, Valores = valores };
        }
        private void LimpiarFormulario()
        {
            textTamanio.Clear();
            dataGridViewMatrizA.Rows.Clear();
            dataGridViewMatrizA.Columns.Clear();
            lstSoluciones.Items.Clear(); // Esto elimina todos los elementos del ListBox.
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void buttonGenerarEcuaciones_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar la entrada del usuario
                if (!int.TryParse(textTamanio.Text, out int n) || n <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número válido de ecuaciones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Limpiar cualquier configuración previa
                dataGridViewMatrizA.Columns.Clear();
                dataGridViewMatrizA.Rows.Clear();
                dataGridViewMatrizA.AllowUserToAddRows = false; // Evitar filas adicionales

                // Crear columnas dinámicamente (n incógnitas + 1 columna para el término independiente)
                for (int i = 0; i < n; i++)
                {
                    dataGridViewMatrizA.Columns.Add($"x{i + 1}", $"x{i + 1}"); // Columnas para las incógnitas
                }
                dataGridViewMatrizA.Columns.Add("Resultado", "Resultado"); // Columna para el término independiente

                // Crear filas (tantas como ecuaciones)
                dataGridViewMatrizA.RowCount = n;

                MessageBox.Show($"Se ha generado un sistema de {n} ecuaciones con {n} incógnitas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridViewMatrizA.RowCount; // Número de ecuaciones

                // Verificar si el DataGridView está vacío
                bool estaVacio = true;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (dataGridViewMatrizA.Rows[i].Cells[j].Value != null &&
                            !string.IsNullOrWhiteSpace(dataGridViewMatrizA.Rows[i].Cells[j].Value.ToString()))
                        {
                            estaVacio = false;
                            break;
                        }
                    }
                    if (!estaVacio) break;
                }

                if (estaVacio)
                {
                    MessageBox.Show("Error: Ingrese valores en la matriz antes de calcular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sistema = new SistemaEcuacionesEntidad(n);

                // Cargar datos desde el DataGridView con validación
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        var cellValue = dataGridViewMatrizA.Rows[i].Cells[j].Value;

                        // Validar si la celda está vacía
                        if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                        {
                            MessageBox.Show($"Error: Celda vacía en la fila {i + 1}, columna {j + 1}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detiene la ejecución si hay una celda vacía
                        }

                        // Validar si el valor es convertible a double
                        if (!double.TryParse(cellValue.ToString(), out double result))
                        {
                            MessageBox.Show($"Error: Valor no numérico en la fila {i + 1}, columna {j + 1}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detiene la ejecución si hay un valor inválido
                        }

                        // Asignar el valor convertido a la matriz
                        sistema.Matriz[i, j] = result;
                    }
                }

                // Aplicar eliminación de Gauss
                sistemaBL.EliminacionGauss(sistema);

                // Resolver el sistema
                double[] soluciones = sistemaBL.ResolverSistema(sistema);

                // Mostrar las soluciones
                lstSoluciones.Items.Clear();
                for (int i = 0; i < soluciones.Length; i++)
                {
                    lstSoluciones.Items.Add($"x{i + 1} = {soluciones[i]:0.##}");
                }

                MessageBox.Show("Sistema resuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEjercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null) // Verifica que el menú exista
            {
                DialogResult result = MessageBox.Show("¿Desea regresar al menú principal?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Owner.Show(); // Vuelve a mostrar el menú
                }
            }

        }
    }
}