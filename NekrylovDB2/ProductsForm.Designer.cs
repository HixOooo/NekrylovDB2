namespace NekrylovDB2
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialButton btnAddProduct;
        private MaterialSkin.Controls.MaterialButton btnEditProduct;
        private MaterialSkin.Controls.MaterialButton btnDeleteProduct;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.DataGridView dataGridProducts;

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
            this.btnAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnEditProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = false;
            this.btnAddProduct.Depth = 0;
            this.btnAddProduct.DrawShadows = true;
            this.btnAddProduct.HighEmphasis = true;
            this.btnAddProduct.Icon = null;
            this.btnAddProduct.Location = new System.Drawing.Point(50, 100);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 50);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProduct.UseAccentColor = false;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            // 
            // btnEditProduct
            // 
            this.btnEditProduct.AutoSize = false;
            this.btnEditProduct.Depth = 0;
            this.btnEditProduct.DrawShadows = true;
            this.btnEditProduct.HighEmphasis = true;
            this.btnEditProduct.Icon = null;
            this.btnEditProduct.Location = new System.Drawing.Point(50, 170);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(200, 50);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "Редактировать товар";
            this.btnEditProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditProduct.UseAccentColor = false;
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);

            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.AutoSize = false;
            this.btnDeleteProduct.Depth = 0;
            this.btnDeleteProduct.DrawShadows = true;
            this.btnDeleteProduct.HighEmphasis = true;
            this.btnDeleteProduct.Icon = null;
            this.btnDeleteProduct.Location = new System.Drawing.Point(50, 240);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteProduct.UseAccentColor = false;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);

            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.DrawShadows = true;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(50, 310);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 50);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(300, 100);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(600, 400);
            this.dataGridProducts.TabIndex = 4;

            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление товарами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}