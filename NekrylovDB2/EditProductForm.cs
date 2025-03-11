using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class EditProductForm : MaterialForm
    {
        // Строка подключения к базе данных
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        private int productId;

        public EditProductForm(int productId)
        {
            InitializeComponent();

            this.productId = productId;

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

            LoadProductData(); // Загрузка данных товара при запуске формы
        }

        // Загрузка данных товара
        private void LoadProductData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Загрузка данных о товаре
                using (var cmd = new NpgsqlCommand("SELECT Название, Количество, Цена FROM Товары WHERE КодТовара = @КодТовара", conn))
                {
                    cmd.Parameters.AddWithValue("@КодТовара", productId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Название"].ToString();
                            txtQuantity.Text = reader["Количество"].ToString();
                            txtPrice.Text = reader["Цена"].ToString();
                        }
                    }
                }
            }
        }

        // Обработчик события для кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Обновление товара
                using (var cmd = new NpgsqlCommand("UPDATE Товары SET Название = @Название, Количество = @Количество, Цена = @Цена WHERE КодТовара = @КодТовара", conn))
                {
                    cmd.Parameters.AddWithValue("@Название", txtName.Text);
                    cmd.Parameters.AddWithValue("@Количество", Convert.ToInt32(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@Цена", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@КодТовара", productId);
                    cmd.ExecuteNonQuery();
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // Обработчик события для кнопки "Отмена"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}