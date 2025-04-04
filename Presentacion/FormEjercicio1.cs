using Entidades;
using LogicaNegocio;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEjercicio1 : Form
    {
        private MatrizNegocio matrizNegocio = new MatrizNegocio();

        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textTamanio.Text);
                if (n <= 0) throw new ArgumentException("El tamaño de la matriz debe ser mayor a 0.");

                // Deshabilitar botones para evitar bloqueos
                button1.Enabled = false;

                // Generar matrices en una tarea asíncrona
                Task.Run(() =>
                {
                    MatrizEntidad matrizA = matrizNegocio.GenerarMatriz(n);
                    MatrizEntidad matrizB = matrizNegocio.GenerarMatriz(n);

                    // Actualizar la UI en el hilo principal para mostrar las matrices generadas
                    Invoke((MethodInvoker)delegate
                    {
                        MostrarMatriz(dataGridViewMatrizA, matrizA);
                        MostrarMatriz(dataGridViewMatrizB, matrizB);

                        ConfigurarDataGridView(dataGridViewMatrizA);
                        ConfigurarDataGridView(dataGridViewMatrizB);

                        AjustarTamanioDataGridView(dataGridViewMatrizA, n, n);
                        AjustarTamanioDataGridView(dataGridViewMatrizB, n, n);

                        button1.Enabled = true;
                        label5.Visible = false;
                        dataGridViewMatrizResultado.Columns.Clear();
                        buttonMultiplicar.Focus();
                    });
                });
            }
            catch (Exception )
            {
                MessageBox.Show($"Error: Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                textTamanio.Focus();
            }

        }

        private void MostrarMatriz(DataGridView dgv, MatrizEntidad matriz)
        {
            dgv.SuspendLayout();
            dgv.Enabled = false;
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int n = matriz.N;
            dgv.ColumnCount = n;
            dgv.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz.Valores[i, j];
                }
            }

            dgv.Enabled = true;
            dgv.ResumeLayout();
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(240, 240, 240); // 
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            //dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.GridColor = Color.Gray;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
        }

        private void AjustarTamanioDataGridView(DataGridView dgv, int filas, int columnas)
        {
            int anchoColumna = 50;
            int altoFila = 30;
            int padding = 10;

            // Calcular tamaño dinámico
            int anchoTotal = Math.Min((columnas * anchoColumna) + padding, dgv.Parent.Width - 20);
            int altoTotal = Math.Min((filas * altoFila) + dgv.ColumnHeadersHeight + padding, dgv.Parent.Height - 20);

            // Ajustar dimensiones
            dgv.Width = anchoTotal;
            dgv.Height = altoTotal;

            // Forzar ajuste de filas y columnas al contenido
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            // Posicionar la matriz resultado debajo de Matriz A y B

        }

        private void FormEjercicio1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            InicializarDataGridView(dataGridViewMatrizA);
            InicializarDataGridView(dataGridViewMatrizB);
            //InicializarDataGridView(dataGridViewMatrizResultado);
            dataGridViewMatrizResultado.BackgroundColor= Color.FromArgb(240, 240, 240);
            dataGridViewMatrizResultado.BorderStyle = BorderStyle.None;

        }

        private void InicializarDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si los DataGridView están vacíos
                if (dataGridViewMatrizA.Rows.Count == 0 || dataGridViewMatrizB.Rows.Count == 0)
                {
                    MessageBox.Show("Primero genere matrices para realizar la multiplicación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textTamanio.Focus();
                    return;
                }

                // Deshabilitar botones para evitar bloqueos
                buttonMultiplicar.Enabled = false;
                label5.Visible = true;

                // Realizar la multiplicación de matrices en una tarea asíncrona
                Task.Run(() =>
                {
                    try
                    {
                        MatrizEntidad matrizA = ObtenerMatrizDesdeDataGridView(dataGridViewMatrizA);
                        MatrizEntidad matrizB = ObtenerMatrizDesdeDataGridView(dataGridViewMatrizB);

                        // Verificar si las matrices son compatibles para la multiplicación
                        if (matrizA.N != matrizB.N)
                        {
                            throw new InvalidOperationException("El número de columnas de la primera matriz debe coincidir con el número de filas de la segunda.");
                        }

                        MatrizEntidad resultado = matrizNegocio.MultiplicarMatrices(matrizA, matrizB);

                        // Actualizar la UI en el hilo principal para mostrar el resultado
                        Invoke((MethodInvoker)delegate
                        {
                            MostrarMatriz(dataGridViewMatrizResultado, resultado);
                            ConfigurarDataGridView(dataGridViewMatrizResultado);
                            AjustarTamanioDataGridView(dataGridViewMatrizResultado, resultado.N, resultado.N);
                            buttonMultiplicar.Enabled = true;
                        });
                    }
                    catch (Exception ex)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            buttonMultiplicar.Enabled = true;
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonMultiplicar.Enabled = true;
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
            label5.Visible = false;
            textTamanio.Clear();
            dataGridViewMatrizA.Rows.Clear();
            dataGridViewMatrizA.Columns.Clear();
            dataGridViewMatrizB.Rows.Clear();
            dataGridViewMatrizB.Columns.Clear();
            dataGridViewMatrizResultado.Rows.Clear();
            dataGridViewMatrizResultado.Columns.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void FormEjercicio1_FormClosed(object sender, FormClosedEventArgs e)
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