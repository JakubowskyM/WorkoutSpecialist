namespace WorkoutSpecialist
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            loginBox = new TextBox();
            pswdBox = new TextBox();
            emailBox = new TextBox();
            repPswdBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rgrErrLabel = new Label();
            rgrBtn = new Button();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(345, 57);
            label4.Name = "label4";
            label4.Size = new Size(225, 65);
            label4.TabIndex = 11;
            label4.Text = "Specialist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(345, 12);
            label3.Name = "label3";
            label3.Size = new Size(143, 45);
            label3.TabIndex = 10;
            label3.Text = "Workout";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(293, 148);
            label1.Name = "label1";
            label1.Size = new Size(171, 45);
            label1.TabIndex = 12;
            label1.Text = "Rejestracja";
            label1.Click += label1_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(293, 229);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(171, 23);
            loginBox.TabIndex = 13;
            // 
            // pswdBox
            // 
            pswdBox.Location = new Point(293, 337);
            pswdBox.Name = "pswdBox";
            pswdBox.PasswordChar = '*';
            pswdBox.Size = new Size(171, 23);
            pswdBox.TabIndex = 14;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(293, 284);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(171, 23);
            emailBox.TabIndex = 15;
            // 
            // repPswdBox
            // 
            repPswdBox.Location = new Point(293, 391);
            repPswdBox.Name = "repPswdBox";
            repPswdBox.PasswordChar = '*';
            repPswdBox.Size = new Size(171, 23);
            repPswdBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 211);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 17;
            label2.Text = "Podaj login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 266);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 18;
            label5.Text = "Podaj e-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 319);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 19;
            label6.Text = "Podaj hasło";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 373);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 20;
            label7.Text = "Powtórz hasło";
            // 
            // rgrErrLabel
            // 
            rgrErrLabel.AutoSize = true;
            rgrErrLabel.ForeColor = Color.Red;
            rgrErrLabel.Location = new Point(293, 426);
            rgrErrLabel.Name = "rgrErrLabel";
            rgrErrLabel.Size = new Size(0, 15);
            rgrErrLabel.TabIndex = 21;
            rgrErrLabel.Click += rgrErrLabel_Click;
            // 
            // rgrBtn
            // 
            rgrBtn.Location = new Point(304, 455);
            rgrBtn.Name = "rgrBtn";
            rgrBtn.Size = new Size(151, 23);
            rgrBtn.TabIndex = 22;
            rgrBtn.Text = "Zakładam konto ->";
            rgrBtn.UseVisualStyleBackColor = true;
            rgrBtn.Click += rgrBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(304, 484);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(151, 23);
            backBtn.TabIndex = 23;
            backBtn.Text = "<- Powrót do logowania";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(backBtn);
            Controls.Add(rgrBtn);
            Controls.Add(rgrErrLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(repPswdBox);
            Controls.Add(emailBox);
            Controls.Add(pswdBox);
            Controls.Add(loginBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox loginBox;
        private TextBox pswdBox;
        private TextBox emailBox;
        private TextBox repPswdBox;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label rgrErrLabel;
        private Button rgrBtn;
        private Button backBtn;
    }
}