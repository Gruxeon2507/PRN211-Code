namespace WinForm_EntityFramework2
{
    partial class d
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
            dataGridView1 = new DataGridView();
            CustomerId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustomerId = new TextBox();
            txtBirthdate = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            chkMale = new CheckBox();
            chkFemale = new CheckBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnReset = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 0;
            // 
            // CustomerId
            // 
            CustomerId.AutoSize = true;
            CustomerId.Location = new Point(30, 40);
            CustomerId.Name = "CustomerId";
            CustomerId.Size = new Size(69, 15);
            CustomerId.TabIndex = 1;
            CustomerId.Text = "CustomerId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Birthdate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 40);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "CustomerName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 104);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 73);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Gender";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(122, 37);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(100, 23);
            txtCustomerId.TabIndex = 6;
            // 
            // txtBirthdate
            // 
            txtBirthdate.Location = new Point(122, 70);
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.Size = new Size(100, 23);
            txtBirthdate.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(122, 101);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(501, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(468, 74);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(52, 19);
            chkMale.TabIndex = 10;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(537, 73);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(64, 19);
            chkFemale.TabIndex = 11;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 226);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(222, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(315, 226);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(420, 226);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 16;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(511, 226);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 17;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(chkFemale);
            Controls.Add(chkMale);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtBirthdate);
            Controls.Add(txtCustomerId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CustomerId);
            Controls.Add(dataGridView1);
            Name = "d";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label CustomerId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCustomerId;
        private TextBox txtBirthdate;
        private TextBox txtAddress;
        private TextBox txtName;
        private CheckBox chkMale;
        private CheckBox chkFemale;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnReset;
        private Button btnExit;
    }
}