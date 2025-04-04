namespace Presentacion
{
    partial class FormEjercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEjercicio2));
            this.buttonGenerarEcuaciones = new System.Windows.Forms.Button();
            this.textTamanio = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrizA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.lstSoluciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerarEcuaciones
            // 
            this.buttonGenerarEcuaciones.AutoSize = true;
            this.buttonGenerarEcuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarEcuaciones.Location = new System.Drawing.Point(488, 59);
            this.buttonGenerarEcuaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGenerarEcuaciones.Name = "buttonGenerarEcuaciones";
            this.buttonGenerarEcuaciones.Size = new System.Drawing.Size(196, 37);
            this.buttonGenerarEcuaciones.TabIndex = 0;
            this.buttonGenerarEcuaciones.Text = "Generar Sistema";
            this.buttonGenerarEcuaciones.UseVisualStyleBackColor = true;
            this.buttonGenerarEcuaciones.Click += new System.EventHandler(this.buttonGenerarEcuaciones_Click);
            // 
            // textTamanio
            // 
            this.textTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTamanio.Location = new System.Drawing.Point(387, 63);
            this.textTamanio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTamanio.Name = "textTamanio";
            this.textTamanio.Size = new System.Drawing.Size(77, 28);
            this.textTamanio.TabIndex = 1;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resolución de Sistemas de Ecuaciones Lineales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Cuántas ecuaciones desea resolver?";
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
            this.buttonCalcular.Location = new System.Drawing.Point(98, 110);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(198, 37);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Resolver Sistema";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewMatrizA);
            this.panel4.Location = new System.Drawing.Point(52, 261);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 249);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matriz A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soluciones del sistema:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AutoSize = true;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(387, 110);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(88, 37);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // lstSoluciones
            // 
            this.lstSoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSoluciones.FormattingEnabled = true;
            this.lstSoluciones.ItemHeight = 20;
            this.lstSoluciones.Location = new System.Drawing.Point(528, 261);
            this.lstSoluciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSoluciones.Name = "lstSoluciones";
            this.lstSoluciones.Size = new System.Drawing.Size(198, 244);
            this.lstSoluciones.TabIndex = 16;
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(790, 609);
            this.Controls.Add(this.lstSoluciones);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTamanio);
            this.Controls.Add(this.buttonGenerarEcuaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio2_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarEcuaciones;
        private System.Windows.Forms.TextBox textTamanio;
        private System.Windows.Forms.DataGridView dataGridViewMatrizA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.ListBox lstSoluciones;
    }
}