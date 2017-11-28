namespace RunescapeAndTheGreenKnight
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
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(533, 12);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(209, 193);
            this.Option1.TabIndex = 0;
            this.Option1.Text = "button1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(533, 207);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(209, 193);
            this.Option2.TabIndex = 1;
            this.Option2.Text = "button2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(13, 13);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(514, 387);
            this.video.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(729, 388);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "You are Sir Gawain of Arthur\'s Court. It is Christmas and you have an unexpected " +
    "adventure awaiting you. Let\'s see what it is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.video);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RuneScape And The Green Knight";
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
    }
}

