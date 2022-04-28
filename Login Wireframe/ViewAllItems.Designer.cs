
namespace Login_Wireframe
{
    partial class ViewAllItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllItems));
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.searchButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.searchBoxTextBox = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsPictureBox.Image")));
            this.settingsPictureBox.Location = new System.Drawing.Point(555, 131);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(25, 23);
            this.settingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPictureBox.TabIndex = 9;
            this.settingsPictureBox.TabStop = false;
            // 
            // searchButtonPictureBox
            // 
            this.searchButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchButtonPictureBox.Image")));
            this.searchButtonPictureBox.Location = new System.Drawing.Point(199, 131);
            this.searchButtonPictureBox.Name = "searchButtonPictureBox";
            this.searchButtonPictureBox.Size = new System.Drawing.Size(25, 23);
            this.searchButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButtonPictureBox.TabIndex = 8;
            this.searchButtonPictureBox.TabStop = false;
            // 
            // searchBoxTextBox
            // 
            this.searchBoxTextBox.Location = new System.Drawing.Point(199, 131);
            this.searchBoxTextBox.Name = "searchBoxTextBox";
            this.searchBoxTextBox.Size = new System.Drawing.Size(359, 23);
            this.searchBoxTextBox.TabIndex = 7;
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(360, 21);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(82, 63);
            this.logoBox.TabIndex = 11;
            this.logoBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 105);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ViewAllItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 782);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingsPictureBox);
            this.Controls.Add(this.searchButtonPictureBox);
            this.Controls.Add(this.searchBoxTextBox);
            this.Name = "ViewAllItems";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewAllItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.PictureBox searchButtonPictureBox;
        private System.Windows.Forms.TextBox searchBoxTextBox;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}