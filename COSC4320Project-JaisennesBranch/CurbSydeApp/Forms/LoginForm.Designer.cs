namespace CurbSydeApp.Forms
{
    partial class LoginForm
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
            titleLabel = new Label();
            usernameLabel = new Label();
            loginButton = new Button();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.BlueViolet;
            titleLabel.BorderStyle = BorderStyle.FixedSingle;
            titleLabel.Font = new Font("Segoe Print", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(114, 82);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(300, 87);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Curb-Syde";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.BlueViolet;
            usernameLabel.Location = new Point(67, 270);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(120, 28);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.BlueViolet;
            loginButton.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(163, 587);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(196, 68);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // usernameInput
            // 
            usernameInput.BorderStyle = BorderStyle.FixedSingle;
            usernameInput.Cursor = Cursors.IBeam;
            usernameInput.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.Location = new Point(94, 301);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(338, 26);
            usernameInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.FixedSingle;
            passwordInput.Cursor = Cursors.IBeam;
            passwordInput.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(94, 413);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(338, 26);
            passwordInput.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.BlueViolet;
            passwordLabel.Location = new Point(67, 382);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(120, 28);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(passwordLabel);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(loginButton);
            Controls.Add(usernameLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label usernameLabel;
        private Button loginButton;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label passwordLabel;
    }
}