namespace LoginRegisterV2
{
    partial class SuperAdmin
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
            labelWelcomeSuperAdmin = new Label();
            labelHelloSuperAdmin = new Label();
            buttonLogOutSuperAdmin = new Button();
            SuspendLayout();
            // 
            // labelWelcomeSuperAdmin
            // 
            labelWelcomeSuperAdmin.AutoSize = true;
            labelWelcomeSuperAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeSuperAdmin.Location = new Point(75, 147);
            labelWelcomeSuperAdmin.Name = "labelWelcomeSuperAdmin";
            labelWelcomeSuperAdmin.Size = new Size(103, 30);
            labelWelcomeSuperAdmin.TabIndex = 6;
            labelWelcomeSuperAdmin.Text = "Welcome";
            // 
            // labelHelloSuperAdmin
            // 
            labelHelloSuperAdmin.AutoSize = true;
            labelHelloSuperAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHelloSuperAdmin.Location = new Point(75, 94);
            labelHelloSuperAdmin.Name = "labelHelloSuperAdmin";
            labelHelloSuperAdmin.Size = new Size(78, 30);
            labelHelloSuperAdmin.TabIndex = 5;
            labelHelloSuperAdmin.Text = "Hello! ";
            // 
            // buttonLogOutSuperAdmin
            // 
            buttonLogOutSuperAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOutSuperAdmin.Location = new Point(142, 288);
            buttonLogOutSuperAdmin.Name = "buttonLogOutSuperAdmin";
            buttonLogOutSuperAdmin.Size = new Size(162, 63);
            buttonLogOutSuperAdmin.TabIndex = 4;
            buttonLogOutSuperAdmin.Text = "Log Out";
            buttonLogOutSuperAdmin.UseVisualStyleBackColor = true;
            buttonLogOutSuperAdmin.Click += buttonLogOutSuperAdmin_Click;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(labelWelcomeSuperAdmin);
            Controls.Add(labelHelloSuperAdmin);
            Controls.Add(buttonLogOutSuperAdmin);
            Name = "SuperAdmin";
            Text = "SuperAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcomeSuperAdmin;
        private Label labelHelloSuperAdmin;
        private Button buttonLogOutSuperAdmin;
    }
}