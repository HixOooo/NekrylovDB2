using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class PopularProductsReportForm : MaterialForm
    {
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public PopularProductsReportForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            LoadPopularProductsReport();
        }

        private void LoadPopularProductsReport()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Популярные товары (по количеству заказов)
                using (var cmd = new NpgsqlCommand("SELECT т.Название, COUNT(з.КодЗаказа) AS TotalOrders FROM Заказы з JOIN Товары т ON з.КодТовара = т.КодТовара GROUP BY т.Название ORDER BY TotalOrders DESC", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridPopularProducts.DataSource = table;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToCSV(dataGridPopularProducts, "PopularProductsReport.csv");
            MessageBox.Show("Отчет экспортирован в PopularProductsReport.csv", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToCSV(DataGridView dataGrid, string fileName)
        {
            using (var writer = new System.IO.StreamWriter(fileName))
            {
                // Заголовки столбцов
                var headers = new System.Text.StringBuilder();
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    headers.Append(dataGrid.Columns[i].HeaderText);
                    if (i < dataGrid.Columns.Count - 1) headers.Append(",");
                }
                writer.WriteLine(headers.ToString());

                // Данные
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    var rowData = new System.Text.StringBuilder();
                    for (int i = 0; i < dataGrid.Columns.Count; i++)
                    {
                        rowData.Append(row.Cells[i].Value?.ToString());
                        if (i < dataGrid.Columns.Count - 1) rowData.Append(",");
                    }
                    writer.WriteLine(rowData.ToString());
                }
            }
        }
    }
}