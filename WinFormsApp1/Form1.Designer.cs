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
            resultLabel = new Label();
            checkButton = new Button();
            inputTextBox = new TextBox();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(163, 78);
            resultLabel.MaximumSize = new Size(100, 100);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 0;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(150, 205);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 38);
            checkButton.TabIndex = 1;
            checkButton.Text = "Певевірити";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(88, 148);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(219, 23);
            inputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 280);
            Controls.Add(inputTextBox);
            Controls.Add(checkButton);
            Controls.Add(resultLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private Button checkButton;
        private TextBox inputTextBox;
    }
}
