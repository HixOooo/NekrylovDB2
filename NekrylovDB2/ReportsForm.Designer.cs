namespace NekrylovDB2
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialButton btnGenerateExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerateExcel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnGenerateExcel
            // 
            this.btnGenerateExcel.AutoSize = false;
            this.btnGenerateExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateExcel.Depth = 0;
            this.btnGenerateExcel.HighEmphasis = true;
            this.btnGenerateExcel.Icon = null;
            this.btnGenerateExcel.Location = new System.Drawing.Point(37, 110);
            this.btnGenerateExcel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGenerateExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateExcel.Name = "btnGenerateExcel";
            this.btnGenerateExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateExcel.Size = new System.Drawing.Size(150, 41);
            this.btnGenerateExcel.TabIndex = 1;
            this.btnGenerateExcel.Text = "Создать Excel";
            this.btnGenerateExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateExcel.UseAccentColor = false;
            this.btnGenerateExcel.UseVisualStyleBackColor = true;
            this.btnGenerateExcel.Click += new System.EventHandler(this.btnGenerateExcel_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 203);
            this.Controls.Add(this.btnGenerateExcel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация отчетов";
            this.ResumeLayout(false);

        }
    }
}