namespace organizarArchivos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.lblOrganize = new System.Windows.Forms.Label();
            this.lblMediaPlayer = new System.Windows.Forms.Label();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(12, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(881, 501);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(78, 551);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 41);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(184, 551);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(100, 41);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnOrganize
            // 
            this.btnOrganize.Location = new System.Drawing.Point(683, 551);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(100, 41);
            this.btnOrganize.TabIndex = 3;
            this.btnOrganize.Text = "Organize";
            this.btnOrganize.UseVisualStyleBackColor = true;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // lblOrganize
            // 
            this.lblOrganize.AutoSize = true;
            this.lblOrganize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganize.Location = new System.Drawing.Point(648, 523);
            this.lblOrganize.Name = "lblOrganize";
            this.lblOrganize.Size = new System.Drawing.Size(158, 25);
            this.lblOrganize.TabIndex = 7;
            this.lblOrganize.Text = "Organize Folder:";
            // 
            // lblMediaPlayer
            // 
            this.lblMediaPlayer.AutoSize = true;
            this.lblMediaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaPlayer.Location = new System.Drawing.Point(114, 523);
            this.lblMediaPlayer.Name = "lblMediaPlayer";
            this.lblMediaPlayer.Size = new System.Drawing.Size(132, 25);
            this.lblMediaPlayer.TabIndex = 8;
            this.lblMediaPlayer.Text = "Media Player:";
            // 
            // txtLyrics
            // 
            this.txtLyrics.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyrics.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLyrics.Location = new System.Drawing.Point(23, 22);
            this.txtLyrics.Multiline = true;
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.ReadOnly = true;
            this.txtLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyrics.Size = new System.Drawing.Size(858, 478);
            this.txtLyrics.TabIndex = 9;
            this.txtLyrics.Text = resources.GetString("txtLyrics.Text");
            this.txtLyrics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLyrics.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 618);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.lblMediaPlayer);
            this.Controls.Add(this.lblOrganize);
            this.Controls.Add(this.btnOrganize);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.vlcControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Label lblOrganize;
        private System.Windows.Forms.Label lblMediaPlayer;
        private System.Windows.Forms.TextBox txtLyrics;
    }
}

