namespace NekrylovDB2
{
    partial class StatisticsReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridStatistics;
        private MaterialSkin.Controls.MaterialButton btnExport;

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
            this.dataGridStatistics = new System.Windows.Forms.DataGridView();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();

            // dataGridStatistics
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Location = new System.Drawing.Point(50, 100);
            this.dataGridStatistics.Name = "dataGridStatistics";
            this.dataGridStatistics.Size = new System.Drawing.Size(700, 400);
            this.dataGridStatistics.TabIndex = 0;

            // btnExport
            this.btnExport.AutoSize = false;
            this.btnExport.Depth = 0;
            this.btnExport.DrawShadows = true;
            this.btnExport.HighEmphasis = true;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(50, 520);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 50);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Экспорт в CSV";
            this.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExport.UseAccentColor = false;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // StatisticsReportForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridStatistics);
            this.Name = "StatisticsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика по поставкам и заказам";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.ResumeLayout(false);
        }
    }
}