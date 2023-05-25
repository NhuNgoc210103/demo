namespace WinFormsApp1
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
         
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 1;
            label1.Text = "Nhập và họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 113);
            label2.Name = "label2";
            label2.Size = new Size(145, 41);
            label2.TabIndex = 2;
            label2.Text = "ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(268, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(500, 47);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 198);
            label3.Name = "label3";
            label3.Size = new Size(123, 41);
            label3.TabIndex = 4;
            label3.Text = "trình độ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 266);
            label4.Name = "label4";
            label4.Size = new Size(127, 41);
            label4.TabIndex = 5;
            label4.Text = "giới tính";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(268, 266);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 45);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(436, 262);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 45);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(268, 338);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(153, 45);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Đồng ý";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 342);
            label5.Name = "label5";
            label5.Size = new Size(184, 41);
            label5.TabIndex = 10;
            label5.Text = "Đăng ký học";
            
            // 
            // button1
            // 
            button1.Location = new Point(522, 380);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 11;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private Label label5;
        private Button button1;
    }
}