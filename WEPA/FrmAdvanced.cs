using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

/*
 * Functionality for the advanced settings page. Allows direct removal
 * of specific applications in the list.
 * 
 * Author: Ethan Pugh
 */
namespace WEPA
{
    public partial class FrmAdvanced : Form
    {
        public FrmAdvanced()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Update listbox based on state of 'select all' checkbox.
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < lstApps.Items.Count; i++) lstApps.SetSelected(i, chkAll.Checked);
        }

        // Remove applications selected in the listbox.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var args = "";

            for (var i = lstApps.Items.Count - 1; i >= 0; i--)
                if (lstApps.GetSelected(i))
                    args += "get-appxpackage *" + lstApps.Items[i].ToString()?.Split("`").Last() +
                            "* | remove-appxpackage;"; // Append a new argument to the args string.

            if (args != "")
            {
                if (MessageBox.Show(@"Are you sure you want to remove the selected applications?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;
                var ps = new ProcessStartInfo // Create new process.
                {
                    FileName =
                        @"C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe", // Point the process to PowerShell.
                    Verb = "runas", // Invoke PowerShell as administrator.
                    Arguments = args // Pass in arguments (commands to remove selected applications).
                };
                Process.Start(ps); // Execute the process.
            }
            else
            {
                MessageBox.Show(@"You have not selected any applications.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Update form with the application data.
        private void FrmAdvanced_Load(object sender, EventArgs e)
        {
            // Add list of applications to the list box.
            var apps = Apps.GetList();

            foreach (var str in apps) lstApps.Items.Add(str);
        }
    }
}