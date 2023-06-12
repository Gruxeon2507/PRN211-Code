namespace WinForm_ADO
{
    partial class frmCustomer
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
            dgCustomer = new DataGridView();
            label1 = new Label();
            txtID = new TextBox();
            txtDob = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            btnGender = new RadioButton();
            btnGender2 = new RadioButton();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(51, 288);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowTemplate.Height = 25;
            dgCustomer.Size = new Size(591, 150);
            dgCustomer.TabIndex = 0;
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 30);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(113, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(198, 23);
            txtID.TabIndex = 2;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(113, 84);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(198, 23);
            txtDob.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 87);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "BirthDate";
            // 
            // txtName
            // 
            txtName.Location = new Point(444, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 23);
            txtName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 30);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(113, 137);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(529, 23);
            txtAddress.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 140);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Address: ";
            // 
            // btnGender
            // 
            btnGender.AutoSize = true;
            btnGender.Location = new Point(444, 85);
            btnGender.Name = "btnGender";
            btnGender.Size = new Size(51, 19);
            btnGender.TabIndex = 11;
            btnGender.TabStop = true;
            btnGender.Text = "Male";
            btnGender.UseVisualStyleBackColor = true;
            // 
            // btnGender2
            // 
            btnGender2.AutoSize = true;
            btnGender2.Location = new Point(548, 84);
            btnGender2.Name = "btnGender2";
            btnGender2.Size = new Size(63, 19);
            btnGender2.TabIndex = 12;
            btnGender2.TabStop = true;
            btnGender2.Text = "Female";
            btnGender2.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(80, 210);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(201, 210);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(316, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(444, 210);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 16;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(567, 210);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 17;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnGender2);
            Controls.Add(btnGender);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtDob);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Name = "frmCustomer";
            Text = "Welcome Customer";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private Label label1;
        private TextBox txtID;
        private TextBox txtDob;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private RadioButton btnGender;
        private RadioButton btnGender2;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnExit;
    }
}