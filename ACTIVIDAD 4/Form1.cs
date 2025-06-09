using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.WinForms;

namespace ACTIVIDAD_4
{
    public partial class Form1 : Form
    {

        private List<Venta> ventas = new List<Venta>();
        public Form1()
        {
            InitializeComponent();
            formsPlot1.Visible = false;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var venta = new Venta
                {
                    Producto = txtProducto.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    PrecioUnitario = decimal.Parse(txtPrecio.Text)
                };
                ventas.Add(venta);
                MessageBox.Show("Venta registrada correctamente");
                txtProducto.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }

        private void btnMostrarTabular_Click(object sender, EventArgs e)
        {
            formsPlot1.Visible = false;
            dataGridView1.Visible = true;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ventas.Select(v => new
            {
                v.Producto,
                v.Cantidad,
                v.PrecioUnitario,
                Total = v.Total
            }).ToList();
        }

        private void btnMostrarGrafico_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            formsPlot1.Visible = true;

            // Limpia el gráfico
            formsPlot1.Plot.Clear();

            // Agrupar ventas por producto
            var resumen = ventas
                .GroupBy(v => v.Producto)
                .Select(g => new
                {
                    Producto = g.Key,
                    TotalVentas = g.Sum(v => (double)v.Total)
                }).ToList();

            if (resumen.Count == 0)
            {
                MessageBox.Show("No hay datos para graficar");
                return;
            }

            string[] productos = resumen.Select(r => r.Producto).ToArray();
            double[] totales = resumen.Select(r => r.TotalVentas).ToArray();

            // Crear gráfico de barras
            var barras = formsPlot1.Plot.Addbar(totales);
            barras.FillColor = Colors.Blue.WithAlpha(0.7);

            // Posicionar etiquetas en el eje X
            formsPlot1.Plot.Axes.Bottom.TickLabels(productos);

            // Títulos
            formsPlot1.Plot.Title("Ventas por Producto");
            formsPlot1.Plot.Axes.Left.Label.Text = "Total ($)";
            formsPlot1.Plot.Axes.Bottom.Label.Text = "Producto";

            // Refrescar
            formsPlot1.Refresh();
        }

        
    }
}
