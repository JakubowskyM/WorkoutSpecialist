namespace WorkoutSpecialist.Controls
{
    partial class DashboardControl
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
            totalKgLabel = new Label();
            firstWorkoutDateLabel = new Label();
            SuspendLayout();
            // 
            // totalKgLabel
            // 
            totalKgLabel.AutoSize = true;
            totalKgLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            totalKgLabel.ForeColor = Color.FromArgb(0, 192, 0);
            totalKgLabel.Location = new Point(20, 67);
            totalKgLabel.Name = "totalKgLabel";
            totalKgLabel.Size = new Size(83, 32);
            totalKgLabel.TabIndex = 0;
            totalKgLabel.Text = "label1";
            totalKgLabel.Click += totalKgLabel_Click;
            // 
            // firstWorkoutDateLabel
            // 
            firstWorkoutDateLabel.AutoSize = true;
            firstWorkoutDateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            firstWorkoutDateLabel.ForeColor = Color.DeepSkyBlue;
            firstWorkoutDateLabel.Location = new Point(20, 18);
            firstWorkoutDateLabel.Name = "firstWorkoutDateLabel";
            firstWorkoutDateLabel.Size = new Size(83, 32);
            firstWorkoutDateLabel.TabIndex = 1;
            firstWorkoutDateLabel.Text = "label1";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(firstWorkoutDateLabel);
            Controls.Add(totalKgLabel);
            Name = "DashboardControl";
            Size = new Size(520, 322);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalKgLabel;
        private Label firstWorkoutDateLabel;
    }
}