namespace covid19Project
{
    partial class covidpatientNames
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
            idNumber = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            isActive = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "name";
            label1.AutoSize = true;
            label1.Location = new Point(89, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AccessibleName = "dob";
            label2.AutoSize = true;
            label2.Location = new Point(73, 120);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "dob";
            // 
            // label3
            // 
            label3.AccessibleName = "country";
            label3.AutoSize = true;
            label3.Location = new Point(66, 199);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "country";
            // 
            // idNumber
            // 
            idNumber.AutoSize = true;
            idNumber.ImageAlign = ContentAlignment.BottomLeft;
            idNumber.Location = new Point(73, 74);
            idNumber.Name = "idNumber";
            idNumber.Size = new Size(52, 25);
            idNumber.TabIndex = 3;
            idNumber.Text = "IdNo";
            // 
            // label5
            // 
            label5.AccessibleName = "gender";
            label5.AutoSize = true;
            label5.Location = new Point(66, 157);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 4;
            label5.Text = "gender";
            // 
            // button1
            // 
            button1.Location = new Point(107, 417);
            button1.Name = "button1";
            button1.Size = new Size(74, 37);
            button1.TabIndex = 6;
            button1.Text = "new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(262, 417);
            button2.Name = "button2";
            button2.Size = new Size(74, 37);
            button2.TabIndex = 7;
            button2.Text = "save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(493, 417);
            button4.Name = "button4";
            button4.Size = new Size(74, 37);
            button4.TabIndex = 9;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "name";
            textBox1.Location = new Point(151, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "Country";
            textBox2.Location = new Point(151, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "idnumber";
            textBox3.Location = new Point(151, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 31);
            textBox3.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 31);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "male", "female" });
            comboBox1.Location = new Point(151, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 33);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // isActive
            // 
            isActive.AccessibleName = "isActive";
            isActive.AutoSize = true;
            isActive.Location = new Point(151, 254);
            isActive.Name = "isActive";
            isActive.Size = new Size(98, 29);
            isActive.TabIndex = 16;
            isActive.Text = "isActive";
            isActive.UseVisualStyleBackColor = true;
            // 
            // covidpatientNames
            // 
            AccessibleName = "dob";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(isActive);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(idNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "covidpatientNames";
            Text = "CovidPatientNames";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label idNumber;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private CheckBox isActive;
    }
}
