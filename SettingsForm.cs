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
            ).FirstOrDefault();

            DefaultDurationBox.DataSource = this.Durations;
            DefaultDurationBox.DisplayMember = "Description";
            DefaultDurationBox.ValueMember = "Minutes";
            DefaultDurationBox.SelectedItem = defaultItem;

            MenuItem deleteMI = new MenuItem("Delete Duration");
            deleteMI.Click += DeleteMI_Click;
            ContextMenu durationCM = new ContextMenu();
            durationCM.MenuItems.Add(deleteMI);
            DefaultDurationBox.ContextMenu = durationCM;

            setStartupCheckBox();
            setRadioButtons();
        }

        private void setRadioButtons() {
            switch (Settings.Default.Icon)
            {
                case "Mug":
                    mugRDBTN.Checked = true;
                    break;
                case "Eye-ZZZ":
                    eyeZZZRDBTN.Checked = true;
                    break;
                default:
                    defaultRDBTN.Checked = true;
                    break;
            }
        }

        private void DeleteMI_Click(object sender, EventArgs e)
        {
            Duration durationToDelete = DefaultDurationBox.SelectedItem as Duration;

            DialogResult result = MessageBox.Show(
                    $"Delete {durationToDelete.Description}?",
                    "Caffeinated",
                    MessageBoxButtons.YesNo
                );

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    Durations.Remove(durationToDelete);
                    Settings.Default.RealDurations.Remove(durationToDelete.Minutes);
                    Settings.Default.RealDurations = Settings.Default.RealDurations;
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private async void setStartupCheckBox() {
            StartupTask startupTask = await StartupTask.GetAsync("StartCaffeinated");
            Debug.WriteLine("Startup is " + startupTask.State.ToString());

            switch (startupTask.State)
            {
                case StartupTaskState.Disabled:
                    // Task is disabled but can be enabled.
                    StartupChkBox.Checked = false;
                    break;
                case StartupTaskState.DisabledByUser:
                    // Task is disabled and user must enable it manually.
                    StartupChkBox.Checked = false;
                    StartupChkBox.Enabled = false;

                    StartupChkBox.Text += "\nDisabled in Task Manager";
                    break;
                case StartupTaskState.Enabled:
                    StartupChkBox.Checked = true;
                    break;
            }
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

        private async void StartupChkBox_CheckedChanged(object sender, EventArgs e) {
            StartupTask startupTask = await StartupTask.GetAsync("StartCaffeinated");

            switch (StartupChkBox.Checked)
            {
                case true:
                    StartupTaskState newState = await startupTask.RequestEnableAsync();
                    Debug.WriteLine("Request to enable startup, result = {0}", newState);
                    break;
                case false:
                    startupTask.Disable();
                    Debug.WriteLine("Disabled startup task");
                    break;
                default:
                    break;
            }
        }

        private void addCustomDurationBTN_Click(object sender, EventArgs e) {
            int newDuration = 0;
            int.TryParse(CustomDurationTXBX.Text, out newDuration);

            if ( newDuration < 0)
            {
                CustomDurationTXBX.Text = "";
                MessageBox.Show(
                    "Enter a positive number.",
                    "Caffeinated",
                    MessageBoxButtons.OK
                );
                return;
            }

            if (Settings.Default.RealDurations.Contains(newDuration))
            {
                CustomDurationTXBX.Text = "";
                MessageBox.Show(
                    $"{newDuration} is already a duration.",
                    "Caffeinated",
                    MessageBoxButtons.OK
                );
                return;
            }

            Duration newCustomDuration = new Duration
            {
                Minutes = newDuration
            };

            Durations.Add(newCustomDuration);
            var sortedDurations = Durations.OrderByDescending(i => i).ToList();
            Durations.Clear();
            foreach (var item in sortedDurations)
            {
                Durations.Add(item);
            }
            Settings.Default.RealDurations.Add(newDuration); 
            Settings.Default.Durations += $",{newDuration}";

            CustomDurationTXBX.Text = "";            
        }

        private void defaultRDBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.Icon = "Default";
        }

        private void eyeZZZRDBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.Icon = "Eye-ZZZ";
        }

        private void mugRDBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.Icon = "Mug";
        }
    }
}
