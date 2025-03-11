using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NekrylovDB2
{
    public partial class EditGuideForm : MaterialForm
    {
        // Событие для передачи отредактированного текста
        public event Action<string> GuideTextUpdated;

        public EditGuideForm(string currentText)
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

            // Установка текущего текста в текстовое поле
            txtGuide.Text = currentText;
        }

        // Обработчик события для кнопки "Сохранить"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Вызов события с новым текстом
            GuideTextUpdated?.Invoke(txtGuide.Text);

            // Закрытие формы
            this.Close();
        }

        // Обработчик события для кнопки "Отмена"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Закрытие формы без сохранения
            this.Close();
        }
    }
}