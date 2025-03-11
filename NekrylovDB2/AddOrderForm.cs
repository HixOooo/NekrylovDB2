using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class AddOrderForm : MaterialForm
    {
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public AddOrderForm()
        {
            InitializeComponent();

            // Настройка MaterialSkinManager
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
        }

        // Обработчик события для кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Получаем КодСтатуса
                    int кодСтатуса = GetStatusCode(txtStatus.Text); // Используем функцию GetStatusCode

                    using (var cmd = new NpgsqlCommand("INSERT INTO Заказы (КодТовара, Количество, Статус, ДатаЗаказа, КодСтатуса) VALUES (@КодТовара, @Количество, @Статус, @ДатаЗаказа, @КодСтатуса)", conn))
                    {
                        cmd.Parameters.AddWithValue("@КодТовара", Convert.ToInt32(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@Количество", Convert.ToInt32(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@Статус", txtStatus.Text);
                        cmd.Parameters.AddWithValue("@ДатаЗаказа", DateTime.Now);
                        cmd.Parameters.AddWithValue("@КодСтатуса", кодСтатуса); // Добавлено значение для КодСтатуса
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Заказ успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show($"Ошибка при добавлении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события для кнопки "Отмена"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Закрываем форму без сохранения
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Метод для получения КодСтатуса по названию статуса
        private int GetStatusCode(string statusName)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT КодСтатуса FROM Статусы WHERE Название = @Название", conn))
                {
                    cmd.Parameters.AddWithValue("@Название", statusName);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1; // Возвращаем код статуса или значение по умолчанию
                }
            }
        }
    }
}