namespace Multimedia
{
    partial class Mediaplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mediaplayer));
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(1, 1);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(210, 211);
            this.wmpPlayer.TabIndex = 0;
            // 
            // Mediaplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 212);
            this.Controls.Add(this.wmpPlayer);
            this.Name = "Mediaplayer";
            this.Text = "Mediaplayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mediaplayer_Closed);
            this.Load += new System.EventHandler(this.Mediaplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
    }
}