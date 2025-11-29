namespace CurbSydeApp.Forms
{
    partial class LogoutForm
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
            bottomLabel = new Label();
            topLabel = new Label();
            SuspendLayout();
            // 
            // bottomLabel
            // 
            bottomLabel.BackColor = Color.White;
            bottomLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bottomLabel.ForeColor = Color.BlueViolet;
            bottomLabel.Location = new Point(63, 359);
            bottomLabel.Name = "bottomLabel";
            bottomLabel.Size = new Size(397, 77);
            bottomLabel.TabIndex = 44;
            bottomLabel.Text = "Logged Out";
            bottomLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // topLabel
            // 
            topLabel.BackColor = Color.White;
            topLabel.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLabel.ForeColor = Color.BlueViolet;
            topLabel.Location = new Point(63, 282);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(397, 77);
            topLabel.TabIndex = 43;
            topLabel.Text = "You Are";
            topLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(522, 776);
            Controls.Add(bottomLabel);
            Controls.Add(topLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogoutForm";
            Text = "LogoutForm";
            ResumeLayout(false);
        }

        #endregion

        private Label bottomLabel;
        private Label topLabel;
    }
}