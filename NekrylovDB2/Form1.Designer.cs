namespace NekrylovDB2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialButton btnProducts;
        private MaterialSkin.Controls.MaterialButton btnSupplies;
        private MaterialSkin.Controls.MaterialButton btnOrders;
        private MaterialSkin.Controls.MaterialButton btnReports;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnRefreshRecentData;
        private System.Windows.Forms.DataGridView dataGridRecentProducts;
        private System.Windows.Forms.DataGridView dataGridRecentSupplies;
        private System.Windows.Forms.DataGridView dataGridRecentOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

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
            this.btnProducts = new MaterialSkin.Controls.MaterialButton();
            this.btnSupplies = new MaterialSkin.Controls.MaterialButton();
            this.btnOrders = new MaterialSkin.Controls.MaterialButton();
            this.btnReports = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnRefreshRecentData = new MaterialSkin.Controls.MaterialButton();
            this.dataGridRecentProducts = new System.Windows.Forms.DataGridView();
            this.dataGridRecentSupplies = new System.Windows.Forms.DataGridView();
            this.dataGridRecentOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentSupplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSize = false;
            this.btnProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProducts.Depth = 0;
            this.btnProducts.HighEmphasis = true;
            this.btnProducts.Icon = null;
            this.btnProducts.Location = new System.Drawing.Point(38, 81);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProducts.Size = new System.Drawing.Size(112, 41);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Товары";
            this.btnProducts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProducts.UseAccentColor = false;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSupplies
            // 
            this.btnSupplies.AutoSize = false;
            this.btnSupplies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupplies.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSupplies.Depth = 0;
            this.btnSupplies.HighEmphasis = true;
            this.btnSupplies.Icon = null;
            this.btnSupplies.Location = new System.Drawing.Point(38, 138);
            this.btnSupplies.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSupplies.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSupplies.Size = new System.Drawing.Size(112, 41);
            this.btnSupplies.TabIndex = 1;
            this.btnSupplies.Text = "Поставки";
            this.btnSupplies.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSupplies.UseAccentColor = false;
            this.btnSupplies.UseVisualStyleBackColor = true;
            this.btnSupplies.Click += new System.EventHandler(this.btnSupplies_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.AutoSize = false;
            this.btnOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOrders.Depth = 0;
            this.btnOrders.HighEmphasis = true;
            this.btnOrders.Icon = null;
            this.btnOrders.Location = new System.Drawing.Point(38, 195);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOrders.Size = new System.Drawing.Size(112, 41);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOrders.UseAccentColor = false;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = false;
            this.btnReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReports.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReports.Depth = 0;
            this.btnReports.HighEmphasis = true;
            this.btnReports.Icon = null;
            this.btnReports.Location = new System.Drawing.Point(38, 252);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReports.Name = "btnReports";
            this.btnReports.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReports.Size = new System.Drawing.Size(112, 41);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Отчёты";
            this.btnReports.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReports.UseAccentColor = false;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(38, 530);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(112, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefreshRecentData
            // 
            this.btnRefreshRecentData.AutoSize = false;
            this.btnRefreshRecentData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefreshRecentData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefreshRecentData.Depth = 0;
            this.btnRefreshRecentData.HighEmphasis = true;
            this.btnRefreshRecentData.Icon = null;
            this.btnRefreshRecentData.Location = new System.Drawing.Point(38, 479);
            this.btnRefreshRecentData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRefreshRecentData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefreshRecentData.Name = "btnRefreshRecentData";
            this.btnRefreshRecentData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefreshRecentData.Size = new System.Drawing.Size(112, 41);
            this.btnRefreshRecentData.TabIndex = 7;
            this.btnRefreshRecentData.Text = "Обновить данные";
            this.btnRefreshRecentData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefreshRecentData.UseAccentColor = false;
            this.btnRefreshRecentData.UseVisualStyleBackColor = true;
            this.btnRefreshRecentData.Click += new System.EventHandler(this.btnRefreshRecentData_Click);
            // 
            // dataGridRecentProducts
            // 
            this.dataGridRecentProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecentProducts.Location = new System.Drawing.Point(180, 97);
            this.dataGridRecentProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridRecentProducts.Name = "dataGridRecentProducts";
            this.dataGridRecentProducts.Size = new System.Drawing.Size(331, 468);
            this.dataGridRecentProducts.TabIndex = 8;
            // 
            // dataGridRecentSupplies
            // 
            this.dataGridRecentSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecentSupplies.Location = new System.Drawing.Point(537, 97);
            this.dataGridRecentSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridRecentSupplies.Name = "dataGridRecentSupplies";
            this.dataGridRecentSupplies.Size = new System.Drawing.Size(417, 468);
            this.dataGridRecentSupplies.TabIndex = 9;
            // 
            // dataGridRecentOrders
            // 
            this.dataGridRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecentOrders.Location = new System.Drawing.Point(976, 97);
            this.dataGridRecentOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridRecentOrders.Name = "dataGridRecentOrders";
            this.dataGridRecentOrders.Size = new System.Drawing.Size(403, 468);
            this.dataGridRecentOrders.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(233, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Последние продукты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(639, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Последние поставки";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(1075, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Последние заказы";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRecentOrders);
            this.Controls.Add(this.dataGridRecentSupplies);
            this.Controls.Add(this.dataGridRecentProducts);
            this.Controls.Add(this.btnRefreshRecentData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnSupplies);
            this.Controls.Add(this.btnProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentSupplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}