
namespace Warehouse
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelVendorCode = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelStockBalance = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxVendorCode = new System.Windows.Forms.TextBox();
            this.NumericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownStockBalance = new System.Windows.Forms.NumericUpDown();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonImageSelect = new System.Windows.Forms.Button();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownStockBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 12);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(94, 15);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Наименование:";
            // 
            // LabelVendorCode
            // 
            this.LabelVendorCode.AutoSize = true;
            this.LabelVendorCode.Location = new System.Drawing.Point(12, 41);
            this.LabelVendorCode.Name = "LabelVendorCode";
            this.LabelVendorCode.Size = new System.Drawing.Size(55, 15);
            this.LabelVendorCode.TabIndex = 1;
            this.LabelVendorCode.Text = "Артикул:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(12, 69);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(38, 15);
            this.LabelPrice.TabIndex = 2;
            this.LabelPrice.Text = "Цена:";
            // 
            // LabelStockBalance
            // 
            this.LabelStockBalance.AutoSize = true;
            this.LabelStockBalance.Location = new System.Drawing.Point(12, 98);
            this.LabelStockBalance.Name = "LabelStockBalance";
            this.LabelStockBalance.Size = new System.Drawing.Size(54, 15);
            this.LabelStockBalance.TabIndex = 3;
            this.LabelStockBalance.Text = "Остаток:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(12, 128);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(65, 15);
            this.LabelDescription.TabIndex = 4;
            this.LabelDescription.Text = "Описание:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 151);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(370, 221);
            this.TextBoxDescription.TabIndex = 4;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Location = new System.Drawing.Point(122, 9);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(140, 23);
            this.TextBoxName.TabIndex = 0;
            // 
            // TextBoxVendorCode
            // 
            this.TextBoxVendorCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVendorCode.Location = new System.Drawing.Point(122, 38);
            this.TextBoxVendorCode.Name = "TextBoxVendorCode";
            this.TextBoxVendorCode.Size = new System.Drawing.Size(140, 23);
            this.TextBoxVendorCode.TabIndex = 1;
            // 
            // NumericUpDownPrice
            // 
            this.NumericUpDownPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDownPrice.DecimalPlaces = 2;
            this.NumericUpDownPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownPrice.Location = new System.Drawing.Point(122, 67);
            this.NumericUpDownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDownPrice.Name = "NumericUpDownPrice";
            this.NumericUpDownPrice.Size = new System.Drawing.Size(140, 23);
            this.NumericUpDownPrice.TabIndex = 2;
            // 
            // NumericUpDownStockBalance
            // 
            this.NumericUpDownStockBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDownStockBalance.Location = new System.Drawing.Point(122, 96);
            this.NumericUpDownStockBalance.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumericUpDownStockBalance.Name = "NumericUpDownStockBalance";
            this.NumericUpDownStockBalance.Size = new System.Drawing.Size(140, 23);
            this.NumericUpDownStockBalance.TabIndex = 3;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(230, 378);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(68, 25);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Location = new System.Drawing.Point(304, 378);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(78, 25);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonImageSelect
            // 
            this.ButtonImageSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImageSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImageSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.ButtonImageSelect.Location = new System.Drawing.Point(355, 102);
            this.ButtonImageSelect.Name = "ButtonImageSelect";
            this.ButtonImageSelect.Size = new System.Drawing.Size(27, 17);
            this.ButtonImageSelect.TabIndex = 5;
            this.ButtonImageSelect.Text = "***";
            this.ButtonImageSelect.UseVisualStyleBackColor = true;
            this.ButtonImageSelect.Click += new System.EventHandler(this.ButtonImageSelect_Click);
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxImage.BackColor = System.Drawing.Color.White;
            this.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxImage.Location = new System.Drawing.Point(273, 9);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(109, 110);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxImage.TabIndex = 5;
            this.PictureBoxImage.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(394, 410);
            this.Controls.Add(this.ButtonImageSelect);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.NumericUpDownStockBalance);
            this.Controls.Add(this.NumericUpDownPrice);
            this.Controls.Add(this.TextBoxVendorCode);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelStockBalance);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelVendorCode);
            this.Controls.Add(this.LabelName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 300);
            this.Name = "FormProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownStockBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelVendorCode;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelStockBalance;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxVendorCode;
        private System.Windows.Forms.NumericUpDown NumericUpDownPrice;
        private System.Windows.Forms.NumericUpDown NumericUpDownStockBalance;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonImageSelect;
    }
}