namespace CurbSydeApp.Forms
{
    partial class SelectedCarForm
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
            carLabel = new Label();
            coolerLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            stageLabel = new Label();
            dispenseButton = new Button();
            backButton = new Button();
            minLabel = new Label();
            freezerLabel = new Label();
            pictureBox1 = new PictureBox();
            toteLabel1 = new Label();
            toteLabel2 = new Label();
            toteLabel3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-1, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 26;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // carLabel
            // 
            carLabel.BackColor = Color.White;
            carLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carLabel.ForeColor = Color.BlueViolet;
            carLabel.Location = new Point(12, 33);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(382, 47);
            carLabel.TabIndex = 25;
            carLabel.Text = "Spot - Car Name";
            carLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // coolerLabel
            // 
            coolerLabel.AutoSize = true;
            coolerLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coolerLabel.ForeColor = Color.BlueViolet;
            coolerLabel.Location = new Point(57, 251);
            coolerLabel.Name = "coolerLabel";
            coolerLabel.Size = new Size(153, 39);
            coolerLabel.TabIndex = 23;
            coolerLabel.Text = "COOLER #";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.BlueViolet;
            pictureBox4.Location = new Point(13, 383);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(498, 11);
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.BlueViolet;
            pictureBox3.Location = new Point(13, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(498, 11);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BlueViolet;
            pictureBox2.Location = new Point(12, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(498, 11);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // stageLabel
            // 
            stageLabel.AutoSize = true;
            stageLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stageLabel.ForeColor = Color.BlueViolet;
            stageLabel.Location = new Point(57, 106);
            stageLabel.Name = "stageLabel";
            stageLabel.Size = new Size(136, 39);
            stageLabel.TabIndex = 18;
            stageLabel.Text = "STAGE #";
            // 
            // dispenseButton
            // 
            dispenseButton.BackColor = Color.White;
            dispenseButton.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dispenseButton.ForeColor = Color.BlueViolet;
            dispenseButton.Location = new Point(323, 679);
            dispenseButton.Name = "dispenseButton";
            dispenseButton.Size = new Size(192, 85);
            dispenseButton.TabIndex = 17;
            dispenseButton.Text = "DISPENSE";
            dispenseButton.UseVisualStyleBackColor = false;
            dispenseButton.Click += dispenseButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.BlueViolet;
            backButton.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(8, 678);
            backButton.Name = "backButton";
            backButton.Size = new Size(165, 85);
            backButton.TabIndex = 27;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // minLabel
            // 
            minLabel.BackColor = Color.White;
            minLabel.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minLabel.ForeColor = Color.BlueViolet;
            minLabel.Location = new Point(393, 33);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(117, 47);
            minLabel.TabIndex = 28;
            minLabel.Text = "X min";
            minLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // freezerLabel
            // 
            freezerLabel.AutoSize = true;
            freezerLabel.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            freezerLabel.ForeColor = Color.BlueViolet;
            freezerLabel.Location = new Point(57, 397);
            freezerLabel.Name = "freezerLabel";
            freezerLabel.Size = new Size(170, 39);
            freezerLabel.TabIndex = 30;
            freezerLabel.Text = "FREEZER #";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.BlueViolet;
            pictureBox1.Location = new Point(13, 534);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 11);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // toteLabel1
            // 
            toteLabel1.AutoSize = true;
            toteLabel1.BackColor = Color.White;
            toteLabel1.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toteLabel1.ForeColor = Color.BlueViolet;
            toteLabel1.Location = new Point(338, 191);
            toteLabel1.Name = "toteLabel1";
            toteLabel1.Size = new Size(112, 32);
            toteLabel1.TabIndex = 31;
            toteLabel1.Text = "# totes";
            // 
            // toteLabel2
            // 
            toteLabel2.AutoSize = true;
            toteLabel2.BackColor = Color.White;
            toteLabel2.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toteLabel2.ForeColor = Color.BlueViolet;
            toteLabel2.Location = new Point(338, 339);
            toteLabel2.Name = "toteLabel2";
            toteLabel2.Size = new Size(112, 32);
            toteLabel2.TabIndex = 32;
            toteLabel2.Text = "# totes";
            // 
            // toteLabel3
            // 
            toteLabel3.AutoSize = true;
            toteLabel3.BackColor = Color.White;
            toteLabel3.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toteLabel3.ForeColor = Color.BlueViolet;
            toteLabel3.Location = new Point(338, 490);
            toteLabel3.Name = "toteLabel3";
            toteLabel3.Size = new Size(112, 32);
            toteLabel3.TabIndex = 33;
            toteLabel3.Text = "# totes";
            // 
            // SelectedCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(toteLabel3);
            Controls.Add(toteLabel2);
            Controls.Add(toteLabel1);
            Controls.Add(freezerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(minLabel);
            Controls.Add(timeLabel);
            Controls.Add(carLabel);
            Controls.Add(coolerLabel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(stageLabel);
            Controls.Add(dispenseButton);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectedCarForm";
            Text = "SelectedCarForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label carLabel;
        private Label coolerLabel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label stageLabel;
        private Button dispenseButton;
        private Button backButton;
        private Label minLabel;
        private Label freezerLabel;
        private PictureBox pictureBox1;
        private Label toteLabel1;
        private Label toteLabel2;
        private Label toteLabel3;
    }
}