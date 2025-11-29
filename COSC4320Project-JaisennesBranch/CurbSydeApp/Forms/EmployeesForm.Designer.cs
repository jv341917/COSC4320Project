namespace CurbSydeApp.Forms
{
    partial class EmployeesForm
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
            backButton = new Button();
            employeeLabel1 = new Label();
            employeeLabel2 = new Label();
            employeeLabel4 = new Label();
            employeeLabel3 = new Label();
            employeeLabel6 = new Label();
            employeeLabel5 = new Label();
            timeLabel = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.BlueViolet;
            backButton.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(8, 679);
            backButton.Name = "backButton";
            backButton.Size = new Size(165, 85);
            backButton.TabIndex = 4;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // employeeLabel1
            // 
            employeeLabel1.BackColor = Color.White;
            employeeLabel1.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel1.ForeColor = Color.BlueViolet;
            employeeLabel1.Location = new Point(45, 147);
            employeeLabel1.Name = "employeeLabel1";
            employeeLabel1.Size = new Size(431, 47);
            employeeLabel1.TabIndex = 5;
            employeeLabel1.Text = "Name - Activity";
            employeeLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // employeeLabel2
            // 
            employeeLabel2.BackColor = Color.White;
            employeeLabel2.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel2.ForeColor = Color.BlueViolet;
            employeeLabel2.Location = new Point(45, 251);
            employeeLabel2.Name = "employeeLabel2";
            employeeLabel2.Size = new Size(431, 47);
            employeeLabel2.TabIndex = 6;
            employeeLabel2.Text = "Name - Activity";
            employeeLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // employeeLabel4
            // 
            employeeLabel4.BackColor = Color.White;
            employeeLabel4.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel4.ForeColor = Color.BlueViolet;
            employeeLabel4.Location = new Point(45, 466);
            employeeLabel4.Name = "employeeLabel4";
            employeeLabel4.Size = new Size(431, 47);
            employeeLabel4.TabIndex = 8;
            employeeLabel4.Text = "Name - Activity";
            employeeLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // employeeLabel3
            // 
            employeeLabel3.BackColor = Color.White;
            employeeLabel3.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel3.ForeColor = Color.BlueViolet;
            employeeLabel3.Location = new Point(45, 362);
            employeeLabel3.Name = "employeeLabel3";
            employeeLabel3.Size = new Size(431, 47);
            employeeLabel3.TabIndex = 7;
            employeeLabel3.Text = "Name - Activity";
            employeeLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // employeeLabel6
            // 
            employeeLabel6.BackColor = Color.White;
            employeeLabel6.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel6.ForeColor = Color.BlueViolet;
            employeeLabel6.Location = new Point(45, 51);
            employeeLabel6.Name = "employeeLabel6";
            employeeLabel6.Size = new Size(431, 47);
            employeeLabel6.TabIndex = 10;
            employeeLabel6.Text = "Name - Activity";
            employeeLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // employeeLabel5
            // 
            employeeLabel5.BackColor = Color.White;
            employeeLabel5.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel5.ForeColor = Color.BlueViolet;
            employeeLabel5.Location = new Point(45, 560);
            employeeLabel5.Name = "employeeLabel5";
            employeeLabel5.Size = new Size(431, 47);
            employeeLabel5.TabIndex = 9;
            employeeLabel5.Text = "Name - Activity";
            employeeLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(-2, -1);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(525, 24);
            timeLabel.TabIndex = 15;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(timeLabel);
            Controls.Add(employeeLabel6);
            Controls.Add(employeeLabel5);
            Controls.Add(employeeLabel4);
            Controls.Add(employeeLabel3);
            Controls.Add(employeeLabel2);
            Controls.Add(employeeLabel1);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesForm";
            Text = "Employees";
            ResumeLayout(false);
        }

        #endregion
        private Button backButton;
        private Label employeeLabel1;
        private Label employeeLabel2;
        private Label employeeLabel4;
        private Label employeeLabel3;
        private Label employeeLabel6;
        private Label employeeLabel5;
        private Label timeLabel;
    }
}