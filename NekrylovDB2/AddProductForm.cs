using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class AddProductForm : MaterialForm
    {
        // Строка подключения к базе данных
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public AddProductForm()
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
        }

        // Обработчик события для кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Добавление товара
                using (var cmd = new NpgsqlCommand("INSERT INTO Товары (Название, Количество, Цена, КодКатегории) VALUES (@Название, @Количество, @Цена, @КодКатегории)", conn))
                {
                    cmd.Parameters.AddWithValue("@Название", txtName.Text);
                    cmd.Parameters.AddWithValue("@Количество", Convert.ToInt32(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@Цена", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@КодКатегории", DBNull.Value); // Если КодКатегории может быть NULL
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
