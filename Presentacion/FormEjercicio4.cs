using Entidades;
using LogicaNegocio;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEjercicio4 : Form
    {
        public FormEjercicio4()
        {
            InitializeComponent();
        }


        private double[,] GenerarMatrizSimetrica(int n)
        {
            Random rand = new Random();
            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matriz[i, j] = matriz[j, i] = rand.NextDouble() * 10;
                }
            }
            return matriz;
        }
        private void MostrarMatriz(DataGridView dgv, double[,] matriz)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            ConfigurarDataGridView(dataGridViewMatrizA);

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
        private void MostrarAutovalores(ListBox listBox, double[] autovalores)
        {
            listBox.Items.Clear();
            foreach (var autovalor in autovalores)
            {
                listBox.Items.Add(autovalor.ToString("F6"));
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
            //InicializarDataGridView(dataGridViewMatrizResultado);


        }

        private void InicializarDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
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
            dataGridViewMatrizA.Rows.Clear();
            dataGridViewMatrizA.Columns.Clear();
            lstAutovalores.Items.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numTamanioMatriz.Value;

                if (n <= 0)
                {
                    MessageBox.Show("El tamaño de la matriz debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[,] matrizData = GenerarMatrizSimetrica(n);
                var matriz = new JacobyEntity(matrizData);
                var jacobi = new JacobiSolver(matriz);

                MostrarMatriz(dataGridViewMatrizA, matriz.Data);
                MostrarAutovalores(lstAutovalores, jacobi.Eigenvalues);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEjercicio4_FormClosed(object sender, FormClosedEventArgs e)
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