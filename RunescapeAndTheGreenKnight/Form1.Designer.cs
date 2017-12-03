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
            this.Option2 = new System.Windows.Forms.Button();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
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
            this.video.Dock = System.Windows.Forms.DockStyle.Left;
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(0, 0);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(527, 412);
            this.video.TabIndex = 2;
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
            // Option1
            // 
            this.Option1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(542, 3);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(209, 193);
            this.Option1.TabIndex = 0;
            this.Option1.Text = "button1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(161, 89);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(213, 233);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.0356F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.9644F));
            this.tableLayoutPanel1.Controls.Add(this.start, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Option1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 412);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RuneScape And The Green Knight";
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Option2;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

