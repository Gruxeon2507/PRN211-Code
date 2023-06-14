namespace Progress_Test_02
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
            label1 = new Label();
            label2 = new Label();
            txtWord = new TextBox();
            txtMeaning = new TextBox();
            button1 = new Button();
            dgWord = new DataGridView();
            cbnType = new ComboBox();
            btnLoad = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgWord).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 40);
            label1.TabIndex = 0;
            label1.Text = "DICTIONARY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 68);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Word";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(161, 70);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(100, 23);
            txtWord.TabIndex = 4;
            // 
            // txtMeaning
            // 
            txtMeaning.Location = new Point(530, 75);
            txtMeaning.Name = "txtMeaning";
            txtMeaning.Size = new Size(100, 23);
            txtMeaning.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(433, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 7;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgWord
            // 
            dgWord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWord.Location = new Point(12, 253);
            dgWord.Name = "dgWord";
            dgWord.RowTemplate.Height = 25;
            dgWord.Size = new Size(767, 150);
            dgWord.TabIndex = 8;
            dgWord.CellClick += dgWord_CellClick;
            dgWord.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbnType
            // 
            cbnType.FormattingEnabled = true;
            cbnType.Location = new Point(161, 110);
            cbnType.Name = "cbnType";
            cbnType.Size = new Size(121, 23);
            cbnType.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 415);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "LOADDATA";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(433, 70);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 11;
            label5.Text = "Meaning";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, 111);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLoad);
            Controls.Add(cbnType);
            Controls.Add(dgWord);
            Controls.Add(button1);
            Controls.Add(txtMeaning);
            Controls.Add(txtWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgWord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWord;
        private TextBox txtMeaning;
        private Button button1;
        private DataGridView dgWord;
        private ComboBox cbnType;
        private Button btnLoad;
        public Label label5;
        public Label label6;
        public Label label2;
    }
}