namespace Q2
{
    partial class frmEmployee
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
            dtgData = new System.Windows.Forms.DataGridView();
            txtName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            rdoMale = new System.Windows.Forms.RadioButton();
            rdoFemale = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            numSalary = new System.Windows.Forms.NumericUpDown();
            txtPhone = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgData
            // 
            dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new System.Drawing.Point(12, 12);
            dtgData.Name = "dtgData";
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new System.Drawing.Size(543, 426);
            dtgData.TabIndex = 0;
            dtgData.CellContentClick += dtgData_CellContentClick;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(683, 79);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(169, 23);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(583, 82);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Employee Name";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new System.Drawing.Point(683, 127);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new System.Drawing.Size(51, 19);
            rdoMale.TabIndex = 5;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += rdoMale_CheckedChanged;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new System.Drawing.Point(789, 127);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new System.Drawing.Size(63, 19);
            rdoFemale.TabIndex = 6;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(583, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Salary";
            // 
            // numSalary
            // 
            numSalary.Location = new System.Drawing.Point(683, 180);
            numSalary.Name = "numSalary";
            numSalary.Size = new System.Drawing.Size(120, 23);
            numSalary.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(100, 224);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(169, 23);
            txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Location = new System.Drawing.Point(583, 242);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 15);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(583, 247);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 15);
            label5.TabIndex = 11;
            label5.Text = "Phone Number";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new System.Drawing.Point(583, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(291, 405);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(206, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(111, 355);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(13, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(100, 59);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(97, 23);
            txtId.TabIndex = 13;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(886, 449);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numSalary);
            Controls.Add(label3);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dtgData);
            Controls.Add(groupBox1);
            ForeColor = System.Drawing.Color.Black;
            Name = "frmEmployee";
            Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtId;
    }
}