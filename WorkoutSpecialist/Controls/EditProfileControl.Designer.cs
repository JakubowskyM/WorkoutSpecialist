namespace WorkoutSpecialist.Controls
{
    partial class EditProfileControl
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            loginTextBox = new TextBox();
            mailTextBox = new TextBox();
            changeLoginBtn = new Button();
            changeMailBtn = new Button();
            changePswdBtn = new Button();
            label5 = new Label();
            pswdTextBox = new TextBox();
            confirmPswdTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(136, 12);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 0;
            label1.Text = "Zarządzanie kontem";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 103);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Twoj login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 155);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Twój email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 197);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(136, 95);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(204, 23);
            loginTextBox.TabIndex = 4;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // mailTextBox
            // 
            mailTextBox.Location = new Point(136, 147);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(204, 23);
            mailTextBox.TabIndex = 5;
            mailTextBox.TextChanged += pswdTextBox_TextChanged;
            // 
            // changeLoginBtn
            // 
            changeLoginBtn.BackColor = SystemColors.ActiveCaption;
            changeLoginBtn.Location = new Point(366, 99);
            changeLoginBtn.Name = "changeLoginBtn";
            changeLoginBtn.Size = new Size(99, 23);
            changeLoginBtn.TabIndex = 6;
            changeLoginBtn.Text = "Zmien login";
            changeLoginBtn.UseVisualStyleBackColor = false;
            changeLoginBtn.Click += changeLoginBtn_Click;
            // 
            // changeMailBtn
            // 
            changeMailBtn.BackColor = SystemColors.ActiveCaption;
            changeMailBtn.Location = new Point(366, 147);
            changeMailBtn.Name = "changeMailBtn";
            changeMailBtn.Size = new Size(99, 23);
            changeMailBtn.TabIndex = 7;
            changeMailBtn.Text = "Zmien email";
            changeMailBtn.UseVisualStyleBackColor = false;
            changeMailBtn.Click += changeMailBtn_Click;
            // 
            // changePswdBtn
            // 
            changePswdBtn.BackColor = Color.DarkOrange;
            changePswdBtn.Location = new Point(366, 244);
            changePswdBtn.Name = "changePswdBtn";
            changePswdBtn.Size = new Size(99, 23);
            changePswdBtn.TabIndex = 8;
            changePswdBtn.Text = "Zmien haslo";
            changePswdBtn.UseVisualStyleBackColor = false;
            changePswdBtn.Click += changePswdBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(175, 182);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 9;
            label5.Text = "Zmiana hasła";
            // 
            // pswdTextBox
            // 
            pswdTextBox.Location = new Point(175, 205);
            pswdTextBox.Name = "pswdTextBox";
            pswdTextBox.PasswordChar = '*';
            pswdTextBox.Size = new Size(165, 23);
            pswdTextBox.TabIndex = 10;
            pswdTextBox.TextChanged += pswdTextBox_TextChanged_1;
            // 
            // confirmPswdTextBox
            // 
            confirmPswdTextBox.Location = new Point(175, 244);
            confirmPswdTextBox.Name = "confirmPswdTextBox";
            confirmPswdTextBox.PasswordChar = '*';
            confirmPswdTextBox.Size = new Size(165, 23);
            confirmPswdTextBox.TabIndex = 11;
            confirmPswdTextBox.TextChanged += confirmPswdTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 208);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 12;
            label6.Text = "Wpisz nowe hasło:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 247);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 13;
            label7.Text = "Potwierdź hasło:";
            // 
            // EditProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(confirmPswdTextBox);
            Controls.Add(pswdTextBox);
            Controls.Add(label5);
            Controls.Add(changePswdBtn);
            Controls.Add(changeMailBtn);
            Controls.Add(changeLoginBtn);
            Controls.Add(mailTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProfileControl";
            Size = new Size(520, 322);
            Load += EditProfileControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox loginTextBox;
        private TextBox mailTextBox;
        private Button changeLoginBtn;
        private Button changeMailBtn;
        private Button changePswdBtn;
        private Label label5;
        private TextBox pswdTextBox;
        private TextBox confirmPswdTextBox;
        private Label label6;
        private Label label7;
    }
}