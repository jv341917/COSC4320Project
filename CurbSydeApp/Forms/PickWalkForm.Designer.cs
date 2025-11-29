namespace CurbSydeApp.Forms
{
    partial class PickWalkForm
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
            timeLabel = new Label();
            backButton = new Button();
            topLabel = new Label();
            middleLabel = new Label();
            categoryLabel = new Label();
            bottomLabel = new Label();
            walkAmtLabel = new Label();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, -1);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 32;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // backButton
            // 
            backButton.BackColor = Color.BlueViolet;
            backButton.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(6, 678);
            backButton.Name = "backButton";
            backButton.Size = new Size(165, 85);
            backButton.TabIndex = 5;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // topLabel
            // 
            topLabel.BackColor = Color.White;
            topLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLabel.ForeColor = Color.BlueViolet;
            topLabel.Location = new Point(65, 215);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(397, 77);
            topLabel.TabIndex = 33;
            topLabel.Text = "You Are";
            topLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // middleLabel
            // 
            middleLabel.BackColor = Color.White;
            middleLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            middleLabel.ForeColor = Color.BlueViolet;
            middleLabel.Location = new Point(65, 292);
            middleLabel.Name = "middleLabel";
            middleLabel.Size = new Size(397, 77);
            middleLabel.TabIndex = 34;
            middleLabel.Text = "In A";
            middleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // categoryLabel
            // 
            categoryLabel.BackColor = Color.White;
            categoryLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = Color.BlueViolet;
            categoryLabel.Location = new Point(65, 369);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(397, 77);
            categoryLabel.TabIndex = 35;
            categoryLabel.Text = "X";
            categoryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bottomLabel
            // 
            bottomLabel.BackColor = Color.White;
            bottomLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bottomLabel.ForeColor = Color.BlueViolet;
            bottomLabel.Location = new Point(65, 422);
            bottomLabel.Name = "bottomLabel";
            bottomLabel.Size = new Size(397, 77);
            bottomLabel.TabIndex = 36;
            bottomLabel.Text = "Pick Walk";
            bottomLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // walkAmtLabel
            // 
            walkAmtLabel.AutoSize = true;
            walkAmtLabel.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            walkAmtLabel.ForeColor = Color.BlueViolet;
            walkAmtLabel.Location = new Point(203, 55);
            walkAmtLabel.Name = "walkAmtLabel";
            walkAmtLabel.Size = new Size(114, 43);
            walkAmtLabel.TabIndex = 37;
            walkAmtLabel.Text = "Y / X";
            // 
            // PickWalkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 394);
            Controls.Add(walkAmtLabel);
            Controls.Add(bottomLabel);
            Controls.Add(categoryLabel);
            Controls.Add(middleLabel);
            Controls.Add(topLabel);
            Controls.Add(timeLabel);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PickWalkForm";
            Text = "PickWalkForm";
            Load += PickWalkForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label timeLabel;
        private Button backButton;
        private Label topLabel;
        private Label middleLabel;
        private Label categoryLabel;
        private Label bottomLabel;
        private Label walkAmtLabel;
    }
}