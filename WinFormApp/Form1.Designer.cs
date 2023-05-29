namespace WinFormApp
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
            groupBox1 = new GroupBox();
            numMark = new NumericUpDown();
            cboSubject = new ComboBox();
            txtNane = new TextBox();
            txtCode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lstStudent = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numMark);
            groupBox1.Controls.Add(cboSubject);
            groupBox1.Controls.Add(txtNane);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.FromArgb(255, 128, 128);
            groupBox1.Location = new Point(49, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 398);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numMark
            // 
            numMark.ForeColor = Color.FromArgb(255, 128, 128);
            numMark.Location = new Point(41, 243);
            numMark.Name = "numMark";
            numMark.Size = new Size(437, 23);
            numMark.TabIndex = 9;
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Items.AddRange(new object[] { "Math", "English", "Physics" });
            cboSubject.Location = new Point(41, 175);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(437, 23);
            cboSubject.TabIndex = 8;
            // 
            // txtNane
            // 
            txtNane.Location = new Point(41, 109);
            txtNane.Name = "txtNane";
            txtNane.Size = new Size(437, 23);
            txtNane.TabIndex = 7;
            txtNane.Enter += txtNane_Enter;
            txtNane.Leave += txtNane_Leave;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(41, 42);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(437, 23);
            txtCode.TabIndex = 4;
            txtCode.Enter += txtCode_Enter;
            txtCode.Leave += txtCode_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 220);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "Mark:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 152);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 0;
            label2.Text = "Student Code:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(lstStudent);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 128);
            groupBox2.Location = new Point(661, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 398);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // lstStudent
            // 
            lstStudent.FormattingEnabled = true;
            lstStudent.ItemHeight = 15;
            lstStudent.Location = new Point(17, 22);
            lstStudent.Name = "lstStudent";
            lstStudent.Size = new Size(377, 349);
            lstStudent.TabIndex = 0;
            lstStudent.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ROG Fonts", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(414, 53);
            label1.Name = "label1";
            label1.Size = new Size(332, 25);
            label1.TabIndex = 2;
            label1.Text = "STUDENT MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(563, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = ">>";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(563, 245);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "<<";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(563, 311);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(563, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button4_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(563, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1113, 591);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Student Management";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown numMark;
        private ComboBox cboSubject;
        private TextBox txtNane;
        private TextBox txtCode;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnLoad;
        private Button btnSave;
        private Button btnExit;
        private ListBox lstStudent;
    }
}