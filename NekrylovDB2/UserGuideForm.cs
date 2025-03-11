using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NekrylovDB2
{
    public partial class UserGuideForm : MaterialForm
    {
        // Текущий текст руководства
        private string _guideText;

        public UserGuideForm()
        {
            InitializeComponent();

            // Настройка темы и цветовой схемы
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

            // Инициализация текста
            _guideText = @"
Руководство пользователя

1. Управление товарами:
   - Добавить товар: Позволяет добавить новый товар на склад.
   - Редактировать товар: Позволяет изменить информацию о товаре.
   - Удалить товар: Удаляет товар из системы.

2. Управление поставками:
   - Добавить поставку: Позволяет добавить новую поставку товара.
   - Редактировать поставку: Позволяет изменить информацию о поставке.
   - Удалить поставку: Удаляет поставку из системы.

3. Управление заказами:
   - Добавить заказ: Позволяет создать новый заказ.
   - Редактировать заказ: Позволяет изменить информацию о заказе.
   - Удалить заказ: Удаляет заказ из системы.

4. Генерация отчетов:
   - Отчет по остаткам: Показывает текущие остатки товаров на складе.
   - Статистика: Отображает статистику по поставкам и заказам.
   - Популярные товары: Показывает список самых популярных товаров.

5. Управление пользователями:
   - Добавить пользователя: Позволяет добавить нового пользователя.
   - Редактировать пользователя: Позволяет изменить данные пользователя.
   - Удалить пользователя: Удаляет пользователя из системы.

6. Настройки системы:
   - Настройка параметров системы.

7. Выход:
   - Завершает работу приложения.
";

            // Установка текста в lblGuide
            lblGuide.Text = _guideText;
        }

        // Обработчик события для кнопки "Редактировать"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Открытие формы редактирования
            var editForm = new EditGuideForm(_guideText);

            // Подписка на событие обновления текста
            editForm.GuideTextUpdated += (newText) =>
            {
                _guideText = newText;
                lblGuide.Text = _guideText;
            };

            editForm.ShowDialog();
        }

        // Обработчик события для кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}