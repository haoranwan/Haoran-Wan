namespace FraryPNumAirline
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            IstOutput = new ListBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(322, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Saleman";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(99, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "calculate Commission";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(299, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(465, 370);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // IstOutput
            // 
            IstOutput.FormattingEnabled = true;
            IstOutput.ItemHeight = 15;
            IstOutput.Location = new Point(86, 223);
            IstOutput.Name = "IstOutput";
            IstOutput.Size = new Size(561, 139);
            IstOutput.TabIndex = 6;
            IstOutput.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 93);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "amount sold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 149);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 8;
            label3.Text = "Commission rate:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 429);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(IstOutput);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Haoran  Wan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private ListBox IstOutput;
        private Label label4;
        private Label label3;
    }
}
