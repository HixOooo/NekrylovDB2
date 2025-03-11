namespace NekrylovDB2
{
    partial class EditOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialTextBox txtProductId;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialTextBox txtStatus;
        private MaterialSkin.Controls.MaterialButton btnSave;
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
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
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

            // btnSave
            this.btnSave.AutoSize = false;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = true;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(50, 310);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

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

            // EditOrderForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductId);
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать заказ";
            this.ResumeLayout(false);
        }
    }
}