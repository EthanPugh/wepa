using System;
using System.Collections.Generic;
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
            List<String> apps = Apps.GetList(); // Retrieve app list.

            String msg1 = "Would you like to remove ";
            String msg2 = "? It can access/collect: ";
            String args = "";
            Boolean cancel = false;

            // Generate argument string for PowerShell.
            foreach (String str in apps)
            {
                DialogResult result = MessageBox.Show(msg1 + str.Split("`")[0] + msg2 + str.Split("`")[1], str.Split("`")[0], MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    args += "get-appxpackage *" + str.Split("`")[2] + "* | remove-appxpackage;";    // Append a new argument to the args string.
                }
                else if (result == DialogResult.Cancel)
                {
                    cancel = true;
                    break;
                }
            }

            if (args != "" && cancel == false)
            {
                var ps = new System.Diagnostics.ProcessStartInfo();                         // Create new process.
                ps.FileName = @"C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe"; // Point the process to PowerShell.
                ps.Verb = "runas";                                                          // Invoke PowerShell as administrator.
                ps.Arguments = @args;                                                       // Pass in arguments (commands to remove selected applications).
                System.Diagnostics.Process.Start(ps);                                       // Execute the process.
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
            this.Hide();
            frmAdvanced frmAdvanced = new frmAdvanced();
            frmAdvanced.ShowDialog();
            this.Show();
        }
    }
}