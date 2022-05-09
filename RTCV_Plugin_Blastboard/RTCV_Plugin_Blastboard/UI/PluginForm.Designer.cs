namespace BLASTBOARD.UI
{

    partial class PluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnOriginalSize = new System.Windows.Forms.Button();
            this.btnRefreshPlayer = new System.Windows.Forms.Button();
            this.cbBlastToCorruptCloudLive = new System.Windows.Forms.CheckBox();
            this.version = new System.Windows.Forms.Label();
            this.btnBroadcastManualBlast = new System.Windows.Forms.Button();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blastboard";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(304, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 21);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Tag = "color:dark2";
            this.btnRefresh.Text = "Load from Stockpile Manager";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnButtons.Controls.Add(this.btnOriginalSize);
            this.pnButtons.Location = new System.Drawing.Point(12, 58);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(679, 411);
            this.pnButtons.TabIndex = 8;
            this.pnButtons.Tag = "color:dark2";
            // 
            // btnOriginalSize
            // 
            this.btnOriginalSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOriginalSize.FlatAppearance.BorderSize = 0;
            this.btnOriginalSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginalSize.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnOriginalSize.ForeColor = System.Drawing.Color.White;
            this.btnOriginalSize.Location = new System.Drawing.Point(0, 0);
            this.btnOriginalSize.Name = "btnOriginalSize";
            this.btnOriginalSize.Size = new System.Drawing.Size(187, 43);
            this.btnOriginalSize.TabIndex = 9;
            this.btnOriginalSize.Tag = "color:dark2";
            this.btnOriginalSize.Text = "Sample Text";
            this.btnOriginalSize.UseVisualStyleBackColor = false;
            this.btnOriginalSize.Visible = false;
            this.btnOriginalSize.Click += new System.EventHandler(this.btnOriginalSize_Click);
            // 
            // btnRefreshPlayer
            // 
            this.btnRefreshPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRefreshPlayer.FlatAppearance.BorderSize = 0;
            this.btnRefreshPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPlayer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRefreshPlayer.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPlayer.Location = new System.Drawing.Point(304, 32);
            this.btnRefreshPlayer.Name = "btnRefreshPlayer";
            this.btnRefreshPlayer.Size = new System.Drawing.Size(207, 21);
            this.btnRefreshPlayer.TabIndex = 9;
            this.btnRefreshPlayer.Tag = "color:dark2";
            this.btnRefreshPlayer.Text = "Load from Stockpile Player";
            this.btnRefreshPlayer.UseVisualStyleBackColor = false;
            this.btnRefreshPlayer.Click += new System.EventHandler(this.btnRefreshPlayer_Click);
            // 
            // cbBlastToCorruptCloudLive
            // 
            this.cbBlastToCorruptCloudLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBlastToCorruptCloudLive.ForeColor = System.Drawing.Color.White;
            this.cbBlastToCorruptCloudLive.Location = new System.Drawing.Point(538, 36);
            this.cbBlastToCorruptCloudLive.Name = "cbBlastToCorruptCloudLive";
            this.cbBlastToCorruptCloudLive.Size = new System.Drawing.Size(153, 18);
            this.cbBlastToCorruptCloudLive.TabIndex = 10;
            this.cbBlastToCorruptCloudLive.Text = "Blast to CorruptCloud Live";
            this.cbBlastToCorruptCloudLive.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(120, 31);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(14, 13);
            this.version.TabIndex = 11;
            this.version.Text = "v";
            // 
            // btnBroadcastManualBlast
            // 
            this.btnBroadcastManualBlast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBroadcastManualBlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBroadcastManualBlast.FlatAppearance.BorderSize = 0;
            this.btnBroadcastManualBlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBroadcastManualBlast.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBroadcastManualBlast.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBroadcastManualBlast.Location = new System.Drawing.Point(530, 8);
            this.btnBroadcastManualBlast.Name = "btnBroadcastManualBlast";
            this.btnBroadcastManualBlast.Size = new System.Drawing.Size(161, 21);
            this.btnBroadcastManualBlast.TabIndex = 12;
            this.btnBroadcastManualBlast.Tag = "color:dark2";
            this.btnBroadcastManualBlast.Text = "Broadcast Manual Blast";
            this.btnBroadcastManualBlast.UseVisualStyleBackColor = false;
            this.btnBroadcastManualBlast.Click += new System.EventHandler(this.btnBroadcastManualBlast_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(703, 482);
            this.Controls.Add(this.btnBroadcastManualBlast);
            this.Controls.Add(this.cbBlastToCorruptCloudLive);
            this.Controls.Add(this.btnRefreshPlayer);
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(64, 64);
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.ResizeEnd += new System.EventHandler(this.PluginForm_ResizeEnd);
            this.pnButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Button btnOriginalSize;
        private System.Windows.Forms.Button btnRefreshPlayer;
        private System.Windows.Forms.CheckBox cbBlastToCorruptCloudLive;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button btnBroadcastManualBlast;
    }
}
