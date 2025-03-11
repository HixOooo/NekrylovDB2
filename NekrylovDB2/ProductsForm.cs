using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class ProductsForm : MaterialForm
    {
        // Строка подключения к базе данных
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public ProductsForm()
        {
            InitializeComponent();

            // Настройка темы и цветовой схемы
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, // Основной цвет
                Primary.BlueGrey900, // Темный цвет
                Primary.BlueGrey500, // Светлый цвет
                Accent.LightBlue200, // Акцентный цвет
                TextShade.WHITE // Цвет текста
            );

            LoadProducts(); // Загрузка товаров при запуске формы
        }

        // Загрузка товаров
        private void LoadProducts()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Загрузка данных о товарах
                using (var cmd = new NpgsqlCommand("SELECT КодТовара, Название, Количество, Цена FROM Товары", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridProducts.DataSource = table;
                }
            }
        }

        // Обработчик события для кнопки "Добавить товар"
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts(); // Обновление списка товаров после добавления
            }
        }

        // Обработчик события для кнопки "Редактировать товар"
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProducts.SelectedRows[0];
                var productId = Convert.ToInt32(selectedRow.Cells["КодТовара"].Value);

                var editProductForm = new EditProductForm(productId);
                if (editProductForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts(); // Обновление списка товаров после редактирования
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик события для кнопки "Удалить товар"
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProducts.SelectedRows[0];
                var productId = Convert.ToInt32(selectedRow.Cells["КодТовара"].Value);

                var result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();

                        // Удаление товара
                        using (var cmd = new NpgsqlCommand("DELETE FROM Товары WHERE КодТовара = @КодТовара", conn))
                        {
                            cmd.Parameters.AddWithValue("@КодТовара", productId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadProducts(); // Обновление списка товаров после удаления
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик события для кнопки "Обновить"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts(); // Обновление списка товаров
        }
    }
}