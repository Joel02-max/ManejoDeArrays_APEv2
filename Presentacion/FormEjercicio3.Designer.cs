namespace Presentacion
{
    partial class FormEjercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEjercicio3));
            this.buttonGenerarEcuaciones = new System.Windows.Forms.Button();
            this.textFilas = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrizA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dgvQ = new System.Windows.Forms.DataGridView();
            this.dgvr = new System.Windows.Forms.DataGridView();
            this.textColumnas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerarEcuaciones
            // 
            this.buttonGenerarEcuaciones.AutoSize = true;
            this.buttonGenerarEcuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarEcuaciones.Location = new System.Drawing.Point(405, 76);
            this.buttonGenerarEcuaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGenerarEcuaciones.Name = "buttonGenerarEcuaciones";
            this.buttonGenerarEcuaciones.Size = new System.Drawing.Size(196, 37);
            this.buttonGenerarEcuaciones.TabIndex = 0;
            this.buttonGenerarEcuaciones.Text = "Generar Matriz";
            this.buttonGenerarEcuaciones.UseVisualStyleBackColor = true;
            this.buttonGenerarEcuaciones.Click += new System.EventHandler(this.buttonGenerarEcuaciones_Click);
            // 
            // textFilas
            // 
            this.textFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilas.Location = new System.Drawing.Point(302, 63);
            this.textFilas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFilas.Name = "textFilas";
            this.textFilas.Size = new System.Drawing.Size(77, 28);
            this.textFilas.TabIndex = 1;
            // 
            // dataGridViewMatrizA
            // 
            this.dataGridViewMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrizA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrizA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatrizA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMatrizA.Name = "dataGridViewMatrizA";
            this.dataGridViewMatrizA.RowHeadersWidth = 51;
            this.dataGridViewMatrizA.RowTemplate.Height = 24;
            this.dataGridViewMatrizA.Size = new System.Drawing.Size(326, 249);
            this.dataGridViewMatrizA.TabIndex = 2;
            this.dataGridViewMatrizA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrizA_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descomposición QR de una Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de filas (M):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(98, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 8);
            this.panel1.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.AutoSize = true;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(403, 132);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(198, 37);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular QR";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewMatrizA);
            this.panel4.Location = new System.Drawing.Point(44, 409);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 249);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese los valores de la matriz A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resultados de la Matriz Q:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AutoSize = true;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(644, 108);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(88, 37);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // dgvQ
            // 
            this.dgvQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQ.Location = new System.Drawing.Point(413, 261);
            this.dgvQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQ.Name = "dgvQ";
            this.dgvQ.RowHeadersWidth = 51;
            this.dgvQ.RowTemplate.Height = 24;
            this.dgvQ.Size = new System.Drawing.Size(325, 249);
            this.dgvQ.TabIndex = 16;
            // 
            // dgvr
            // 
            this.dgvr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvr.Location = new System.Drawing.Point(413, 565);
            this.dgvr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvr.Name = "dgvr";
            this.dgvr.RowHeadersWidth = 51;
            this.dgvr.RowTemplate.Height = 24;
            this.dgvr.Size = new System.Drawing.Size(325, 216);
            this.dgvr.TabIndex = 17;
            // 
            // textColumnas
            // 
            this.textColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColumnas.Location = new System.Drawing.Point(302, 97);
            this.textColumnas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textColumnas.Name = "textColumnas";
            this.textColumnas.Size = new System.Drawing.Size(77, 28);
            this.textColumnas.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Número de columnas (N):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 528);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Resultados de la Matriz R:";
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(790, 609);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textColumnas);
            this.Controls.Add(this.dgvr);
            this.Controls.Add(this.dgvQ);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFilas);
            this.Controls.Add(this.buttonGenerarEcuaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarEcuaciones;
        private System.Windows.Forms.TextBox textFilas;
        private System.Windows.Forms.DataGridView dataGridViewMatrizA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridView dgvQ;
        private System.Windows.Forms.DataGridView dgvr;
        private System.Windows.Forms.TextBox textColumnas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}