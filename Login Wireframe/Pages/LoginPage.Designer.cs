
namespace Login_Wireframe
{
    partial class loginPageForm
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.googleLoginButton = new System.Windows.Forms.Button();
            this.facebookLoginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new Login_Wireframe.UserControls.UserControl1();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showLoginInfoButton = new System.Windows.Forms.Button();
            this.itemBoxUserControl1 = new Login_Wireframe.ItemBoxUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logoBox
            // 
            this.logoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoBox.Location = new System.Drawing.Point(474, 39);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(139, 91);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // googleLoginButton
            // 
            this.googleLoginButton.Location = new System.Drawing.Point(200, 575);
            this.googleLoginButton.Name = "googleLoginButton";
            this.googleLoginButton.Size = new System.Drawing.Size(145, 23);
            this.googleLoginButton.TabIndex = 8;
            this.googleLoginButton.Text = "Google Login";
            this.googleLoginButton.UseVisualStyleBackColor = true;
            // 
            // facebookLoginButton
            // 
            this.facebookLoginButton.Location = new System.Drawing.Point(428, 575);
            this.facebookLoginButton.Name = "facebookLoginButton";
            this.facebookLoginButton.Size = new System.Drawing.Size(145, 23);
            this.facebookLoginButton.TabIndex = 9;
            this.facebookLoginButton.Text = "FaceBook Login";
            this.facebookLoginButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 698);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 84);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(116, 186);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(568, 427);
            this.userControl11.TabIndex = 16;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "UserName:",
            "Password: "});
            this.listBox1.Location = new System.Drawing.Point(735, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 94);
            this.listBox1.TabIndex = 18;
            // 
            // showLoginInfoButton
            // 
            this.showLoginInfoButton.Location = new System.Drawing.Point(735, 380);
            this.showLoginInfoButton.Name = "showLoginInfoButton";
            this.showLoginInfoButton.Size = new System.Drawing.Size(182, 28);
            this.showLoginInfoButton.TabIndex = 20;
            this.showLoginInfoButton.Text = "Show UserName and Password";
            this.showLoginInfoButton.UseVisualStyleBackColor = true;
            this.showLoginInfoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemBoxUserControl1
            // 
            this.itemBoxUserControl1.Location = new System.Drawing.Point(866, 495);
            this.itemBoxUserControl1.Name = "itemBoxUserControl1";
            this.itemBoxUserControl1.Size = new System.Drawing.Size(8, 8);
            this.itemBoxUserControl1.TabIndex = 22;
            // 
            // loginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1093, 782);
            this.Controls.Add(this.itemBoxUserControl1);
            this.Controls.Add(this.showLoginInfoButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.facebookLoginButton);
            this.Controls.Add(this.googleLoginButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControl11);
            this.IsMdiContainer = true;
            this.Name = "loginPageForm";
            this.Text = "Coreys Knick Knacks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button googleLoginButton;
        private System.Windows.Forms.Button facebookLoginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private UserControls.UserControl1 userControl11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showLoginInfoButton;
        private ItemBoxUserControl itemBoxUserControl1;
    }
}

