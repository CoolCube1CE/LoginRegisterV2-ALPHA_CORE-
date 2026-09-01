namespace LoginRegisterV2
{
    partial class SuccessfulLogin
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
            buttonLogOutUser = new Button();
            labelloggedInExit = new Label();
            labelWelcomeUser = new Label();
            labelHelloUser = new Label();
            SuspendLayout();
            // 
            // buttonLogOutUser
            // 
            buttonLogOutUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOutUser.Location = new Point(168, 313);
            buttonLogOutUser.Name = "buttonLogOutUser";
            buttonLogOutUser.Size = new Size(162, 63);
            buttonLogOutUser.TabIndex = 0;
            buttonLogOutUser.Text = "Log Out";
            buttonLogOutUser.UseVisualStyleBackColor = true;
            buttonLogOutUser.Click += buttonLogOut_Click;
            // 
            // labelloggedInExit
            // 
            labelloggedInExit.AutoSize = true;
            labelloggedInExit.Cursor = Cursors.Hand;
            labelloggedInExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelloggedInExit.Location = new Point(461, 23);
            labelloggedInExit.Name = "labelloggedInExit";
            labelloggedInExit.Size = new Size(20, 21);
            labelloggedInExit.TabIndex = 1;
            labelloggedInExit.Text = "X";
            labelloggedInExit.Click += labelloggedInExit_Click;
            // 
            // labelWelcomeUser
            // 
            labelWelcomeUser.AutoSize = true;
            labelWelcomeUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeUser.Location = new Point(101, 172);
            labelWelcomeUser.Name = "labelWelcomeUser";
            labelWelcomeUser.Size = new Size(103, 30);
            labelWelcomeUser.TabIndex = 3;
            labelWelcomeUser.Text = "Welcome";
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHelloUser.Location = new Point(101, 119);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(78, 30);
            labelHelloUser.TabIndex = 2;
            labelHelloUser.Text = "Hello! ";
            // 
            // SuccessfulLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(labelWelcomeUser);
            Controls.Add(labelHelloUser);
            Controls.Add(labelloggedInExit);
            Controls.Add(buttonLogOutUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuccessfulLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuccessfulLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogOutUser;
        private Label labelloggedInExit;
        private Label labelWelcomeUser;
        private Label labelHelloUser;
    }
}