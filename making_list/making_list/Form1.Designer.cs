namespace making_list
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
            przycisk1 = new Button();
            label1 = new Label();
            przycisk2 = new Button();
            przycisk3 = new Button();
            przycisk4 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 109);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // przycisk1
            // 
            przycisk1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            przycisk1.ForeColor = SystemColors.ControlText;
            przycisk1.Location = new Point(563, 50);
            przycisk1.Margin = new Padding(3, 2, 3, 2);
            przycisk1.Name = "przycisk1";
            przycisk1.Size = new Size(105, 22);
            przycisk1.TabIndex = 1;
            przycisk1.Text = "ADDFIRST";
            przycisk1.UseVisualStyleBackColor = true;
            przycisk1.Click += przycisk1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(203, 163);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Lista: {}";
            // 
            // przycisk2
            // 
            przycisk2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            przycisk2.ForeColor = SystemColors.ControlText;
            przycisk2.Location = new Point(563, 111);
            przycisk2.Margin = new Padding(3, 2, 3, 2);
            przycisk2.Name = "przycisk2";
            przycisk2.Size = new Size(105, 22);
            przycisk2.TabIndex = 3;
            przycisk2.Text = "ADDLAST";
            przycisk2.UseVisualStyleBackColor = true;
            przycisk2.Click += przycisk2_Click;
            // 
            // przycisk3
            // 
            przycisk3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            przycisk3.ForeColor = SystemColors.ControlText;
            przycisk3.Location = new Point(563, 191);
            przycisk3.Margin = new Padding(3, 2, 3, 2);
            przycisk3.Name = "przycisk3";
            przycisk3.Size = new Size(105, 22);
            przycisk3.TabIndex = 4;
            przycisk3.Text = "REMOVEFIRST";
            przycisk3.UseVisualStyleBackColor = true;
            przycisk3.Click += przycisk3_Click;
            // 
            // przycisk4
            // 
            przycisk4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            przycisk4.ForeColor = SystemColors.ControlText;
            przycisk4.Location = new Point(563, 268);
            przycisk4.Margin = new Padding(3, 2, 3, 2);
            przycisk4.Name = "przycisk4";
            przycisk4.Size = new Size(105, 22);
            przycisk4.TabIndex = 5;
            przycisk4.Text = "REMOVELAST";
            przycisk4.UseVisualStyleBackColor = true;
            przycisk4.Click += przycisk4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(203, 115);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 6;
            label2.Text = "Liczba:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(254, 9);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 7;
            label3.Text = "TWORZENIE LISTY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(715, 333);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(przycisk4);
            Controls.Add(przycisk3);
            Controls.Add(przycisk2);
            Controls.Add(label1);
            Controls.Add(przycisk1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button przycisk1;
        private Button przycisk2;
        private Button przycisk3;
        private Button przycisk4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
