namespace WorkoutSpecialist
{
    partial class MainForm
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
            label1 = new Label();
            dashboardBtn = new Button();
            workoutsBtn = new Button();
            addWoutBtn = new Button();
            editBtn = new Button();
            logoutBtn = new Button();
            mainPanel = new Panel();
            welcomeLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(28, 53);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "Nawigacja";
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = SystemColors.ActiveCaption;
            dashboardBtn.Location = new Point(28, 115);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(122, 23);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // workoutsBtn
            // 
            workoutsBtn.BackColor = Color.LightGoldenrodYellow;
            workoutsBtn.Location = new Point(28, 175);
            workoutsBtn.Name = "workoutsBtn";
            workoutsBtn.Size = new Size(122, 23);
            workoutsBtn.TabIndex = 2;
            workoutsBtn.Text = "Twoje treningi";
            workoutsBtn.UseVisualStyleBackColor = false;
            workoutsBtn.Click += workoutsBtn_Click;
            // 
            // addWoutBtn
            // 
            addWoutBtn.BackColor = Color.MediumPurple;
            addWoutBtn.Location = new Point(28, 233);
            addWoutBtn.Name = "addWoutBtn";
            addWoutBtn.Size = new Size(122, 23);
            addWoutBtn.TabIndex = 3;
            addWoutBtn.Text = "Dodaj trening";
            addWoutBtn.UseVisualStyleBackColor = false;
            addWoutBtn.Click += addWoutBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Chocolate;
            editBtn.Location = new Point(28, 295);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(122, 23);
            editBtn.TabIndex = 4;
            editBtn.Text = "Edytuj konto";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Red;
            logoutBtn.Location = new Point(28, 352);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(122, 23);
            logoutBtn.TabIndex = 5;
            logoutBtn.Text = "Wyloguj się";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(209, 53);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(520, 322);
            mainPanel.TabIndex = 6;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            welcomeLabel.Location = new Point(28, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(65, 25);
            welcomeLabel.TabIndex = 7;
            welcomeLabel.Text = "Witaj, ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(welcomeLabel);
            Controls.Add(mainPanel);
            Controls.Add(logoutBtn);
            Controls.Add(editBtn);
            Controls.Add(addWoutBtn);
            Controls.Add(workoutsBtn);
            Controls.Add(dashboardBtn);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button dashboardBtn;
        private Button workoutsBtn;
        private Button addWoutBtn;
        private Button editBtn;
        private Button logoutBtn;
        private Panel mainPanel;
        private Label welcomeLabel;
    }
}