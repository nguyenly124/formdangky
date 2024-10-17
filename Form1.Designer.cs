namespace Font_dang_ky
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
            label3 = new Label();
            Email = new TextBox();
            Pass = new TextBox();
            button_dangky = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 48);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 158);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // Email
            // 
            Email.Location = new Point(231, 91);
            Email.Name = "Email";
            Email.Size = new Size(317, 27);
            Email.TabIndex = 3;
            Email.TextChanged += textBox1_TextChanged;
            // 
            // Pass
            // 
            Pass.Location = new Point(233, 151);
            Pass.Name = "Pass";
            Pass.Size = new Size(315, 27);
            Pass.TabIndex = 4;
            Pass.UseSystemPasswordChar = true;
            // 
            // button_dangky
            // 
            button_dangky.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dangky.Location = new Point(275, 235);
            button_dangky.Name = "button_dangky";
            button_dangky.Size = new Size(94, 29);
            button_dangky.TabIndex = 5;
            button_dangky.Text = "Đăng ký ";
            button_dangky.UseVisualStyleBackColor = true;
            button_dangky.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 351);
            Controls.Add(button_dangky);
            Controls.Add(Pass);
            Controls.Add(Email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Email;
        private TextBox Pass;
        private Button button_dangky;
    }
}
