
namespace Login_Wireframe
{
    partial class SelectPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPage));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.searchButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.searchBarTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(361, 23);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(82, 63);
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "searchButtonIcon.png");
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(205, 205);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(136, 136);
            this.addItemButton.TabIndex = 7;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(450, 205);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(136, 136);
            this.removeItemButton.TabIndex = 8;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 136);
            this.button3.TabIndex = 9;
            this.button3.Text = "View All Items";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsPictureBox.Image")));
            this.settingsPictureBox.Location = new System.Drawing.Point(561, 125);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(25, 23);
            this.settingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPictureBox.TabIndex = 12;
            this.settingsPictureBox.TabStop = false;
            // 
            // searchButtonPictureBox
            // 
            this.searchButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchButtonPictureBox.Image")));
            this.searchButtonPictureBox.Location = new System.Drawing.Point(205, 125);
            this.searchButtonPictureBox.Name = "searchButtonPictureBox";
            this.searchButtonPictureBox.Size = new System.Drawing.Size(25, 23);
            this.searchButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButtonPictureBox.TabIndex = 11;
            this.searchButtonPictureBox.TabStop = false;
            // 
            // searchBarTextBox
            // 
            this.searchBarTextBox.Location = new System.Drawing.Point(205, 125);
            this.searchBarTextBox.Name = "searchBarTextBox";
            this.searchBarTextBox.Size = new System.Drawing.Size(359, 23);
            this.searchBarTextBox.TabIndex = 10;
            // 
            // SelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 782);
            this.Controls.Add(this.settingsPictureBox);
            this.Controls.Add(this.searchButtonPictureBox);
            this.Controls.Add(this.searchBarTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelectPage";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.PictureBox searchButtonPictureBox;
        private System.Windows.Forms.TextBox searchBarTextBox;
    }
}