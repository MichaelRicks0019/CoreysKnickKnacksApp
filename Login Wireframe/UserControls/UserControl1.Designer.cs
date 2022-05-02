
namespace Login_Wireframe.UserControls
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.ViewPassowordPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassowordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox.Location = new System.Drawing.Point(178, 49);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(206, 46);
            this.loginTextBox.TabIndex = 13;
            this.loginTextBox.Text = "Login";
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(95, 191);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 15);
            this.password.TabIndex = 12;
            this.password.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(95, 147);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(65, 15);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "UserName:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(95, 165);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(373, 23);
            this.userNameTextBox.TabIndex = 10;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(95, 210);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(373, 23);
            this.passwordTextbox.TabIndex = 9;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(95, 276);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(373, 51);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // ViewPassowordPictureBox
            // 
            this.ViewPassowordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ViewPassowordPictureBox.Image")));
            this.ViewPassowordPictureBox.Location = new System.Drawing.Point(474, 211);
            this.ViewPassowordPictureBox.Name = "ViewPassowordPictureBox";
            this.ViewPassowordPictureBox.Size = new System.Drawing.Size(22, 22);
            this.ViewPassowordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ViewPassowordPictureBox.TabIndex = 14;
            this.ViewPassowordPictureBox.TabStop = false;
            this.ViewPassowordPictureBox.Click += new System.EventHandler(this.ViewPassowordPictureBox_Click);
            this.ViewPassowordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPassowordPictureBox_MouseDown);
            this.ViewPassowordPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPassowordPictureBox_MouseUp);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewPassowordPictureBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginButton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(568, 383);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassowordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox ViewPassowordPictureBox;
    }
}
