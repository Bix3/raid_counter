namespace raid_counter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rocket_picture_box = new System.Windows.Forms.PictureBox();
            this.c4_picture_box = new System.Windows.Forms.PictureBox();
            this.rocket_up_down = new System.Windows.Forms.NumericUpDown();
            this.c4_up_down = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rocket_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket_up_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4_up_down)).BeginInit();
            this.SuspendLayout();
            // 
            // rocket_picture_box
            // 
            this.rocket_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("rocket_picture_box.Image")));
            this.rocket_picture_box.Location = new System.Drawing.Point(12, 12);
            this.rocket_picture_box.Name = "rocket_picture_box";
            this.rocket_picture_box.Size = new System.Drawing.Size(370, 296);
            this.rocket_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket_picture_box.TabIndex = 0;
            this.rocket_picture_box.TabStop = false;
            // 
            // c4_picture_box
            // 
            this.c4_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("c4_picture_box.Image")));
            this.c4_picture_box.Location = new System.Drawing.Point(425, 12);
            this.c4_picture_box.Name = "c4_picture_box";
            this.c4_picture_box.Size = new System.Drawing.Size(370, 296);
            this.c4_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c4_picture_box.TabIndex = 1;
            this.c4_picture_box.TabStop = false;
            // 
            // rocket_up_down
            // 
            this.rocket_up_down.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rocket_up_down.Location = new System.Drawing.Point(12, 314);
            this.rocket_up_down.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rocket_up_down.Name = "rocket_up_down";
            this.rocket_up_down.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rocket_up_down.Size = new System.Drawing.Size(370, 114);
            this.rocket_up_down.TabIndex = 2;
            this.rocket_up_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rocket_up_down.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // c4_up_down
            // 
            this.c4_up_down.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c4_up_down.Location = new System.Drawing.Point(425, 314);
            this.c4_up_down.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.c4_up_down.Name = "c4_up_down";
            this.c4_up_down.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.c4_up_down.Size = new System.Drawing.Size(370, 114);
            this.c4_up_down.TabIndex = 3;
            this.c4_up_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 468);
            this.Controls.Add(this.c4_up_down);
            this.Controls.Add(this.rocket_up_down);
            this.Controls.Add(this.c4_picture_box);
            this.Controls.Add(this.rocket_picture_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rocket_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket_up_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4_up_down)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox rocket_picture_box;
        private PictureBox c4_picture_box;
        private NumericUpDown rocket_up_down;
        private NumericUpDown c4_up_down;
    }
}