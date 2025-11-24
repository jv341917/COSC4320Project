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
            switchPickButton.Location = new Point(7, 679);
            switchPickButton.Name = "switchPickButton";
            switchPickButton.Size = new Size(165, 85);
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
            switchDispenseButton.Location = new Point(178, 679);
            switchDispenseButton.Name = "switchDispenseButton";
            switchDispenseButton.Size = new Size(165, 85);
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
            switchOverviewButton.Location = new Point(349, 679);
            switchOverviewButton.Name = "switchOverviewButton";
            switchOverviewButton.Size = new Size(165, 85);
            switchOverviewButton.TabIndex = 3;
            switchOverviewButton.Text = "O";
            switchOverviewButton.UseVisualStyleBackColor = false;
            switchOverviewButton.Click += switchOverviewButton_Click;
            // 
            // dispenseQueueLabel
            // 
            dispenseQueueLabel.AutoSize = true;
            dispenseQueueLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispenseQueueLabel.ForeColor = Color.BlueViolet;
            dispenseQueueLabel.Location = new Point(12, 168);
            dispenseQueueLabel.Name = "dispenseQueueLabel";
            dispenseQueueLabel.Size = new Size(252, 32);
            dispenseQueueLabel.TabIndex = 5;
            dispenseQueueLabel.Text = "DISPENSE QUEUE: #";
            // 
            // employeesButton
            // 
            employeesButton.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesButton.ForeColor = Color.BlueViolet;
            employeesButton.Location = new Point(140, 372);
            employeesButton.Name = "employeesButton";
            employeesButton.Size = new Size(217, 68);
            employeesButton.TabIndex = 6;
            employeesButton.Text = "EMPLOYEES";
            employeesButton.UseVisualStyleBackColor = true;
            employeesButton.Click += employeesButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BlueViolet;
            pictureBox2.Location = new Point(12, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(498, 11);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.BlueViolet;
            pictureBox3.Location = new Point(12, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(498, 11);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.BlueViolet;
            pictureBox4.Location = new Point(12, 300);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(498, 11);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // hourPicksLabel
            // 
            hourPicksLabel.AutoSize = true;
            hourPicksLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hourPicksLabel.ForeColor = Color.BlueViolet;
            hourPicksLabel.Location = new Point(12, 248);
            hourPicksLabel.Name = "hourPicksLabel";
            hourPicksLabel.Size = new Size(196, 32);
            hourPicksLabel.TabIndex = 11;
            hourPicksLabel.Text = "HOUR PICKS: #";
            // 
            // remainingPicksButton
            // 
            remainingPicksButton.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remainingPicksButton.ForeColor = Color.BlueViolet;
            remainingPicksButton.Location = new Point(118, 499);
            remainingPicksButton.Name = "remainingPicksButton";
            remainingPicksButton.Size = new Size(257, 68);
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
            userNameLabel.Location = new Point(38, 56);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(431, 47);
            userNameLabel.TabIndex = 13;
            userNameLabel.Text = "Hi, X";
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 14;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OverviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
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
            Name = "OverviewForm";
            Text = "OverviewForm";
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
    }
}