using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace NekrylovDB2
{
    public partial class SuppliesForm : MaterialForm
    {
        private string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2";

        public SuppliesForm()
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

            LoadSupplies();
        }

        private void LoadSupplies()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT КодПоставки, КодТовара, Количество, Поставщик, ДатаПоставки FROM Поставки", conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dataGridSupplies.DataSource = table;
                }
            }
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            var addSupplyForm = new AddSupplyForm();
            if (addSupplyForm.ShowDialog() == DialogResult.OK)
            {
                LoadSupplies();
            }
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            if (dataGridSupplies.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridSupplies.SelectedRows[0];
                var supplyId = Convert.ToInt32(selectedRow.Cells["КодПоставки"].Value);

                var editSupplyForm = new EditSupplyForm(supplyId);
                if (editSupplyForm.ShowDialog() == DialogResult.OK)
                {
                    LoadSupplies();
                }
            }
            else
            {
                MessageBox.Show("Выберите поставку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            if (dataGridSupplies.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridSupplies.SelectedRows[0];
                var supplyId = Convert.ToInt32(selectedRow.Cells["КодПоставки"].Value);

                var result = MessageBox.Show("Вы уверены, что хотите удалить эту поставку?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();

                        using (var cmd = new NpgsqlCommand("DELETE FROM Поставки WHERE КодПоставки = @КодПоставки", conn))
                        {
                            cmd.Parameters.AddWithValue("@КодПоставки", supplyId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadSupplies();
                }
            }
            else
            {
                MessageBox.Show("Выберите поставку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSupplies();
        }
    }
}