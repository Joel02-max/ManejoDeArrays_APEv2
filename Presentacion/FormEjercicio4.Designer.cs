namespace Presentacion
{
    partial class FormEjercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEjercicio4));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMatrizA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.numTamanioMatriz = new System.Windows.Forms.NumericUpDown();
            this.lstAutovalores = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanioMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(723, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Matrices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMatrizA
            // 
            this.dataGridViewMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrizA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrizA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatrizA.Name = "dataGridViewMatrizA";
            this.dataGridViewMatrizA.RowHeadersWidth = 51;
            this.dataGridViewMatrizA.RowTemplate.Height = 24;
            this.dataGridViewMatrizA.Size = new System.Drawing.Size(434, 307);
            this.dataGridViewMatrizA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Método de Jacobi para Cálculo de Autovalores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el tamaño de las matrices (N x N):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(130, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 10);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewMatrizA);
            this.panel4.Location = new System.Drawing.Point(58, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 307);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matriz generada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(717, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Autovalores encontrados:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AutoSize = true;
            this.buttonLimpiar.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(794, 128);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(117, 46);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // numTamanioMatriz
            // 
            this.numTamanioMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTamanioMatriz.Location = new System.Drawing.Point(575, 82);
            this.numTamanioMatriz.Name = "numTamanioMatriz";
            this.numTamanioMatriz.Size = new System.Drawing.Size(120, 34);
            this.numTamanioMatriz.TabIndex = 16;
            // 
            // lstAutovalores
            // 
            this.lstAutovalores.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAutovalores.FormattingEnabled = true;
            this.lstAutovalores.ItemHeight = 36;
            this.lstAutovalores.Location = new System.Drawing.Point(723, 240);
            this.lstAutovalores.Name = "lstAutovalores";
            this.lstAutovalores.Size = new System.Drawing.Size(246, 292);
            this.lstAutovalores.TabIndex = 17;
            // 
            // FormEjercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1053, 952);
            this.Controls.Add(this.lstAutovalores);
            this.Controls.Add(this.numTamanioMatriz);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEjercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio4_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizA)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTamanioMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMatrizA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.NumericUpDown numTamanioMatriz;
        private System.Windows.Forms.ListBox lstAutovalores;
    }
}