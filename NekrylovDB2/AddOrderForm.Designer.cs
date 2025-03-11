namespace NekrylovDB2
{
    partial class AddOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialTextBox txtProductId;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialTextBox txtStatus;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnCancel;

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
            this.txtProductId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtStatus = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();

            // txtProductId
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductId.Depth = 0;
            this.txtProductId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtProductId.Hint = "Код товара";
            this.txtProductId.Location = new System.Drawing.Point(50, 100);
            this.txtProductId.MaxLength = 50;
            this.txtProductId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductId.Multiline = false;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(300, 50);
            this.txtProductId.TabIndex = 0;
            this.txtProductId.Text = "";

            // txtQuantity
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQuantity.Hint = "Количество";
            this.txtQuantity.Location = new System.Drawing.Point(50, 170);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(300, 50);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "";

            // txtStatus
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Depth = 0;
            this.txtStatus.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtStatus.Hint = "Статус";
            this.txtStatus.Location = new System.Drawing.Point(50, 240);
            this.txtStatus.MaxLength = 100;
            this.txtStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(300, 50);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "";

            // btnAdd
            this.btnAdd.AutoSize = false;
            this.btnAdd.Depth = 0;
            this.btnAdd.DrawShadows = true;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(50, 310);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnCancel
            this.btnCancel.AutoSize = false;
            this.btnCancel.Depth = 0;
            this.btnCancel.DrawShadows = true;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(220, 310);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddOrderForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductId);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заказ";
            this.ResumeLayout(false);
        }
    }
}