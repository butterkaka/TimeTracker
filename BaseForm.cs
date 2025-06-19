using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Models;

namespace TimeTracker
{
    internal class BaseForm : Form
    {
        protected Competition _competition;

        private bool _timerIsRunning;
        protected bool TimerIsRunning 
        {
            get => _timerIsRunning;
            set
            {
                if (_timerIsRunning != value)
                {
                    _timerIsRunning = value;
                    OnTimerRunningChanged(EventArgs.Empty);
                }
            }
        }

        public event EventHandler? TimerRunningChanged;

        protected virtual void OnTimerRunningChanged(EventArgs e)
        {
            TimerRunningChanged?.Invoke(this, e);
        }
    }
}
