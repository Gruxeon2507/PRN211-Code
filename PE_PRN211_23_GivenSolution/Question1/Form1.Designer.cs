namespace Question1
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
            txtId = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnTrue = new RadioButton();
            dataGrid = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtName = new TextBox();
            numPrice = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnFalse = new RadioButton();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(101, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "ProductId";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(155, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "AddToList";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnTrue
            // 
            btnTrue.AutoSize = true;
            btnTrue.Location = new Point(101, 219);
            btnTrue.Name = "btnTrue";
            btnTrue.Size = new Size(47, 19);
            btnTrue.TabIndex = 3;
            btnTrue.TabStop = true;
            btnTrue.Text = "True";
            btnTrue.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(377, 12);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(411, 352);
            dataGrid.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFalse);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numPrice);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnTrue);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 352);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ProductInfo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "ProductName";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 23);
            txtName.TabIndex = 5;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(101, 155);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(173, 23);
            numPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 157);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "IsActive";
            // 
            // btnFalse
            // 
            btnFalse.AutoSize = true;
            btnFalse.Location = new Point(101, 254);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(51, 19);
            btnFalse.TabIndex = 9;
            btnFalse.TabStop = true;
            btnFalse.Text = "False";
            btnFalse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(562, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "SaveToFile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(dataGrid);
            Name = "Form1";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Button btnAdd;
        private RadioButton btnTrue;
        private DataGridView dataGrid;
        private GroupBox groupBox1;
        private Label label3;
        private NumericUpDown numPrice;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private RadioButton btnFalse;
        private Button btnSave;
    }
}