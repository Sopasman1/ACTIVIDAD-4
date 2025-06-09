namespace ACTIVIDAD_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnRegistrar = new Button();
            btnMostrarTabular = new Button();
            btnMostrarGrafico = new Button();
            dataGridView1 = new DataGridView();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 51);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(194, 23);
            txtProducto.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 185);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(194, 23);
            txtPrecio.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 119);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(194, 23);
            txtCantidad.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 253);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Venta";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnMostrarTabular
            // 
            btnMostrarTabular.Location = new Point(12, 323);
            btnMostrarTabular.Name = "btnMostrarTabular";
            btnMostrarTabular.Size = new Size(153, 23);
            btnMostrarTabular.TabIndex = 4;
            btnMostrarTabular.Text = "Mostrar Reporte Tabular";
            btnMostrarTabular.UseVisualStyleBackColor = true;
            btnMostrarTabular.Click += btnMostrarTabular_Click;
            // 
            // btnMostrarGrafico
            // 
            btnMostrarGrafico.Location = new Point(12, 393);
            btnMostrarGrafico.Name = "btnMostrarGrafico";
            btnMostrarGrafico.Size = new Size(116, 23);
            btnMostrarGrafico.TabIndex = 5;
            btnMostrarGrafico.Text = "Mostrar Gráfico";
            btnMostrarGrafico.UseVisualStyleBackColor = true;
            btnMostrarGrafico.Click += btnMostrarGrafico_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(264, 413);
            dataGridView1.TabIndex = 6;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(482, 12);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(306, 426);
            formsPlot1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlot1);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrarGrafico);
            Controls.Add(btnMostrarTabular);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnRegistrar;
        private Button btnMostrarTabular;
        private Button btnMostrarGrafico;
        private DataGridView dataGridView1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}
