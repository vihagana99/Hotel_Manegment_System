namespace Hotel_Manegment_Syatem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panelM = new Panel();
            employee = new Button();
            details = new Button();
            check_out = new Button();
            registration = new Button();
            add_room = new Button();
            panel2 = new Panel();
            cancel = new Button();
            minimize = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 121, 121);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panelM);
            panel1.Controls.Add(employee);
            panel1.Controls.Add(details);
            panel1.Controls.Add(check_out);
            panel1.Controls.Add(registration);
            panel1.Controls.Add(add_room);
            panel1.Location = new Point(29, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 110);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelM
            // 
            panelM.BackColor = Color.FromArgb(225, 192, 192);
            panelM.Location = new Point(49, 82);
            panelM.Name = "panelM";
            panelM.Size = new Size(160, 5);
            panelM.TabIndex = 5;
            // 
            // employee
            // 
            employee.BackColor = Color.FromArgb(203, 121, 121);
            employee.Cursor = Cursors.Hand;
            employee.FlatAppearance.BorderSize = 0;
            employee.FlatAppearance.MouseOverBackColor = Color.White;
            employee.FlatStyle = FlatStyle.Flat;
            employee.Font = new Font("Segoe UI", 11F);
            employee.Image = (Image)resources.GetObject("employee.Image");
            employee.Location = new Point(1038, 26);
            employee.Name = "employee";
            employee.Size = new Size(180, 50);
            employee.TabIndex = 4;
            employee.Text = "Employee";
            employee.TextAlign = ContentAlignment.MiddleRight;
            employee.TextImageRelation = TextImageRelation.ImageBeforeText;
            employee.UseVisualStyleBackColor = false;
            employee.Click += employee_Click;
            // 
            // details
            // 
            details.BackColor = Color.FromArgb(203, 121, 121);
            details.Cursor = Cursors.Hand;
            details.FlatAppearance.BorderSize = 0;
            details.FlatAppearance.MouseOverBackColor = Color.White;
            details.FlatStyle = FlatStyle.Flat;
            details.Font = new Font("Segoe UI", 11F);
            details.Image = (Image)resources.GetObject("details.Image");
            details.Location = new Point(773, 26);
            details.Name = "details";
            details.Size = new Size(200, 50);
            details.TabIndex = 3;
            details.Text = "Customer Details";
            details.TextAlign = ContentAlignment.MiddleRight;
            details.TextImageRelation = TextImageRelation.ImageBeforeText;
            details.UseVisualStyleBackColor = false;
            details.Click += details_Click;
            // 
            // check_out
            // 
            check_out.BackColor = Color.FromArgb(203, 121, 121);
            check_out.Cursor = Cursors.Hand;
            check_out.FlatAppearance.BorderSize = 0;
            check_out.FlatAppearance.MouseOverBackColor = Color.White;
            check_out.FlatStyle = FlatStyle.Flat;
            check_out.Font = new Font("Segoe UI", 11F);
            check_out.Image = (Image)resources.GetObject("check_out.Image");
            check_out.Location = new Point(546, 26);
            check_out.Name = "check_out";
            check_out.Size = new Size(160, 50);
            check_out.TabIndex = 2;
            check_out.Text = "Check Out";
            check_out.TextAlign = ContentAlignment.MiddleRight;
            check_out.TextImageRelation = TextImageRelation.ImageBeforeText;
            check_out.UseVisualStyleBackColor = false;
            check_out.Click += check_out_Click;
            // 
            // registration
            // 
            registration.BackColor = Color.FromArgb(203, 121, 121);
            registration.Cursor = Cursors.Hand;
            registration.FlatAppearance.BorderSize = 0;
            registration.FlatAppearance.MouseOverBackColor = Color.White;
            registration.FlatStyle = FlatStyle.Flat;
            registration.Font = new Font("Segoe UI", 11F);
            registration.Image = (Image)resources.GetObject("registration.Image");
            registration.Location = new Point(268, 26);
            registration.Name = "registration";
            registration.Size = new Size(220, 50);
            registration.TabIndex = 1;
            registration.Text = "Customer Registration ";
            registration.TextAlign = ContentAlignment.MiddleRight;
            registration.TextImageRelation = TextImageRelation.ImageBeforeText;
            registration.UseVisualStyleBackColor = false;
            registration.Click += registration_Click;
            // 
            // add_room
            // 
            add_room.BackColor = Color.FromArgb(203, 121, 121);
            add_room.Cursor = Cursors.Hand;
            add_room.FlatAppearance.BorderSize = 0;
            add_room.FlatAppearance.MouseOverBackColor = Color.White;
            add_room.FlatStyle = FlatStyle.Flat;
            add_room.Font = new Font("Segoe UI", 11F);
            add_room.Image = (Image)resources.GetObject("add_room.Image");
            add_room.Location = new Point(57, 26);
            add_room.Name = "add_room";
            add_room.Size = new Size(150, 50);
            add_room.TabIndex = 0;
            add_room.Text = "Add Room";
            add_room.TextAlign = ContentAlignment.MiddleRight;
            add_room.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_room.UseVisualStyleBackColor = false;
            add_room.Click += add_room_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(17, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(1330, 600);
            panel2.TabIndex = 1;
            // 
            // cancel
            // 
            cancel.FlatAppearance.BorderSize = 0;
            cancel.Image = (Image)resources.GetObject("cancel.Image");
            cancel.Location = new Point(1328, 12);
            cancel.Margin = new Padding(0);
            cancel.Name = "cancel";
            cancel.Size = new Size(25, 25);
            cancel.TabIndex = 15;
            cancel.Tag = "";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // minimize
            // 
            minimize.FlatAppearance.BorderSize = 0;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(1328, 51);
            minimize.Margin = new Padding(0);
            minimize.Name = "minimize";
            minimize.Size = new Size(25, 25);
            minimize.TabIndex = 16;
            minimize.Tag = "";
            minimize.UseVisualStyleBackColor = true;
            minimize.Click += minimize_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 121, 121);
            ClientSize = new Size(1366, 768);
            Controls.Add(minimize);
            Controls.Add(cancel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button cancel;
        private Button minimize;
        private Button add_room;
        private Button registration;
        private Button details;
        private Button check_out;
        private Button employee;
        private Panel panelM;
    }
}