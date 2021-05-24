
namespace bd
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUniqueNumber = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxFeatureCode = new System.Windows.Forms.TextBox();
            this.Insert2 = new System.Windows.Forms.Button();
            this.Update2 = new System.Windows.Forms.Button();
            this.Delete2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Уник.Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1077, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1146, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1057, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Код характеристики";
            // 
            // textBoxUniqueNumber
            // 
            this.textBoxUniqueNumber.Location = new System.Drawing.Point(1205, 28);
            this.textBoxUniqueNumber.Name = "textBoxUniqueNumber";
            this.textBoxUniqueNumber.Size = new System.Drawing.Size(174, 22);
            this.textBoxUniqueNumber.TabIndex = 5;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(1205, 67);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(174, 22);
            this.textBoxProductName.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(1205, 119);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(174, 22);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxFeatureCode
            // 
            this.textBoxFeatureCode.Location = new System.Drawing.Point(1206, 186);
            this.textBoxFeatureCode.Name = "textBoxFeatureCode";
            this.textBoxFeatureCode.Size = new System.Drawing.Size(173, 22);
            this.textBoxFeatureCode.TabIndex = 8;
            // 
            // Insert2
            // 
            this.Insert2.Location = new System.Drawing.Point(1076, 245);
            this.Insert2.Name = "Insert2";
            this.Insert2.Size = new System.Drawing.Size(91, 39);
            this.Insert2.TabIndex = 9;
            this.Insert2.Text = "Добавить";
            this.Insert2.UseVisualStyleBackColor = true;
            this.Insert2.Click += new System.EventHandler(this.Insert2_Click);
            // 
            // Update2
            // 
            this.Update2.Location = new System.Drawing.Point(1173, 245);
            this.Update2.Name = "Update2";
            this.Update2.Size = new System.Drawing.Size(103, 39);
            this.Update2.TabIndex = 10;
            this.Update2.Text = "Обновить";
            this.Update2.UseVisualStyleBackColor = true;
            this.Update2.Click += new System.EventHandler(this.Update2_Click);
            // 
            // Delete2
            // 
            this.Delete2.Location = new System.Drawing.Point(1282, 245);
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(97, 39);
            this.Delete2.TabIndex = 11;
            this.Delete2.Text = "Удалить";
            this.Delete2.UseVisualStyleBackColor = true;
            this.Delete2.Click += new System.EventHandler(this.Delete2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1173, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "характеристика товара на складе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete2);
            this.Controls.Add(this.Update2);
            this.Controls.Add(this.Insert2);
            this.Controls.Add(this.textBoxFeatureCode);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxUniqueNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUniqueNumber;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxFeatureCode;
        private System.Windows.Forms.Button Insert2;
        private System.Windows.Forms.Button Update2;
        private System.Windows.Forms.Button Delete2;
        private System.Windows.Forms.Button button1;
    }
}