using System;
using System.Windows.Forms;

namespace WEPA
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            var apps = Apps.GetList(); // Retrieve app list.

            const string msg1 = "Would you like to remove ";
            const string msg2 = "? It can access/collect: ";
            var args = "";

            // Generate argument string for PowerShell.
            foreach (var str in apps)
            {
                var result = MessageBox.Show(msg1 + str.Split("`")[0] + msg2 + str.Split("`")[1], str.Split("`")[0],
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    args += "get-appxpackage *" + str.Split("`")[2] +
                            "* | remove-appxpackage;"; // Append a new argument to the args string.
                }
            }

            if (args == "") return;
            var ps = new System.Diagnostics.ProcessStartInfo // Create new process.
            {
                FileName =
                    @"C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe", // Point the process to PowerShell.
                Verb = "runas", // Invoke PowerShell as administrator.
                Arguments = @args // Pass in arguments (commands to remove selected applications).
            };
            System.Diagnostics.Process.Start(ps); // Execute the process.
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            /*
            throw new System.NotImplementedException();
            this.Hide();
            frmAdvanced frmAdvanced = new frmAdvanced();
            frmAdvanced.ShowDialog();
            this.Show();
            */
        }
    }
}