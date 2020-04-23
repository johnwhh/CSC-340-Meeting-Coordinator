namespace MeetingCoordinator
{
    partial class ConfirmationView
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
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(108, 66);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 5;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(27, 66);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 4;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(3, 15);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(211, 13);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Are you sure you want to delete this event?";
            // 
            // ConfirmationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "ConfirmationView";
            this.Size = new System.Drawing.Size(214, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label QuestionLabel;
    }
}
