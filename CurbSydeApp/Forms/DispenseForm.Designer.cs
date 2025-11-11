namespace CurbSydeApp.Forms
{
    partial class DispenseForm
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
            minLabel1 = new Label();
            carButton1 = new Button();
            switchOverviewButton = new Button();
            switchDispenseButton = new Button();
            switchPickButton = new Button();
            carButton2 = new Button();
            carButton3 = new Button();
            carButton4 = new Button();
            carButton5 = new Button();
            minLabel2 = new Label();
            minLabel3 = new Label();
            minLabel4 = new Label();
            minLabel5 = new Label();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 26;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minLabel1
            // 
            minLabel1.BackColor = Color.White;
            minLabel1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            minLabel1.ForeColor = Color.BlueViolet;
            minLabel1.Location = new Point(429, 107);
            minLabel1.Name = "minLabel1";
            minLabel1.Size = new Size(69, 58);
            minLabel1.TabIndex = 25;
            minLabel1.Text = "X min";
            minLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // carButton1
            // 
            carButton1.BackColor = Color.White;
            carButton1.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carButton1.ForeColor = Color.BlueViolet;
            carButton1.Location = new Point(27, 103);
            carButton1.Name = "carButton1";
            carButton1.Size = new Size(383, 68);
            carButton1.TabIndex = 19;
            carButton1.Text = "Spot - Car Name";
            carButton1.TextAlign = ContentAlignment.MiddleLeft;
            carButton1.UseVisualStyleBackColor = false;
            carButton1.Click += carButton1_Click;
            // 
            // switchOverviewButton
            // 
            switchOverviewButton.BackColor = Color.BlueViolet;
            switchOverviewButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchOverviewButton.ForeColor = Color.White;
            switchOverviewButton.Location = new Point(349, 679);
            switchOverviewButton.Name = "switchOverviewButton";
            switchOverviewButton.Size = new Size(165, 85);
            switchOverviewButton.TabIndex = 17;
            switchOverviewButton.Text = "O";
            switchOverviewButton.UseVisualStyleBackColor = false;
            switchOverviewButton.Click += switchOverviewButton_Click;
            // 
            // switchDispenseButton
            // 
            switchDispenseButton.BackColor = Color.BlueViolet;
            switchDispenseButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchDispenseButton.ForeColor = Color.White;
            switchDispenseButton.Location = new Point(178, 679);
            switchDispenseButton.Name = "switchDispenseButton";
            switchDispenseButton.Size = new Size(165, 85);
            switchDispenseButton.TabIndex = 16;
            switchDispenseButton.Text = "D";
            switchDispenseButton.UseVisualStyleBackColor = false;
            switchDispenseButton.Click += switchDispenseButton_Click;
            // 
            // switchPickButton
            // 
            switchPickButton.BackColor = Color.BlueViolet;
            switchPickButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchPickButton.ForeColor = Color.White;
            switchPickButton.Location = new Point(7, 679);
            switchPickButton.Name = "switchPickButton";
            switchPickButton.Size = new Size(165, 85);
            switchPickButton.TabIndex = 15;
            switchPickButton.Text = "P";
            switchPickButton.UseVisualStyleBackColor = false;
            switchPickButton.Click += switchPickButton_Click;
            // 
            // carButton2
            // 
            carButton2.BackColor = Color.White;
            carButton2.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carButton2.ForeColor = Color.BlueViolet;
            carButton2.Location = new Point(27, 209);
            carButton2.Name = "carButton2";
            carButton2.Size = new Size(383, 68);
            carButton2.TabIndex = 27;
            carButton2.Text = "Spot - Car Name";
            carButton2.TextAlign = ContentAlignment.MiddleLeft;
            carButton2.UseVisualStyleBackColor = false;
            carButton2.Click += carButton2_Click;
            // 
            // carButton3
            // 
            carButton3.BackColor = Color.White;
            carButton3.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carButton3.ForeColor = Color.BlueViolet;
            carButton3.Location = new Point(27, 313);
            carButton3.Name = "carButton3";
            carButton3.Size = new Size(383, 68);
            carButton3.TabIndex = 28;
            carButton3.Text = "Spot - Car Name";
            carButton3.TextAlign = ContentAlignment.MiddleLeft;
            carButton3.UseVisualStyleBackColor = false;
            carButton3.Click += carButton3_Click;
            // 
            // carButton4
            // 
            carButton4.BackColor = Color.White;
            carButton4.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carButton4.ForeColor = Color.BlueViolet;
            carButton4.Location = new Point(27, 414);
            carButton4.Name = "carButton4";
            carButton4.Size = new Size(383, 68);
            carButton4.TabIndex = 29;
            carButton4.Text = "Spot - Car Name";
            carButton4.TextAlign = ContentAlignment.MiddleLeft;
            carButton4.UseVisualStyleBackColor = false;
            carButton4.Click += carButton4_Click;
            // 
            // carButton5
            // 
            carButton5.BackColor = Color.White;
            carButton5.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carButton5.ForeColor = Color.BlueViolet;
            carButton5.Location = new Point(27, 520);
            carButton5.Name = "carButton5";
            carButton5.Size = new Size(383, 68);
            carButton5.TabIndex = 30;
            carButton5.Text = "Spot - Car Name";
            carButton5.TextAlign = ContentAlignment.MiddleLeft;
            carButton5.UseVisualStyleBackColor = false;
            carButton5.Click += carButton5_Click;
            // 
            // minLabel2
            // 
            minLabel2.BackColor = Color.White;
            minLabel2.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            minLabel2.ForeColor = Color.BlueViolet;
            minLabel2.Location = new Point(429, 213);
            minLabel2.Name = "minLabel2";
            minLabel2.Size = new Size(69, 58);
            minLabel2.TabIndex = 31;
            minLabel2.Text = "X min";
            minLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minLabel3
            // 
            minLabel3.BackColor = Color.White;
            minLabel3.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            minLabel3.ForeColor = Color.BlueViolet;
            minLabel3.Location = new Point(429, 318);
            minLabel3.Name = "minLabel3";
            minLabel3.Size = new Size(69, 58);
            minLabel3.TabIndex = 32;
            minLabel3.Text = "X min";
            minLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minLabel4
            // 
            minLabel4.BackColor = Color.White;
            minLabel4.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            minLabel4.ForeColor = Color.BlueViolet;
            minLabel4.Location = new Point(429, 419);
            minLabel4.Name = "minLabel4";
            minLabel4.Size = new Size(69, 58);
            minLabel4.TabIndex = 33;
            minLabel4.Text = "X min";
            minLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minLabel5
            // 
            minLabel5.BackColor = Color.White;
            minLabel5.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            minLabel5.ForeColor = Color.BlueViolet;
            minLabel5.Location = new Point(429, 524);
            minLabel5.Name = "minLabel5";
            minLabel5.Size = new Size(69, 58);
            minLabel5.TabIndex = 34;
            minLabel5.Text = "X min";
            minLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DispenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(minLabel5);
            Controls.Add(minLabel4);
            Controls.Add(minLabel3);
            Controls.Add(minLabel2);
            Controls.Add(carButton5);
            Controls.Add(carButton4);
            Controls.Add(carButton3);
            Controls.Add(carButton2);
            Controls.Add(timeLabel);
            Controls.Add(minLabel1);
            Controls.Add(carButton1);
            Controls.Add(switchOverviewButton);
            Controls.Add(switchDispenseButton);
            Controls.Add(switchPickButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DispenseForm";
            Text = "DispenseForm";
            ResumeLayout(false);
        }

        #endregion

        private Label timeLabel;
        private Label minLabel1;
        private Button carButton1;
        private Button switchOverviewButton;
        private Button switchDispenseButton;
        private Button switchPickButton;
        private Button carButton2;
        private Button carButton3;
        private Button carButton4;
        private Button carButton5;
        private Label minLabel2;
        private Label minLabel3;
        private Label minLabel4;
        private Label minLabel5;
    }
}