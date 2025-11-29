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
            generalButton.Location = new Point(151, 336);
            generalButton.Margin = new Padding(5, 6, 5, 6);
            generalButton.Name = "generalButton";
            generalButton.Size = new Size(574, 136);
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
            switchOverviewButton.Location = new Point(597, 1358);
            switchOverviewButton.Margin = new Padding(5, 6, 5, 6);
            switchOverviewButton.Name = "switchOverviewButton";
            switchOverviewButton.Size = new Size(283, 170);
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
            switchDispenseButton.Location = new Point(303, 1358);
            switchDispenseButton.Margin = new Padding(5, 6, 5, 6);
            switchDispenseButton.Name = "switchDispenseButton";
            switchDispenseButton.Size = new Size(283, 170);
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
            switchPickButton.Location = new Point(10, 1358);
            switchPickButton.Margin = new Padding(5, 6, 5, 6);
            switchPickButton.Name = "switchPickButton";
            switchPickButton.Size = new Size(283, 170);
            switchPickButton.TabIndex = 14;
            switchPickButton.Text = "P";
            switchPickButton.UseVisualStyleBackColor = false;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-3, -2);
            timeLabel.Margin = new Padding(5, 0, 5, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(900, 48);
            timeLabel.TabIndex = 25;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cooledButton
            // 
            cooledButton.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold);
            cooledButton.ForeColor = Color.BlueViolet;
            cooledButton.Location = new Point(151, 586);
            cooledButton.Margin = new Padding(5, 6, 5, 6);
            cooledButton.Name = "cooledButton";
            cooledButton.Size = new Size(574, 136);
            cooledButton.TabIndex = 26;
            cooledButton.Text = "COOLED #";
            cooledButton.UseVisualStyleBackColor = true;
            cooledButton.Click += cooledButton_Click;
            // 
            // frozenButton
            // 
            frozenButton.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold);
            frozenButton.ForeColor = Color.BlueViolet;
            frozenButton.Location = new Point(151, 846);
            frozenButton.Margin = new Padding(5, 6, 5, 6);
            frozenButton.Name = "frozenButton";
            frozenButton.Size = new Size(574, 136);
            frozenButton.TabIndex = 27;
            frozenButton.Text = "FROZEN #";
            frozenButton.UseVisualStyleBackColor = true;
            frozenButton.Click += frozenButton_Click;
            // 
            // PickForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(895, 1552);
            Controls.Add(frozenButton);
            Controls.Add(cooledButton);
            Controls.Add(timeLabel);
            Controls.Add(generalButton);
            Controls.Add(switchOverviewButton);
            Controls.Add(switchDispenseButton);
            Controls.Add(switchPickButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "PickForm";
            Text = "PickForm";
            Load += PickForm_Load;
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