namespace Visio_Multi_Page_Layer_Selector
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbDonate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(523, 273);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Multi Page Layer Selector";
            // 
            // lbVersion
            // 
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Location = new System.Drawing.Point(83, 42);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbVersion.Size = new System.Drawing.Size(185, 16);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "lbVersion";
            // 
            // lbDonate
            // 
            this.lbDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDonate.Image = global::Visio_Multi_Page_Layer_Selector.Properties.Resources.img_paypal_donate;
            this.lbDonate.Location = new System.Drawing.Point(12, 76);
            this.lbDonate.Name = "lbDonate";
            this.lbDonate.Size = new System.Drawing.Size(523, 72);
            this.lbDonate.TabIndex = 3;
            this.lbDonate.Click += new System.EventHandler(this.lbDonate_Click);
            // 
            // label4
            // 
            this.label4.Image = global::Visio_Multi_Page_Layer_Selector.Properties.Resources.img_mpls_64;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 64);
            this.label4.TabIndex = 4;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(83, 58);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.linkGitHub.Size = new System.Drawing.Size(293, 13);
            this.linkGitHub.TabIndex = 5;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "https://github.com/Scrounger/visio-multi-page-layer-selector";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 435);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDonate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbDonate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkGitHub;
    }
}