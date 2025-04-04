using Entidades;
using LogicaNegocio;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEjercicio3 : Form
    {
        private SistemaEcuacionesNegocio sistemaBL;
        private SistemaEcuacionesEntidad sistema;

        public FormEjercicio3()
        {
            InitializeComponent();
            sistemaBL = new SistemaEcuacionesNegocio();
        }
        private void FormEjercicio2_Load(object sender, EventArgs e)
        {
            int n = 3; // Número de ecuaciones
            ConfigurarDataGridView(dataGridViewMatrizA);
            // Limpiar cualquier dato previo en el DataGridView
            dataGridViewMatrizA.Columns.Clear();
            dataGridViewMatrizA.Rows.Clear();
            dataGridViewMatrizA.AllowUserToAddRows = false;
            ConfigurarDataGridView(dgvQ);
            ConfigurarDataGridView(dgvr);


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
            textColumnas.Clear();
            textFilas.Clear();
            dataGridViewMatrizA.Rows.Clear();
            dataGridViewMatrizA.Columns.Clear();
            dgvQ.Rows.Clear();
            dgvQ.Columns.Clear();
            dgvr.Rows.Clear();
            dgvr.Columns.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void buttonGenerarEcuaciones_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el usuario haya ingresado valores válidos para M y N
                if (!int.TryParse(textFilas.Text, out int m) || m <= 0)
                {
                    MessageBox.Show("Por favor ingrese un número válido para las filas (M).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textColumnas.Text, out int n) || n <= 0)
                {
                    MessageBox.Show("Por favor ingrese un número válido para las columnas (N).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Limpiar cualquier configuración previa en el DataGridView
                dgvQ.Columns.Clear();
                dgvQ.Rows.Clear();
                dgvr.Rows.Clear();
                dgvr.Rows.Clear();
                dataGridViewMatrizA.Columns.Clear();
                dataGridViewMatrizA.Rows.Clear();
                dataGridViewMatrizA.AllowUserToAddRows = false; // Evitar filas adicionales

                // Generar columnas dinámicamente
                for (int i = 0; i < n; i++)
                {
                    dataGridViewMatrizA.Columns.Add($"Col{i}", $"Col {i + 1}"); // Nombrar columnas
                }

                // Establecer el número de filas
                dataGridViewMatrizA.RowCount = m;

                MessageBox.Show($"Se ha generado una matriz de {m} filas y {n} columnas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                // Validar que el DataGridView tiene dimensiones válidas
                int m = dataGridViewMatrizA.RowCount;
                int n = dataGridViewMatrizA.ColumnCount;

                if (m < n)
                {
                    MessageBox.Show("El número de filas (M) debe ser mayor o igual al número de columnas (N).", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[,] data = new double[m, n];

                // Leer datos del DataGridView con validaciones
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (dataGridViewMatrizA.Rows[i].Cells[j].Value == null || string.IsNullOrWhiteSpace(dataGridViewMatrizA.Rows[i].Cells[j].Value.ToString()))
                        {
                            MessageBox.Show($"Por favor ingrese todos los valores en la fila {i + 1}, columna {j + 1}.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!double.TryParse(dataGridViewMatrizA.Rows[i].Cells[j].Value.ToString(), out double value))
                        {
                            MessageBox.Show($"Valor no válido en la fila {i + 1}, columna {j + 1}. Asegúrese de ingresar números.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        data[i, j] = value;
                    }
                }

                // Crear objeto MatrixEntity y calcular QR
                var matriz = new MatrixEntity(data);
                var qr = new QrDecomposition(matriz);

                MostrarMatriz(dgvQ, qr.Q.Data);
                MostrarMatriz(dgvr, qr.R.Data);

                MessageBox.Show("Descomposición QR completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MostrarMatriz(DataGridView dgv, double[,] matriz)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < columnas; i++)
            {
                dgv.Columns.Add($"Col{i}", $"Col {i + 1}");
            }
            dgv.RowCount = filas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz[i, j].ToString("F4");
                }
            }
        }

        private void FormEjercicio3_FormClosed(object sender, FormClosedEventArgs e)
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

        private void dataGridViewMatrizA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}