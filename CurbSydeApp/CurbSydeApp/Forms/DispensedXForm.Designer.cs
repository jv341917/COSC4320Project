namespace CurbSydeApp.Forms
{
    partial class DispensedXForm
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
            carLabel = new Label();
            middleLabel = new Label();
            topLabel = new Label();
            timeLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // carLabel
            // 
            carLabel.BackColor = Color.White;
            carLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carLabel.ForeColor = Color.BlueViolet;
            carLabel.Location = new Point(67, 376);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(397, 77);
            carLabel.TabIndex = 42;
            carLabel.Text = "Car Name";
            carLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // middleLabel
            // 
            middleLabel.BackColor = Color.White;
            middleLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            middleLabel.ForeColor = Color.BlueViolet;
            middleLabel.Location = new Point(67, 318);
            middleLabel.Name = "middleLabel";
            middleLabel.Size = new Size(397, 77);
            middleLabel.TabIndex = 41;
            middleLabel.Text = "Dispensed";
            middleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // topLabel
            // 
            topLabel.BackColor = Color.White;
            topLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLabel.ForeColor = Color.BlueViolet;
            topLabel.Location = new Point(67, 241);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(397, 77);
            topLabel.TabIndex = 40;
            topLabel.Text = "You";
            topLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 39;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // backButton
            // 
            backButton.BackColor = Color.BlueViolet;
            backButton.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(6, 679);
            backButton.Name = "backButton";
            backButton.Size = new Size(165, 85);
            backButton.TabIndex = 38;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // DispensedXForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(carLabel);
            Controls.Add(middleLabel);
            Controls.Add(topLabel);
            Controls.Add(timeLabel);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DispensedXForm";
            Text = "DispensedXForm";
            ResumeLayout(false);
        }

        #endregion

        private Label carLabel;
        private Label middleLabel;
        private Label topLabel;
        private Label timeLabel;
        private Button backButton;
    }
}