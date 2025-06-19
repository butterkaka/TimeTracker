namespace TimeTracker
{
    partial class StopWatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatchForm));
            timerText = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timerText
            // 
            timerText.Dock = DockStyle.Fill;
            timerText.Font = new Font("Arial", 120F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerText.ForeColor = SystemColors.ButtonHighlight;
            timerText.Location = new Point(0, 0);
            timerText.Name = "timerText";
            timerText.Size = new Size(825, 358);
            timerText.TabIndex = 0;
            timerText.Text = "00:00:00";
            timerText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(timerText);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 358);
            panel1.TabIndex = 1;
            // 
            // StopWatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(825, 358);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StopWatchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Timer";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label timerText;
        private Panel panel1;
    }
}