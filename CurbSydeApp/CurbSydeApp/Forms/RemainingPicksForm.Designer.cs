namespace CurbSydeApp.Forms
{
    partial class RemainingPicksForm
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
            currentLabel = new Label();
            completedLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            remainingLabel = new Label();
            backButton = new Button();
            hourXLabel = new Label();
            hourYLabel = new Label();
            hourZLabel = new Label();
            timeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // currentLabel
            // 
            currentLabel.BackColor = Color.White;
            currentLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentLabel.ForeColor = Color.BlueViolet;
            currentLabel.Location = new Point(12, 50);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(498, 61);
            currentLabel.TabIndex = 24;
            currentLabel.Text = "CURRENT: #";
            currentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedLabel.ForeColor = Color.BlueViolet;
            completedLabel.Location = new Point(12, 484);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(221, 39);
            completedLabel.TabIndex = 22;
            completedLabel.Text = "COMPLETED: #";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.BlueViolet;
            pictureBox4.Location = new Point(12, 434);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(498, 11);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BlueViolet;
            pictureBox2.Location = new Point(12, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(498, 11);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // remainingLabel
            // 
            remainingLabel.AutoSize = true;
            remainingLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remainingLabel.ForeColor = Color.BlueViolet;
            remainingLabel.Location = new Point(12, 173);
            remainingLabel.Name = "remainingLabel";
            remainingLabel.Size = new Size(221, 39);
            remainingLabel.TabIndex = 17;
            remainingLabel.Text = "REMAINING: #";
            // 
            // backButton
            // 
            backButton.BackColor = Color.BlueViolet;
            backButton.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(7, 676);
            backButton.Name = "backButton";
            backButton.Size = new Size(165, 85);
            backButton.TabIndex = 25;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // hourXLabel
            // 
            hourXLabel.BackColor = Color.White;
            hourXLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourXLabel.ForeColor = Color.BlueViolet;
            hourXLabel.Location = new Point(12, 243);
            hourXLabel.Name = "hourXLabel";
            hourXLabel.Size = new Size(498, 52);
            hourXLabel.TabIndex = 26;
            hourXLabel.Text = "Hour: #";
            hourXLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hourYLabel
            // 
            hourYLabel.BackColor = Color.White;
            hourYLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourYLabel.ForeColor = Color.BlueViolet;
            hourYLabel.Location = new Point(12, 295);
            hourYLabel.Name = "hourYLabel";
            hourYLabel.Size = new Size(498, 52);
            hourYLabel.TabIndex = 27;
            hourYLabel.Text = "Hour: #";
            hourYLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hourZLabel
            // 
            hourZLabel.BackColor = Color.White;
            hourZLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourZLabel.ForeColor = Color.BlueViolet;
            hourZLabel.Location = new Point(12, 347);
            hourZLabel.Name = "hourZLabel";
            hourZLabel.Size = new Size(498, 52);
            hourZLabel.TabIndex = 28;
            hourZLabel.Text = "Hour: #";
            hourZLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, -1);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 29;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RemainingPicksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(timeLabel);
            Controls.Add(hourZLabel);
            Controls.Add(hourYLabel);
            Controls.Add(hourXLabel);
            Controls.Add(backButton);
            Controls.Add(currentLabel);
            Controls.Add(completedLabel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(remainingLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemainingPicksForm";
            Text = "RemainingPicks";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentLabel;
        private Label completedLabel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label remainingLabel;
        private Button backButton;
        private Label hourXLabel;
        private Label hourYLabel;
        private Label hourZLabel;
        private Label timeLabel;
    }
}