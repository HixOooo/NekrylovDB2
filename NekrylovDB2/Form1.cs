using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class MainForm : MaterialForm
    {
        private readonly string _connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public MainForm()
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

            LoadRecentProducts();
            LoadRecentSupplies();
            LoadRecentOrders();
        }

        private void LoadRecentProducts()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT Название, Количество, Цена FROM Товары ORDER BY КодТовара DESC LIMIT 5", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridRecentProducts.DataSource = table;
                }
            }
        }

        private void LoadRecentSupplies()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT КодТовара, Количество, Поставщик, ДатаПоставки FROM Поставки ORDER BY КодПоставки DESC LIMIT 5", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridRecentSupplies.DataSource = table;
                }
            }
        }

        private void LoadRecentOrders()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT КодТовара, Количество, Статус, ДатаЗаказа FROM Заказы ORDER BY КодЗаказа DESC LIMIT 5", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridRecentOrders.DataSource = table;
                }
            }
        }

        private void btnRefreshRecentData_Click(object sender, EventArgs e)
        {
            LoadRecentProducts();
            LoadRecentSupplies();
            LoadRecentOrders();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            var suppliesForm = new SuppliesForm();
            suppliesForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}