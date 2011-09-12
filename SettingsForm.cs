using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Caffeinated.Properties;

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

        private void StartupChkBox_CheckedChanged(object sender, EventArgs e) {
            var shell = new ReflectedShell();
            var shortcut = GetShortcutPath(shell);
            var executable = Assembly.GetExecutingAssembly()
                                     .GetName().CodeBase;
            if (StartupChkBox.Checked) {
                // create shortcut in startup items folder in start menu
                shell.CreateShortcut(shortcut, executable);
            }
            else {
                // remove shortcut if it exists
                File.Delete(shortcut);
            }
        }
    }
}
