using System.ComponentModel;

namespace WEPA
{
    partial class FrmAdvanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdvanced));
            this.lstApps = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstApps
            // 
            this.lstApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstApps.ForeColor = System.Drawing.Color.Black;
            this.lstApps.FormattingEnabled = true;
            this.lstApps.HorizontalScrollbar = true;
            this.lstApps.ItemHeight = 19;
            this.lstApps.Location = new System.Drawing.Point(12, 46);
            this.lstApps.Name = "lstApps";
            this.lstApps.Size = new System.Drawing.Size(410, 306);
            this.lstApps.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(183, 12);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(239, 28);
            this.chkAll.TabIndex = 2;
            this.chkAll.Text = "Select All Applications";
            this.chkAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 358);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(410, 41);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Selected Applications";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FrmAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstApps);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEPA - Advanced";
            this.Load += new System.EventHandler(this.FrmAdvanced_Load);
            this.ResumeLayout(false);
        }
        
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.ListBox lstApps;
        private System.Windows.Forms.Button btnRemove;

        #endregion
    }
}