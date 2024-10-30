namespace trees_and_roots
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
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 78);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 162);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 7;
            label1.Text = "     ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 109);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "Stan listy: {}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 81);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "Liczba: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 11;
            label5.Text = "Drzewo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 12;
            label3.Text = "Drzewa";
            // 
            // button1
            // 
            button1.Location = new Point(153, 18);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(234, 18);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 14;
            button2.Text = "RemoveFirst";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(339, 18);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 15;
            button3.Text = "RemoveLast";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button button1;
        private Button button3;
    }
}
