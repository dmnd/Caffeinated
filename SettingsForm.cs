using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Caffeinated.Properties;
using Windows.ApplicationModel;

namespace Caffeinated {
    public partial class SettingsForm : BaseForm {
        BindingList<Duration> Durations;
        public SettingsForm() : base() {
            InitializeComponent();
            var durations = from i in Settings.Default.RealDurations
                            select new Duration { Minutes = i };
            this.Durations = new BindingList<Duration>(durations.ToList());
            var defaultItem = this.Durations.Where(
                d => d.Minutes == Settings.Default.DefaultDuration
            ).First();

            DefaultDurationBox.DataSource = this.Durations;
            DefaultDurationBox.DisplayMember = "Description";
            DefaultDurationBox.ValueMember = "Minutes";
            DefaultDurationBox.SelectedItem = defaultItem;

            var shortcut = GetShortcutPath();
            StartupChkBox.Checked = File.Exists(shortcut);
        }

        private void okBtn_Click(object sender, EventArgs e) {
            Settings.Default.Save();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DefaultDurationBox_SelectedIndexChanged(
            object sender,
            EventArgs e
        ) {
            var item = DefaultDurationBox.SelectedItem as Duration;
            if (item != null) {
                Settings.Default.DefaultDuration = item.Minutes;
            }
        }

        static string GetShortcutPath(ReflectedShell shell = null) {
            if (shell == null) {
                shell = new ReflectedShell();
            }
            var startup = shell.GetSpecialFolder("Startup");
            return Path.Combine(startup, "Caffeinated.lnk");
        }

        private async void LaunchWithWindowsLogin(object sender, EventArgs e)
        {
            StartupTask startupTask = await StartupTask.GetAsync("Caffeinated");
            Debug.WriteLine("Startup is " + startupTask.State.ToString());

            switch (startupTask.State)
            {
                case StartupTaskState.Disabled:
                    // Task is disabled but can be enabled.
                    StartupTaskState newState = await startupTask.RequestEnableAsync();
                    Debug.WriteLine("Request to enable startup, result = {0}", newState);
                    break;
                case StartupTaskState.DisabledByUser:
                    // Task is disabled and user must enable it manually.
                    Debug.WriteLine("Startup is diabled by user.");
                    break;
                case StartupTaskState.Enabled:
                    Debug.WriteLine("Startup is enabled.");
                    break;
            }
        }

        private  void StartupChkBox_CheckedChanged(object sender, EventArgs e) {
            //var shell = new ReflectedShell();
            //var shortcut = GetShortcutPath(shell);
            //var executable = Assembly.GetExecutingAssembly()
            //                         .GetName().CodeBase;
            //if (StartupChkBox.Checked) {
            //    // create shortcut in startup items folder in start menu
            //    shell.CreateShortcut(shortcut, executable);
            //}
            //else {
            //    // remove shortcut if it exists
            //    File.Delete(shortcut);
            //}

            
        }
    }
}
