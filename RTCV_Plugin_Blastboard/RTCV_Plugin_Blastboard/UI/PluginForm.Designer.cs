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
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blastboard";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(435, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(212, 37);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh from Stockpile Manager";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnButtons.Controls.Add(this.btnOriginalSize);
            this.pnButtons.Location = new System.Drawing.Point(12, 58);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(637, 411);
            this.pnButtons.TabIndex = 8;
            this.pnButtons.Tag = "color:dark2";
            // 
            // btnOriginalSize
            // 
            this.btnOriginalSize.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOriginalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOriginalSize.Location = new System.Drawing.Point(0, 0);
            this.btnOriginalSize.Name = "btnOriginalSize";
            this.btnOriginalSize.Size = new System.Drawing.Size(210, 62);
            this.btnOriginalSize.TabIndex = 9;
            this.btnOriginalSize.Text = "Sample Text";
            this.btnOriginalSize.UseVisualStyleBackColor = false;
            this.btnOriginalSize.Click += new System.EventHandler(this.btnOriginalSize_Click);
            // 
            // btnRefreshPlayer
            // 
            this.btnRefreshPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPlayer.Location = new System.Drawing.Point(225, 12);
            this.btnRefreshPlayer.Name = "btnRefreshPlayer";
            this.btnRefreshPlayer.Size = new System.Drawing.Size(199, 37);
            this.btnRefreshPlayer.TabIndex = 9;
            this.btnRefreshPlayer.Text = "Refresh from Stockpile Player";
            this.btnRefreshPlayer.UseVisualStyleBackColor = true;
            this.btnRefreshPlayer.Click += new System.EventHandler(this.btnRefreshPlayer_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(661, 482);
            this.Controls.Add(this.btnRefreshPlayer);
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}
