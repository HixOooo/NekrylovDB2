namespace NekrylovDB2
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialButton btnAddOrder;
        private MaterialSkin.Controls.MaterialButton btnEditOrder;
        private MaterialSkin.Controls.MaterialButton btnDeleteOrder;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.DataGridView dataGridOrders;

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
            this.btnAddOrder = new MaterialSkin.Controls.MaterialButton();
            this.btnEditOrder = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteOrder = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();

            // btnAddOrder
            this.btnAddOrder.AutoSize = false;
            this.btnAddOrder.Depth = 0;
            this.btnAddOrder.DrawShadows = true;
            this.btnAddOrder.HighEmphasis = true;
            this.btnAddOrder.Icon = null;
            this.btnAddOrder.Location = new System.Drawing.Point(50, 100);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(200, 50);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Добавить заказ";
            this.btnAddOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddOrder.UseAccentColor = false;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);

            // btnEditOrder
            this.btnEditOrder.AutoSize = false;
            this.btnEditOrder.Depth = 0;
            this.btnEditOrder.DrawShadows = true;
            this.btnEditOrder.HighEmphasis = true;
            this.btnEditOrder.Icon = null;
            this.btnEditOrder.Location = new System.Drawing.Point(50, 170);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(200, 50);
            this.btnEditOrder.TabIndex = 1;
            this.btnEditOrder.Text = "Редактировать заказ";
            this.btnEditOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditOrder.UseAccentColor = false;
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);

            // btnDeleteOrder
            this.btnDeleteOrder.AutoSize = false;
            this.btnDeleteOrder.Depth = 0;
            this.btnDeleteOrder.DrawShadows = true;
            this.btnDeleteOrder.HighEmphasis = true;
            this.btnDeleteOrder.Icon = null;
            this.btnDeleteOrder.Location = new System.Drawing.Point(50, 240);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Удалить заказ";
            this.btnDeleteOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteOrder.UseAccentColor = false;
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);

            // btnRefresh
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

            // dataGridOrders
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(300, 100);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(600, 400);
            this.dataGridOrders.TabIndex = 4;

            // OrdersForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление заказами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}