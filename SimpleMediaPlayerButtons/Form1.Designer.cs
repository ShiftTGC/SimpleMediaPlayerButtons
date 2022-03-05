
namespace SimpleMediaPlayerButtons
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
            this.TrackPrev = new System.Windows.Forms.Button();
            this.TrackPlayPause = new System.Windows.Forms.Button();
            this.TrackNext = new System.Windows.Forms.Button();
            this.TrackStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrackPrev
            // 
            this.TrackPrev.Location = new System.Drawing.Point(12, 12);
            this.TrackPrev.Name = "TrackPrev";
            this.TrackPrev.Size = new System.Drawing.Size(116, 79);
            this.TrackPrev.TabIndex = 0;
            this.TrackPrev.Text = "TrackPrev";
            this.TrackPrev.UseVisualStyleBackColor = true;
            this.TrackPrev.Click += new System.EventHandler(this.TrackPrev_Click);
            // 
            // TrackPlayPause
            // 
            this.TrackPlayPause.Location = new System.Drawing.Point(134, 12);
            this.TrackPlayPause.Name = "TrackPlayPause";
            this.TrackPlayPause.Size = new System.Drawing.Size(116, 79);
            this.TrackPlayPause.TabIndex = 1;
            this.TrackPlayPause.Text = "TrackPlayPause";
            this.TrackPlayPause.UseVisualStyleBackColor = true;
            this.TrackPlayPause.Click += new System.EventHandler(this.TrackPlayPause_Click);
            // 
            // TrackNext
            // 
            this.TrackNext.Location = new System.Drawing.Point(256, 12);
            this.TrackNext.Name = "TrackNext";
            this.TrackNext.Size = new System.Drawing.Size(116, 79);
            this.TrackNext.TabIndex = 2;
            this.TrackNext.Text = "TrackNext";
            this.TrackNext.UseVisualStyleBackColor = true;
            this.TrackNext.Click += new System.EventHandler(this.TrackNext_Click);
            // 
            // TrackStop
            // 
            this.TrackStop.Location = new System.Drawing.Point(134, 97);
            this.TrackStop.Name = "TrackStop";
            this.TrackStop.Size = new System.Drawing.Size(116, 79);
            this.TrackStop.TabIndex = 3;
            this.TrackStop.Text = "TrackStop";
            this.TrackStop.UseVisualStyleBackColor = true;
            this.TrackStop.Click += new System.EventHandler(this.TrackStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.TrackStop);
            this.Controls.Add(this.TrackNext);
            this.Controls.Add(this.TrackPlayPause);
            this.Controls.Add(this.TrackPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SimpleMediaPlayerButtons by ShiftTGC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrackPrev;
        private System.Windows.Forms.Button TrackPlayPause;
        private System.Windows.Forms.Button TrackNext;
        private System.Windows.Forms.Button TrackStop;
    }
}

