namespace CurbSydeApp.Forms
{
    partial class PickForm
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
            generalButton = new Button();
            switchOverviewButton = new Button();
            switchDispenseButton = new Button();
            switchPickButton = new Button();
            timeLabel = new Label();
            cooledButton = new Button();
            frozenButton = new Button();
            SuspendLayout();
            // 
            // generalButton
            // 
            generalButton.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold);
            generalButton.ForeColor = Color.BlueViolet;
            generalButton.Location = new Point(88, 168);
            generalButton.Name = "generalButton";
            generalButton.Size = new Size(335, 68);
            generalButton.TabIndex = 18;
            generalButton.Text = "GENERAL #";
            generalButton.UseVisualStyleBackColor = true;
            generalButton.Click += generalButton_Click;
            // 
            // switchOverviewButton
            // 
            switchOverviewButton.BackColor = Color.BlueViolet;
            switchOverviewButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchOverviewButton.ForeColor = Color.White;
            switchOverviewButton.Location = new Point(348, 679);
            switchOverviewButton.Name = "switchOverviewButton";
            switchOverviewButton.Size = new Size(165, 85);
            switchOverviewButton.TabIndex = 16;
            switchOverviewButton.Text = "O";
            switchOverviewButton.UseVisualStyleBackColor = false;
            switchOverviewButton.Click += switchOverviewButton_Click;
            // 
            // switchDispenseButton
            // 
            switchDispenseButton.BackColor = Color.BlueViolet;
            switchDispenseButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchDispenseButton.ForeColor = Color.White;
            switchDispenseButton.Location = new Point(177, 679);
            switchDispenseButton.Name = "switchDispenseButton";
            switchDispenseButton.Size = new Size(165, 85);
            switchDispenseButton.TabIndex = 15;
            switchDispenseButton.Text = "D";
            switchDispenseButton.UseVisualStyleBackColor = false;
            switchDispenseButton.Click += switchDispenseButton_Click;
            // 
            // switchPickButton
            // 
            switchPickButton.BackColor = Color.BlueViolet;
            switchPickButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchPickButton.ForeColor = Color.White;
            switchPickButton.Location = new Point(6, 679);
            switchPickButton.Name = "switchPickButton";
            switchPickButton.Size = new Size(165, 85);
            switchPickButton.TabIndex = 14;
            switchPickButton.Text = "P";
            switchPickButton.UseVisualStyleBackColor = false;
            //switchPickButton.Click += switchPickButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, -1);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 25;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cooledButton
            // 
            cooledButton.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold);
            cooledButton.ForeColor = Color.BlueViolet;
            cooledButton.Location = new Point(88, 293);
            cooledButton.Name = "cooledButton";
            cooledButton.Size = new Size(335, 68);
            cooledButton.TabIndex = 26;
            cooledButton.Text = "COOLED #";
            cooledButton.UseVisualStyleBackColor = true;
            cooledButton.Click += cooledButton_Click;
            // 
            // frozenButton
            // 
            frozenButton.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold);
            frozenButton.ForeColor = Color.BlueViolet;
            frozenButton.Location = new Point(88, 423);
            frozenButton.Name = "frozenButton";
            frozenButton.Size = new Size(335, 68);
            frozenButton.TabIndex = 27;
            frozenButton.Text = "FROZEN #";
            frozenButton.UseVisualStyleBackColor = true;
            frozenButton.Click += frozenButton_Click;
            // 
            // PickForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(frozenButton);
            Controls.Add(cooledButton);
            Controls.Add(timeLabel);
            Controls.Add(generalButton);
            Controls.Add(switchOverviewButton);
            Controls.Add(switchDispenseButton);
            Controls.Add(switchPickButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PickForm";
            Text = "PickForm";
            ResumeLayout(false);
        }

        #endregion
        private Button generalButton;
        private Button switchOverviewButton;
        private Button switchDispenseButton;
        private Button switchPickButton;
        private Label timeLabel;
        private Button cooledButton;
        private Button frozenButton;
    }
}