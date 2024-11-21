namespace Hotel_Manegment_Syatem
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
            panel1 = new Panel();
            cancel = new Button();
            lebelwrong = new Label();
            btnlogin = new Button();
            username = new TextBox();
            password = new TextBox();
            pictureBox1 = new PictureBox();
            user_login = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancel);
            panel1.Controls.Add(lebelwrong);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(username);
            panel1.Controls.Add(password);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(user_login);
            panel1.Location = new Point(336, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 408);
            panel1.TabIndex = 0;
            // 
            // cancel
            // 
            cancel.FlatAppearance.BorderSize = 0;
            cancel.Image = (Image)resources.GetObject("cancel.Image");
            cancel.Location = new Point(658, 10);
            cancel.Margin = new Padding(0);
            cancel.Name = "cancel";
            cancel.Size = new Size(25, 25);
            cancel.TabIndex = 14;
            cancel.Tag = "";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // lebelwrong
            // 
            lebelwrong.AutoSize = true;
            lebelwrong.ForeColor = Color.DarkRed;
            lebelwrong.Location = new Point(367, 277);
            lebelwrong.Name = "lebelwrong";
            lebelwrong.Size = new Size(161, 15);
            lebelwrong.TabIndex = 13;
            lebelwrong.Text = "Wrong , Usernae or Password";
            lebelwrong.TextAlign = ContentAlignment.TopCenter;
            lebelwrong.Visible = false;
            lebelwrong.Click += label1_Click_1;
            // 
            // btnlogin
            // 
            btnlogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderColor = Color.Gray;
            btnlogin.FlatAppearance.BorderSize = 5;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnlogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(401, 244);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(100, 30);
            btnlogin.TabIndex = 12;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button1_Click;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(359, 153);
            username.Margin = new Padding(40);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(180, 20);
            username.TabIndex = 11;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(359, 196);
            password.Margin = new Padding(10);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(180, 20);
            password.TabIndex = 10;
            password.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user_login
            // 
            user_login.AutoSize = true;
            user_login.Font = new Font("Viner Hand ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_login.Location = new Point(353, 86);
            user_login.Name = "user_login";
            user_login.Size = new Size(201, 57);
            user_login.TabIndex = 0;
            user_login.Text = "User Login";
            user_login.TextAlign = ContentAlignment.MiddleCenter;
            user_login.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label user_login;
        private PictureBox pictureBox1;
        private TextBox password;
        private Button btnlogin;
        private TextBox username;
        private Label lebelwrong;
        private Button cancel;
    }
}
