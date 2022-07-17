namespace Doquanload
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.mp3 = new System.Windows.Forms.RadioButton();
            this.mp4 = new System.Windows.Forms.RadioButton();
            this.download = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Format";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(138, 31);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(385, 20);
            this.url.TabIndex = 2;
            // 
            // mp3
            // 
            this.mp3.AutoSize = true;
            this.mp3.Checked = true;
            this.mp3.Location = new System.Drawing.Point(138, 66);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(47, 17);
            this.mp3.TabIndex = 3;
            this.mp3.TabStop = true;
            this.mp3.Text = "MP3";
            this.mp3.UseVisualStyleBackColor = true;
            this.mp3.TextChanged += new System.EventHandler(this.mp3_TextChanged);
            // 
            // mp4
            // 
            this.mp4.AutoSize = true;
            this.mp4.Location = new System.Drawing.Point(258, 66);
            this.mp4.Name = "mp4";
            this.mp4.Size = new System.Drawing.Size(47, 17);
            this.mp4.TabIndex = 4;
            this.mp4.Text = "MP4";
            this.mp4.UseVisualStyleBackColor = true;
            this.mp4.TextChanged += new System.EventHandler(this.mp4_TextChanged);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(205, 135);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 5;
            this.download.Text = "İndir";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(96, 191);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(361, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Location = new System.Drawing.Point(182, 342);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(34, 13);
            this.baslik.TabIndex = 7;
            this.baslik.Text = "baslik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.download);
            this.Controls.Add(this.mp4);
            this.Controls.Add(this.mp3);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.RadioButton mp3;
        private System.Windows.Forms.RadioButton mp4;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label baslik;
    }
}

