namespace Presentacion
{
    partial class FormEjercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEjercicio1));
            this.button1 = new System.Windows.Forms.Button();
            this.textTamanio = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrizA = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrizB = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrizResultado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizResultado)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(98, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Matrices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTamanio
            // 
            this.textTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTamanio.Location = new System.Drawing.Point(478, 63);
            this.textTamanio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTamanio.Name = "textTamanio";
            this.textTamanio.Size = new System.Drawing.Size(206, 28);
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
            // dataGridViewMatrizB
            // 
            this.dataGridViewMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrizB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrizB.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatrizB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMatrizB.Name = "dataGridViewMatrizB";
            this.dataGridViewMatrizB.RowHeadersWidth = 51;
            this.dataGridViewMatrizB.RowTemplate.Height = 24;
            this.dataGridViewMatrizB.Size = new System.Drawing.Size(326, 249);
            this.dataGridViewMatrizB.TabIndex = 3;
            // 
            // dataGridViewMatrizResultado
            // 
            this.dataGridViewMatrizResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrizResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrizResultado.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatrizResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMatrizResultado.Name = "dataGridViewMatrizResultado";
            this.dataGridViewMatrizResultado.RowHeadersWidth = 51;
            this.dataGridViewMatrizResultado.RowTemplate.Height = 24;
            this.dataGridViewMatrizResultado.Size = new System.Drawing.Size(326, 249);
            this.dataGridViewMatrizResultado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Multiplicación de Matrices - Matrices Cuadradas N x N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el tamaño de las matrices (N x N):";
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
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.AutoSize = true;
            this.buttonMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.Location = new System.Drawing.Point(478, 110);
            this.buttonMultiplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(199, 37);
            this.buttonMultiplicar.TabIndex = 8;
            this.buttonMultiplicar.Text = "Multiplicar matrices";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewMatrizResultado);
            this.panel2.Location = new System.Drawing.Point(221, 515);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 249);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewMatrizB);
            this.panel3.Location = new System.Drawing.Point(418, 195);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 249);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewMatrizA);
            this.panel4.Location = new System.Drawing.Point(44, 195);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 249);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 158);
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
            this.label4.Location = new System.Drawing.Point(415, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Matriz B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 480);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resultado";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AutoSize = true;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(341, 110);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(88, 37);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(794, 364);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTamanio);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio1_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizResultado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTamanio;
        private System.Windows.Forms.DataGridView dataGridViewMatrizA;
        private System.Windows.Forms.DataGridView dataGridViewMatrizB;
        private System.Windows.Forms.DataGridView dataGridViewMatrizResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}