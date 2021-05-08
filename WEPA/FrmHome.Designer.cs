namespace WEPA
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblEasy = new System.Windows.Forms.Label();
            this.lblEasyDesc = new System.Windows.Forms.Label();
            this.lblAdvancedDesc = new System.Windows.Forms.Label();
            this.lblAdvanced = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 79);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WEPA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(274, 24);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(49, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 72);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(410, 38);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Windows Easy Privacy Application";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEasy.Location = new System.Drawing.Point(125, 123);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(197, 51);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "Easy Privacy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lblEasy
            // 
            this.lblEasy.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEasy.Location = new System.Drawing.Point(12, 177);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(410, 24);
            this.lblEasy.TabIndex = 4;
            this.lblEasy.Text = "Recommended for Novice Users";
            this.lblEasy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEasyDesc
            // 
            this.lblEasyDesc.Location = new System.Drawing.Point(12, 201);
            this.lblEasyDesc.Name = "lblEasyDesc";
            this.lblEasyDesc.Size = new System.Drawing.Size(410, 62);
            this.lblEasyDesc.TabIndex = 5;
            this.lblEasyDesc.Text = "This mode will ask, for each Windows application, whether you would like to remov" + "e the specific application.\r\n";
            this.lblEasyDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdvancedDesc
            // 
            this.lblAdvancedDesc.Location = new System.Drawing.Point(12, 358);
            this.lblAdvancedDesc.Name = "lblAdvancedDesc";
            this.lblAdvancedDesc.Size = new System.Drawing.Size(410, 44);
            this.lblAdvancedDesc.TabIndex = 8;
            this.lblAdvancedDesc.Text = "Allows direct removal of specific Windows applications without warnings.";
            this.lblAdvancedDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdvanced.Location = new System.Drawing.Point(12, 334);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(410, 24);
            this.lblAdvanced.TabIndex = 7;
            this.lblAdvanced.Text = "Recommended for Expert Users";
            this.lblAdvanced.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAdvanced.Location = new System.Drawing.Point(125, 294);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(197, 37);
            this.btnAdvanced.TabIndex = 6;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblAdvancedDesc);
            this.Controls.Add(this.lblAdvanced);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.lblEasyDesc);
            this.Controls.Add(this.lblEasy);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEPA";
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }
        
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDesc;

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label lblEasyDesc;

        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Label lblAdvanced;
        private System.Windows.Forms.Label lblAdvancedDesc;
        
        #endregion
    }
}