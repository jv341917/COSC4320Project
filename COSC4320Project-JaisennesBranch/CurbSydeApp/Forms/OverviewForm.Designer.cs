namespace CurbSydeApp.Forms
{
    partial class OverviewForm
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
            switchPickButton = new Button();
            switchDispenseButton = new Button();
            switchOverviewButton = new Button();
            dispenseQueueLabel = new Label();
            employeesButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            hourPicksLabel = new Label();
            remainingPicksButton = new Button();
            userNameLabel = new Label();
            timeLabel = new Label();
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // switchPickButton
            // 
            switchPickButton.BackColor = Color.BlueViolet;
            switchPickButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchPickButton.ForeColor = Color.White;
            switchPickButton.Location = new Point(12, 1358);
            switchPickButton.Margin = new Padding(5, 6, 5, 6);
            switchPickButton.Name = "switchPickButton";
            switchPickButton.Size = new Size(283, 170);
            switchPickButton.TabIndex = 0;
            switchPickButton.Text = "P";
            switchPickButton.UseVisualStyleBackColor = false;
            switchPickButton.Click += switchPickButton_Click;
            // 
            // switchDispenseButton
            // 
            switchDispenseButton.BackColor = Color.BlueViolet;
            switchDispenseButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchDispenseButton.ForeColor = Color.White;
            switchDispenseButton.Location = new Point(305, 1358);
            switchDispenseButton.Margin = new Padding(5, 6, 5, 6);
            switchDispenseButton.Name = "switchDispenseButton";
            switchDispenseButton.Size = new Size(283, 170);
            switchDispenseButton.TabIndex = 2;
            switchDispenseButton.Text = "D";
            switchDispenseButton.UseVisualStyleBackColor = false;
            switchDispenseButton.Click += switchDispenseButton_Click;
            // 
            // switchOverviewButton
            // 
            switchOverviewButton.BackColor = Color.BlueViolet;
            switchOverviewButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchOverviewButton.ForeColor = Color.White;
            switchOverviewButton.Location = new Point(598, 1358);
            switchOverviewButton.Margin = new Padding(5, 6, 5, 6);
            switchOverviewButton.Name = "switchOverviewButton";
            switchOverviewButton.Size = new Size(283, 170);
            switchOverviewButton.TabIndex = 3;
            switchOverviewButton.Text = "O";
            switchOverviewButton.UseVisualStyleBackColor = false;
            // 
            // dispenseQueueLabel
            // 
            dispenseQueueLabel.AutoSize = true;
            dispenseQueueLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispenseQueueLabel.ForeColor = Color.BlueViolet;
            dispenseQueueLabel.Location = new Point(21, 336);
            dispenseQueueLabel.Margin = new Padding(5, 0, 5, 0);
            dispenseQueueLabel.Name = "dispenseQueueLabel";
            dispenseQueueLabel.Size = new Size(449, 56);
            dispenseQueueLabel.TabIndex = 5;
            dispenseQueueLabel.Text = "DISPENSE QUEUE: #";
            // 
            // employeesButton
            // 
            employeesButton.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesButton.ForeColor = Color.BlueViolet;
            employeesButton.Location = new Point(240, 744);
            employeesButton.Margin = new Padding(5, 6, 5, 6);
            employeesButton.Name = "employeesButton";
            employeesButton.Size = new Size(372, 136);
            employeesButton.TabIndex = 6;
            employeesButton.Text = "EMPLOYEES";
            employeesButton.UseVisualStyleBackColor = true;
            employeesButton.Click += employeesButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BlueViolet;
            pictureBox2.Location = new Point(21, 278);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(854, 22);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.BlueViolet;
            pictureBox3.Location = new Point(21, 434);
            pictureBox3.Margin = new Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(854, 22);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.BlueViolet;
            pictureBox4.Location = new Point(21, 600);
            pictureBox4.Margin = new Padding(5, 6, 5, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(854, 22);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // hourPicksLabel
            // 
            hourPicksLabel.AutoSize = true;
            hourPicksLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hourPicksLabel.ForeColor = Color.BlueViolet;
            hourPicksLabel.Location = new Point(21, 496);
            hourPicksLabel.Margin = new Padding(5, 0, 5, 0);
            hourPicksLabel.Name = "hourPicksLabel";
            hourPicksLabel.Size = new Size(349, 56);
            hourPicksLabel.TabIndex = 11;
            hourPicksLabel.Text = "HOUR PICKS: #";
            // 
            // remainingPicksButton
            // 
            remainingPicksButton.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remainingPicksButton.ForeColor = Color.BlueViolet;
            remainingPicksButton.Location = new Point(202, 998);
            remainingPicksButton.Margin = new Padding(5, 6, 5, 6);
            remainingPicksButton.Name = "remainingPicksButton";
            remainingPicksButton.Size = new Size(441, 136);
            remainingPicksButton.TabIndex = 12;
            remainingPicksButton.Text = "REMAINING PICKS";
            remainingPicksButton.UseVisualStyleBackColor = true;
            remainingPicksButton.Click += remainingPicksButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.BackColor = Color.White;
            userNameLabel.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.BlueViolet;
            userNameLabel.Location = new Point(65, 112);
            userNameLabel.Margin = new Padding(5, 0, 5, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(739, 94);
            userNameLabel.TabIndex = 13;
            userNameLabel.Text = "Hi, X";
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-3, 0);
            timeLabel.Margin = new Padding(5, 0, 5, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(900, 48);
            timeLabel.TabIndex = 14;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.BlueViolet;
            logoutButton.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(696, 112);
            logoutButton.Margin = new Padding(5, 6, 5, 6);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(178, 94);
            logoutButton.TabIndex = 15;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // OverviewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(895, 1552);
            Controls.Add(logoutButton);
            Controls.Add(timeLabel);
            Controls.Add(userNameLabel);
            Controls.Add(remainingPicksButton);
            Controls.Add(hourPicksLabel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(employeesButton);
            Controls.Add(dispenseQueueLabel);
            Controls.Add(switchOverviewButton);
            Controls.Add(switchDispenseButton);
            Controls.Add(switchPickButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "OverviewForm";
            Text = "OverviewForm";
            Load += OverviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button switchPickButton;
        private Button switchDispenseButton;
        private Button switchOverviewButton;
        private Label dispenseQueueLabel;
        private Button employeesButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label hourPicksLabel;
        private Button remainingPicksButton;
        private Label userNameLabel;
        private Label timeLabel;
        private Button logoutButton;
    }
}