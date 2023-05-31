namespace WinFormApp
{
    partial class FrmStart
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
            components = new System.ComponentModel.Container();
            lblCount = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblName = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.Crimson;
            lblCount.Location = new Point(313, 63);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(164, 128);
            lblCount.TabIndex = 0;
            lblCount.Text = "10";
            lblCount.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(359, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(162, 268);
            lblName.Name = "lblName";
            lblName.Size = new Size(72, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Enter Name:";
            lblName.Click += label1_Click_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(258, 265);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 23);
            txtName.TabIndex = 3;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(button1);
            Controls.Add(lblCount);
            Name = "FrmStart";
            Text = "FrmStart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCount;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label lblName;
        private TextBox txtName;
    }
}