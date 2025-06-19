namespace TimeTracker
{
    partial class SetTimerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hourNum = new NumericUpDown();
            minutesNum = new NumericUpDown();
            secNum = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)hourNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutesNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Timmar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 33);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 1;
            label2.Text = "Minuter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 33);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Sekunder";
            // 
            // hourNum
            // 
            hourNum.Location = new Point(23, 57);
            hourNum.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            hourNum.Name = "hourNum";
            hourNum.Size = new Size(51, 25);
            hourNum.TabIndex = 3;
            // 
            // minutesNum
            // 
            minutesNum.Location = new Point(80, 57);
            minutesNum.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutesNum.Name = "minutesNum";
            minutesNum.Size = new Size(51, 25);
            minutesNum.TabIndex = 4;
            // 
            // secNum
            // 
            secNum.Location = new Point(139, 57);
            secNum.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secNum.Name = "secNum";
            secNum.Size = new Size(50, 25);
            secNum.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(132, 105);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 6;
            button1.Text = "Spara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SetTimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 150);
            Controls.Add(button1);
            Controls.Add(secNum);
            Controls.Add(minutesNum);
            Controls.Add(hourNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ImeMode = ImeMode.Off;
            Name = "SetTimerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ställ timer";
            ((System.ComponentModel.ISupportInitialize)hourNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutesNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)secNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown hourNum;
        private NumericUpDown minutesNum;
        private NumericUpDown secNum;
        private Button button1;
    }
}