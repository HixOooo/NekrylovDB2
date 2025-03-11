using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class EditSupplyForm : MaterialForm
    {
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";
        private int supplyId;

        public EditSupplyForm(int supplyId)
        {
            InitializeComponent();

            this.supplyId = supplyId;

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

            LoadSupplyData();
        }

        private void LoadSupplyData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT КодТовара, Количество, Поставщик FROM Поставки WHERE КодПоставки = @КодПоставки", conn))
                {
                    cmd.Parameters.AddWithValue("@КодПоставки", supplyId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProductId.Text = reader["КодТовара"].ToString();
                            txtQuantity.Text = reader["Количество"].ToString();
                            txtSupplier.Text = reader["Поставщик"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtSupplier.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("UPDATE Поставки SET КодТовара = @КодТовара, Количество = @Количество, Поставщик = @Поставщик WHERE КодПоставки = @КодПоставки", conn))
                {
                    cmd.Parameters.AddWithValue("@КодТовара", Convert.ToInt32(txtProductId.Text));
                    cmd.Parameters.AddWithValue("@Количество", Convert.ToInt32(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@Поставщик", txtSupplier.Text);
                    cmd.Parameters.AddWithValue("@КодПоставки", supplyId);
                    cmd.ExecuteNonQuery();
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}