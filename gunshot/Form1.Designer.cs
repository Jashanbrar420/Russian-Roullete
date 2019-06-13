namespace gunshot
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
            this.btnload = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.btnfire = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(251, 73);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(115, 52);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Load Bullet";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnspin
            // 
            this.btnspin.Location = new System.Drawing.Point(420, 73);
            this.btnspin.Name = "btnspin";
            this.btnspin.Size = new System.Drawing.Size(120, 52);
            this.btnspin.TabIndex = 1;
            this.btnspin.Text = "Spin Chamber";
            this.btnspin.UseVisualStyleBackColor = true;
            this.btnspin.Click += new System.EventHandler(this.btnspin_Click);
            // 
            // btnfire
            // 
            this.btnfire.Location = new System.Drawing.Point(578, 73);
            this.btnfire.Name = "btnfire";
            this.btnfire.Size = new System.Drawing.Size(144, 52);
            this.btnfire.TabIndex = 2;
            this.btnfire.Text = "Fire";
            this.btnfire.UseVisualStyleBackColor = true;
            this.btnfire.Click += new System.EventHandler(this.btnfire_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gunshot.Properties.Resources.chamber1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gunshot.Properties.Resources.gun;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnreplay
            // 
            this.btnreplay.Location = new System.Drawing.Point(463, 254);
            this.btnreplay.Name = "btnreplay";
            this.btnreplay.Size = new System.Drawing.Size(201, 82);
            this.btnreplay.TabIndex = 5;
            this.btnreplay.Text = "Replay";
            this.btnreplay.UseVisualStyleBackColor = true;
            this.btnreplay.Click += new System.EventHandler(this.btnreplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnfire);
            this.Controls.Add(this.btnspin);
            this.Controls.Add(this.btnload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.Button btnfire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnreplay;
    }
}

