namespace LoginRegisterV2
{
    partial class AdminPage
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
            labelWelcomeAdmin = new Label();
            labelHelloAdmin = new Label();
            buttonLogOutAdmin = new Button();
            SuspendLayout();
            // 
            // labelWelcomeAdmin
            // 
            labelWelcomeAdmin.AutoSize = true;
            labelWelcomeAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeAdmin.Location = new Point(89, 136);
            labelWelcomeAdmin.Name = "labelWelcomeAdmin";
            labelWelcomeAdmin.Size = new Size(103, 30);
            labelWelcomeAdmin.TabIndex = 6;
            labelWelcomeAdmin.Text = "Welcome";
            // 
            // labelHelloAdmin
            // 
            labelHelloAdmin.AutoSize = true;
            labelHelloAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHelloAdmin.Location = new Point(89, 83);
            labelHelloAdmin.Name = "labelHelloAdmin";
            labelHelloAdmin.Size = new Size(78, 30);
            labelHelloAdmin.TabIndex = 5;
            labelHelloAdmin.Text = "Hello! ";
            // 
            // buttonLogOutAdmin
            // 
            buttonLogOutAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOutAdmin.Location = new Point(156, 277);
            buttonLogOutAdmin.Name = "buttonLogOutAdmin";
            buttonLogOutAdmin.Size = new Size(162, 63);
            buttonLogOutAdmin.TabIndex = 4;
            buttonLogOutAdmin.Text = "Log Out";
            buttonLogOutAdmin.UseVisualStyleBackColor = true;
            buttonLogOutAdmin.Click += buttonLogOutAdmin_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(labelWelcomeAdmin);
            Controls.Add(labelHelloAdmin);
            Controls.Add(buttonLogOutAdmin);
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcomeAdmin;
        private Label labelHelloAdmin;
        private Button buttonLogOutAdmin;
    }
}