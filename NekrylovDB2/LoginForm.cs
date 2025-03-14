using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class LoginForm : MaterialForm
    {
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        // Свойство для проверки успешной авторизации
        public bool IsAuthenticated { get; private set; } = false;

        // Свойство для хранения роли пользователя
        public int UserRoleId { get; private set; } = -1;

        public LoginForm()
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT \"КодРоли\" FROM \"Пользователи\" WHERE \"Логин\" = @Логин AND \"Пароль\" = @Пароль", conn))
                    {
                        cmd.Parameters.AddWithValue("@Логин", login);
                        cmd.Parameters.AddWithValue("@Пароль", password);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Устанавливаем флаг успешной авторизации
                            IsAuthenticated = true;

                            // Сохраняем роль пользователя
                            UserRoleId = Convert.ToInt32(result);

                            // Закрываем форму авторизации
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработчик для кнопки "Отмена"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Закрытие формы авторизации
        }
    }
}