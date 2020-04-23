namespace MeetingCoordinator
{
    partial class ErrorView
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(36, 112);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 5;
            this.ContinueButton.Text = "OK";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(60, 15);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "Error";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(3, 31);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(142, 75);
            this.DescriptionTextBox.TabIndex = 6;
            this.DescriptionTextBox.Text = "There has been a time conflict";
            this.DescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.ErrorLabel);
            this.Name = "ErrorView";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
    }
}
