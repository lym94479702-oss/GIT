namespace GIT
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
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label3 = new Label();
            listBox3 = new ListBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            listBox4 = new ListBox();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "选择串口";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(77, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(82, 21);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 2;
            label2.Text = "波特率";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(225, 9);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(60, 21);
            listBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(297, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "打开串口";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 355);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 440);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 102);
            textBox2.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(484, 11);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(254, 412);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(246, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(345, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 41);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 8;
            label3.Text = "显示模式";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 17;
            listBox3.Location = new Point(77, 40);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(82, 21);
            listBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 44);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 10;
            label4.Text = "帧间隔：";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(65, 23);
            textBox3.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(247, 440);
            button1.Name = "button1";
            button1.Size = new Size(85, 102);
            button1.TabIndex = 12;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 450);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 13;
            label5.Text = "数据格式：";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 17;
            listBox4.Location = new Point(417, 446);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(63, 21);
            listBox4.TabIndex = 14;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(347, 479);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 21);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "循环发送：";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(427, 477);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 552);
            Controls.Add(textBox4);
            Controls.Add(checkBox2);
            Controls.Add(listBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(listBox3);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private ListBox listBox3;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private ListBox listBox4;
        private CheckBox checkBox2;
        private TextBox textBox4;
    }
}
