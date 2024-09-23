namespace Практическая_работа_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxMaterialName = new System.Windows.Forms.TextBox();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.textBoxNomenclatureNumber = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxReserveNorm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(271, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(75, 42);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(165, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaterialName
            // 
            this.textBoxMaterialName.Location = new System.Drawing.Point(105, 97);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterialName.TabIndex = 2;
            this.textBoxMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSort
            // 
            this.textBoxSort.Location = new System.Drawing.Point(105, 135);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(100, 20);
            this.textBoxSort.TabIndex = 3;
            this.textBoxSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProfile
            // 
            this.textBoxProfile.Location = new System.Drawing.Point(105, 170);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfile.TabIndex = 4;
            this.textBoxProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(105, 209);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 5;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitOfMeasurement
            // 
            this.textBoxUnitOfMeasurement.Location = new System.Drawing.Point(105, 253);
            this.textBoxUnitOfMeasurement.Name = "textBoxUnitOfMeasurement";
            this.textBoxUnitOfMeasurement.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitOfMeasurement.TabIndex = 6;
            this.textBoxUnitOfMeasurement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNomenclatureNumber
            // 
            this.textBoxNomenclatureNumber.Location = new System.Drawing.Point(105, 292);
            this.textBoxNomenclatureNumber.Name = "textBoxNomenclatureNumber";
            this.textBoxNomenclatureNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomenclatureNumber.TabIndex = 7;
            this.textBoxNomenclatureNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(105, 333);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxReserveNorm
            // 
            this.textBoxReserveNorm.Location = new System.Drawing.Point(105, 377);
            this.textBoxReserveNorm.Name = "textBoxReserveNorm";
            this.textBoxReserveNorm.Size = new System.Drawing.Size(100, 20);
            this.textBoxReserveNorm.TabIndex = 9;
            this.textBoxReserveNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxReserveNorm);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNomenclatureNumber);
            this.Controls.Add(this.textBoxUnitOfMeasurement);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxProfile);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.textBoxMaterialName);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxMaterialName;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxUnitOfMeasurement;
        private System.Windows.Forms.TextBox textBoxNomenclatureNumber;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxReserveNorm;
    }
}

