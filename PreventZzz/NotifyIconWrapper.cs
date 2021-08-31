using System;
using System.ComponentModel;
using System.Windows;

namespace PreventZzz
{
    public partial class NotifyIconWrapper : Component
    {
        private static readonly string _mutexName = "PreventZzz";
        private static readonly System.Threading.Mutex mutex = new System.Threading.Mutex(false, _mutexName);
        private static bool _hasHandle = false;

        public NotifyIconWrapper()
        {
            _hasHandle = mutex.WaitOne(0, false);
            if (!_hasHandle)
            {
                MessageBox.Show("PreventZzz is already running.");
                System.Windows.Application.Current.Shutdown();
            }

            InitializeComponent();

            toolStripMenuItem_About.Click += toolStripMenuItem_About_Click;
            toolStripMenuItem_Quit.Click += toolStripMenuItem_Quit_Click;
            toolStripMenuItem_Monitor.Click += toolStripMenuItem_Monitor_Click;
            toolStripMenuItem_Sleep.Click += toolStripMenuItem_Sleep_Click;

            toolStripMenuItem_Sleep.Checked = Properties.Settings.Default.DoNotSleep;
            toolStripMenuItem_Monitor.Checked = Properties.Settings.Default.DoNotPowerOffMonitor;

            SetExecutionState(false);

        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            var wnd = new MainWindow();
            toolStripMenuItem_About.Enabled = false;
            wnd.ShowDialog();
            toolStripMenuItem_About.Enabled = true;
        }

        private void toolStripMenuItem_Quit_Click(object sender, EventArgs e)
        {
            SetExecutionState();
            System.Windows.Application.Current.Shutdown();
        }

        private void toolStripMenuItem_Monitor_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem_Monitor.Checked)
            {
                toolStripMenuItem_Sleep.Checked = false;
            }
            SetExecutionState();
        }

        private void toolStripMenuItem_Sleep_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem_Sleep.Checked)
            {
                toolStripMenuItem_Monitor.Checked = false;
            }
            SetExecutionState();
        }

        private void SetExecutionState(bool isSavePropertie = true)
        {
            Win32ApiExecutionState.Reset();

            if (toolStripMenuItem_Monitor.Checked)
            {
                Win32ApiExecutionState.PreventMonitorPowerOff();
            }
            else if (toolStripMenuItem_Sleep.Checked)
            {
                Win32ApiExecutionState.PreventSleep();
            }

            Properties.Settings.Default.DoNotSleep = toolStripMenuItem_Sleep.Checked;
            Properties.Settings.Default.DoNotPowerOffMonitor = toolStripMenuItem_Monitor.Checked;
            if (isSavePropertie)
            {
                Properties.Settings.Default.Save();
            }
        }
    }
}
