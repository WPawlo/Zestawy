namespace SortingApp
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
            buttonBubbleSort = new Button();
            textBoxInput = new TextBox();
            listBoxResults = new ListBox();
            buttonQuickSort = new Button();
            buttonMergeSort = new Button();
            buttonInsertionSort = new Button();
            buttonCountingSort = new Button();
            buttonSelectionSort = new Button();
            SuspendLayout();
            // 
            // buttonBubbleSort
            // 
            buttonBubbleSort.Location = new Point(10, 34);
            buttonBubbleSort.Margin = new Padding(3, 2, 3, 2);
            buttonBubbleSort.Name = "buttonBubbleSort";
            buttonBubbleSort.Size = new Size(82, 22);
            buttonBubbleSort.TabIndex = 0;
            buttonBubbleSort.Text = "BubbleSort";
            buttonBubbleSort.UseVisualStyleBackColor = true;
            buttonBubbleSort.Click += buttonBubbleSort_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(10, 9);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(110, 23);
            textBoxInput.TabIndex = 1;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(10, 60);
            listBoxResults.Margin = new Padding(3, 2, 3, 2);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(132, 139);
            listBoxResults.TabIndex = 2;
            // 
            // buttonQuickSort
            // 
            buttonQuickSort.Location = new Point(98, 34);
            buttonQuickSort.Margin = new Padding(3, 2, 3, 2);
            buttonQuickSort.Name = "buttonQuickSort";
            buttonQuickSort.Size = new Size(82, 22);
            buttonQuickSort.TabIndex = 3;
            buttonQuickSort.Text = "QuickSort";
            buttonQuickSort.UseVisualStyleBackColor = true;
            buttonQuickSort.Click += buttonQuickSort_Click;
            // 
            // buttonMergeSort
            // 
            buttonMergeSort.Location = new Point(186, 34);
            buttonMergeSort.Margin = new Padding(3, 2, 3, 2);
            buttonMergeSort.Name = "buttonMergeSort";
            buttonMergeSort.Size = new Size(82, 22);
            buttonMergeSort.TabIndex = 4;
            buttonMergeSort.Text = "MergeSort";
            buttonMergeSort.UseVisualStyleBackColor = true;
            buttonMergeSort.Click += buttonMergeSort_Click;
            // 
            // buttonInsertionSort
            // 
            buttonInsertionSort.Location = new Point(273, 34);
            buttonInsertionSort.Margin = new Padding(3, 2, 3, 2);
            buttonInsertionSort.Name = "buttonInsertionSort";
            buttonInsertionSort.Size = new Size(82, 22);
            buttonInsertionSort.TabIndex = 5;
            buttonInsertionSort.Text = "Insertion";
            buttonInsertionSort.UseVisualStyleBackColor = true;
            buttonInsertionSort.Click += buttonInsertionSort_Click;
            // 
            // buttonCountingSort
            // 
            buttonCountingSort.Location = new Point(360, 34);
            buttonCountingSort.Margin = new Padding(3, 2, 3, 2);
            buttonCountingSort.Name = "buttonCountingSort";
            buttonCountingSort.Size = new Size(82, 22);
            buttonCountingSort.TabIndex = 6;
            buttonCountingSort.Text = "Counting";
            buttonCountingSort.UseVisualStyleBackColor = true;
            buttonCountingSort.Click += buttonCountingSort_Click;
            // 
            // buttonSelectionSort
            // 
            buttonSelectionSort.Location = new Point(448, 34);
            buttonSelectionSort.Margin = new Padding(3, 2, 3, 2);
            buttonSelectionSort.Name = "buttonSelectionSort";
            buttonSelectionSort.Size = new Size(82, 22);
            buttonSelectionSort.TabIndex = 7;
            buttonSelectionSort.Text = "Selection";
            buttonSelectionSort.UseVisualStyleBackColor = true;
            buttonSelectionSort.Click += buttonSelectionSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonSelectionSort);
            Controls.Add(buttonCountingSort);
            Controls.Add(buttonInsertionSort);
            Controls.Add(buttonMergeSort);
            Controls.Add(buttonQuickSort);
            Controls.Add(listBoxResults);
            Controls.Add(textBoxInput);
            Controls.Add(buttonBubbleSort);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBubbleSort;
        private TextBox textBoxInput;
        private ListBox listBoxResults;
        private Button buttonQuickSort;
        private Button buttonMergeSort;
        private Button buttonInsertionSort;
        private Button buttonCountingSort;
        private Button buttonSelectionSort;
    }
}
