namespace WinForm_EnityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgProduct = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtImage = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnExit = new Button();
            cbnCategory = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(12, 288);
            dgProduct.Name = "dgProduct";
            dgProduct.RowTemplate.Height = 25;
            dgProduct.Size = new Size(776, 150);
            dgProduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(203, 23);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(467, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 23);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(82, 71);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(203, 23);
            txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 74);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(467, 74);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(203, 23);
            txtStock.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 77);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(82, 129);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(203, 23);
            txtImage.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 132);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Image";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 132);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(161, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(290, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(544, 232);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 16;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(677, 232);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 17;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // cbnCategory
            // 
            cbnCategory.FormattingEnabled = true;
            cbnCategory.Location = new Point(467, 132);
            cbnCategory.Name = "cbnCategory";
            cbnCategory.Size = new Size(203, 23);
            cbnCategory.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(414, 232);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(cbnCategory);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtImage);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgProduct);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProduct;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtImage;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnExit;
        private ComboBox cbnCategory;
        private Button btnSearch;
    }
}