using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using Npgsql;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NekrylovDB2
{
    public partial class ReportsForm : MaterialForm
    {
        public ReportsForm()
        {
            InitializeComponent();

            // Настройка темы и цветовой схемы
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,  // Основной цвет
                Primary.BlueGrey900,  // Темный цвет
                Primary.BlueGrey500,  // Светлый цвет
                Accent.LightBlue200,  // Акцентный цвет
                TextShade.WHITE      // Цвет текста
            );
        }

        // Обработчик события для кнопки "Создать PDF"
        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            // Здесь можно оставить пустым, если PDF больше не нужен
            MessageBox.Show("Функция создания PDF отключена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Обработчик события для кнопки "Создать Excel"
        private void btnGenerateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Установите контекст лицензии
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Для некоммерческого использования

                // Подключение к БД
                using (var conn = new NpgsqlConnection("Host=195.46.187.72;Username=postgres;Password=1337;Database=RuslanFinishDB2"))
                {
                    conn.Open();

                    // Загрузка данных из таблицы "Товары"
                    DataTable productsTable = LoadTableFromDatabase(conn, "SELECT Название, Количество, Цена FROM Товары");

                    // Загрузка данных из таблицы "Поставки"
                    DataTable suppliesTable = LoadTableFromDatabase(conn, "SELECT КодТовара, Количество, Поставщик, ДатаПоставки FROM Поставки");

                    // Загрузка данных из таблицы "Заказы"
                    DataTable ordersTable = LoadTableFromDatabase(conn, "SELECT КодТовара, Количество, Статус, ДатаЗаказа FROM Заказы");

                    // Сохранение в Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Отчет.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            // Лист "Товары"
                            if (productsTable.Rows.Count > 0)
                            {
                                ExcelWorksheet productsSheet = excelPackage.Workbook.Worksheets.Add("Товары");
                                AddTableToExcel(productsSheet, productsTable);
                            }

                            // Лист "Поставки"
                            if (suppliesTable.Rows.Count > 0)
                            {
                                ExcelWorksheet suppliesSheet = excelPackage.Workbook.Worksheets.Add("Поставки");
                                AddTableToExcel(suppliesSheet, suppliesTable);
                            }

                            // Лист "Заказы"
                            if (ordersTable.Rows.Count > 0)
                            {
                                ExcelWorksheet ordersSheet = excelPackage.Workbook.Worksheets.Add("Заказы");
                                AddTableToExcel(ordersSheet, ordersTable);
                            }

                            // Сохранение файла
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);
                        }

                        MessageBox.Show("Отчет успешно сохранен в Excel!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании Excel: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для загрузки данных из БД
        private DataTable LoadTableFromDatabase(NpgsqlConnection conn, string query)
        {
            DataTable table = new DataTable();
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            return table;
        }

        // Метод для добавления таблицы в Excel
        private void AddTableToExcel(ExcelWorksheet worksheet, DataTable dataTable)
        {
            // Заголовки столбцов
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
            }

            // Данные
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                }
            }

            // Авторазмер столбцов
            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
        }
    }
}