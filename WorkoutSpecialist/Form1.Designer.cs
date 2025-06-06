namespace WorkoutSpecialist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            registerBtn = new Button();
            loginBtn = new Button();
            loginBox = new TextBox();
            pswdBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            lgnErrLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(277, 309);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(95, 23);
            registerBtn.TabIndex = 0;
            registerBtn.Text = "Zarejestruj się";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Location = new Point(431, 309);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Zaloguj się";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(277, 205);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(229, 23);
            loginBox.TabIndex = 2;
            // 
            // pswdBox
            // 
            pswdBox.Location = new Point(277, 261);
            pswdBox.Name = "pswdBox";
            pswdBox.PasswordChar = '*';
            pswdBox.Size = new Size(229, 23);
            pswdBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(277, 237);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 4;
            label1.Text = "Hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(277, 181);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 5;
            label2.Text = "Login:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 133);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(277, 61);
            label3.Name = "label3";
            label3.Size = new Size(143, 45);
            label3.TabIndex = 7;
            label3.Text = "Workout";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(277, 106);
            label4.Name = "label4";
            label4.Size = new Size(225, 65);
            label4.TabIndex = 8;
            label4.Text = "Specialist";
            // 
            // lgnErrLabel
            // 
            lgnErrLabel.AutoSize = true;
            lgnErrLabel.ForeColor = Color.Red;
            lgnErrLabel.Location = new Point(277, 287);
            lgnErrLabel.Name = "lgnErrLabel";
            lgnErrLabel.Size = new Size(0, 15);
            lgnErrLabel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lgnErrLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pswdBox);
            Controls.Add(loginBox);
            Controls.Add(loginBtn);
            Controls.Add(registerBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerBtn;
        private Button loginBtn;
        private TextBox loginBox;
        private TextBox pswdBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label lgnErrLabel;
    }
}
