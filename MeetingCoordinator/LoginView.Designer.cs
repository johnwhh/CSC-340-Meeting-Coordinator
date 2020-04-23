namespace MeetingCoordinator
{
    partial class LoginView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(354, 146);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(96, 37);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(264, 295);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(328, 292);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(143, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(361, 328);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Location = new System.Drawing.Point(214, 408);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(373, 30);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Invalid username. Please make sure you enter your username correctly.";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginLabel);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}
