using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class OrdersForm : MaterialForm
    {
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public OrdersForm()
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

            LoadOrders();
        }

        private void LoadOrders()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT КодЗаказа, КодТовара, Количество, Статус, ДатаЗаказа FROM Заказы", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridOrders.DataSource = table;
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm();
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                LoadOrders();
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridOrders.SelectedRows[0];
                var orderId = Convert.ToInt32(selectedRow.Cells["КодЗаказа"].Value);

                var editOrderForm = new EditOrderForm(orderId);
                if (editOrderForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrders();
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridOrders.SelectedRows[0];
                var orderId = Convert.ToInt32(selectedRow.Cells["КодЗаказа"].Value);

                var result = MessageBox.Show("Вы уверены, что хотите удалить этот заказ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();

                        using (var cmd = new NpgsqlCommand("DELETE FROM Заказы WHERE КодЗаказа = @КодЗаказа", conn))
                        {
                            cmd.Parameters.AddWithValue("@КодЗаказа", orderId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadOrders();
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}