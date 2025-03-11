namespace NekrylovDB2
{
    partial class SuppliesForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialButton btnAddSupply;
        private MaterialSkin.Controls.MaterialButton btnEditSupply;
        private MaterialSkin.Controls.MaterialButton btnDeleteSupply;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.DataGridView dataGridSupplies;

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
            this.btnAddSupply = new MaterialSkin.Controls.MaterialButton();
            this.btnEditSupply = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteSupply = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.dataGridSupplies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplies)).BeginInit();
            this.SuspendLayout();

            // btnAddSupply
            this.btnAddSupply.AutoSize = false;
            this.btnAddSupply.Depth = 0;
            this.btnAddSupply.DrawShadows = true;
            this.btnAddSupply.HighEmphasis = true;
            this.btnAddSupply.Icon = null;
            this.btnAddSupply.Location = new System.Drawing.Point(50, 100);
            this.btnAddSupply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddSupply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(200, 50);
            this.btnAddSupply.TabIndex = 0;
            this.btnAddSupply.Text = "Добавить поставку";
            this.btnAddSupply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddSupply.UseAccentColor = false;
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);

            // btnEditSupply
            this.btnEditSupply.AutoSize = false;
            this.btnEditSupply.Depth = 0;
            this.btnEditSupply.DrawShadows = true;
            this.btnEditSupply.HighEmphasis = true;
            this.btnEditSupply.Icon = null;
            this.btnEditSupply.Location = new System.Drawing.Point(50, 170);
            this.btnEditSupply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditSupply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditSupply.Name = "btnEditSupply";
            this.btnEditSupply.Size = new System.Drawing.Size(200, 50);
            this.btnEditSupply.TabIndex = 1;
            this.btnEditSupply.Text = "Редактировать поставку";
            this.btnEditSupply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditSupply.UseAccentColor = false;
            this.btnEditSupply.UseVisualStyleBackColor = true;
            this.btnEditSupply.Click += new System.EventHandler(this.btnEditSupply_Click);

            // btnDeleteSupply
            this.btnDeleteSupply.AutoSize = false;
            this.btnDeleteSupply.Depth = 0;
            this.btnDeleteSupply.DrawShadows = true;
            this.btnDeleteSupply.HighEmphasis = true;
            this.btnDeleteSupply.Icon = null;
            this.btnDeleteSupply.Location = new System.Drawing.Point(50, 240);
            this.btnDeleteSupply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteSupply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteSupply.Name = "btnDeleteSupply";
            this.btnDeleteSupply.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteSupply.TabIndex = 2;
            this.btnDeleteSupply.Text = "Удалить поставку";
            this.btnDeleteSupply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteSupply.UseAccentColor = false;
            this.btnDeleteSupply.UseVisualStyleBackColor = true;
            this.btnDeleteSupply.Click += new System.EventHandler(this.btnDeleteSupply_Click);

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

            // dataGridSupplies
            this.dataGridSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSupplies.Location = new System.Drawing.Point(300, 100);
            this.dataGridSupplies.Name = "dataGridSupplies";
            this.dataGridSupplies.Size = new System.Drawing.Size(600, 400);
            this.dataGridSupplies.TabIndex = 4;

            // SuppliesForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dataGridSupplies);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteSupply);
            this.Controls.Add(this.btnEditSupply);
            this.Controls.Add(this.btnAddSupply);
            this.Name = "SuppliesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление поставками";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplies)).EndInit();
            this.ResumeLayout(false);
        }
    }
}