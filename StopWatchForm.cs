using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class StopWatchForm : Form
    {
        private const float MinTimerFontSize = 24F;
        private const float MaxTimerFontSize = 220F;

        public StopWatchForm()
        {
            InitializeComponent();
            Resize += StopWatchForm_Resize;
            UpdateTimerFontSize();

            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized; // or Manual + custom size
        }

        public void UpdateDisplay(string text)
        {
            timerText.Text = text;
            UpdateTimerFontSize();
        }

        private void StopWatchForm_Resize(object? sender, EventArgs e)
        {
            UpdateTimerFontSize();
        }

        private void UpdateTimerFontSize()
        {
            if (timerText.ClientSize.Width <= 0 || timerText.ClientSize.Height <= 0)
            {
                return;
            }

            var text = string.IsNullOrWhiteSpace(timerText.Text) ? "00:00:00.00" : timerText.Text;
            var targetSize = timerText.ClientSize - new Size(20, 20);

            if (targetSize.Width <= 0 || targetSize.Height <= 0)
            {
                return;
            }

            var low = MinTimerFontSize;
            var high = MaxTimerFontSize;

            while (high - low > 0.5F)
            {
                var mid = (low + high) / 2F;
                using var testFont = new Font(timerText.Font.FontFamily, mid, timerText.Font.Style, GraphicsUnit.Point);
                var measured = TextRenderer.MeasureText(text, testFont, targetSize, TextFormatFlags.NoPadding | TextFormatFlags.SingleLine);

                if (measured.Width <= targetSize.Width && measured.Height <= targetSize.Height)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            }

            if (Math.Abs(timerText.Font.Size - low) > 0.5F)
            {
                timerText.Font = new Font(timerText.Font.FontFamily, low, timerText.Font.Style, GraphicsUnit.Point);
            }
        }
    }
}
