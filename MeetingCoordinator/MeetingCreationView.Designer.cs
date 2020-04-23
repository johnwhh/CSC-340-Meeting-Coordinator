namespace MeetingCoordinator
{
    partial class MeetingCreationView
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
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NewMeetingLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(38, 189);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(254, 130);
            this.DescriptionTextBox.TabIndex = 31;
            this.DescriptionTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(35, 173);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 30;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(40, 334);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(225, 120);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(45, 20);
            this.EndTimeTextBox.TabIndex = 26;
            this.EndTimeTextBox.Text = "23:00";
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(95, 121);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(45, 20);
            this.StartTimeTextBox.TabIndex = 25;
            this.StartTimeTextBox.Text = "22:00";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(71, 76);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(221, 20);
            this.TitleTextBox.TabIndex = 23;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(168, 124);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.EndTimeLabel.TabIndex = 21;
            this.EndTimeLabel.Text = "End time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(35, 123);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.StartTimeLabel.TabIndex = 20;
            this.StartTimeLabel.Text = "Start time:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(35, 79);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "Title:";
            // 
            // NewMeetingLabel
            // 
            this.NewMeetingLabel.AutoSize = true;
            this.NewMeetingLabel.Location = new System.Drawing.Point(127, 28);
            this.NewMeetingLabel.Name = "NewMeetingLabel";
            this.NewMeetingLabel.Size = new System.Drawing.Size(70, 13);
            this.NewMeetingLabel.TabIndex = 17;
            this.NewMeetingLabel.Text = "New Meeting";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(192, 334);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 23);
            this.NextButton.TabIndex = 32;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MeetingCreationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EndTimeTextBox);
            this.Controls.Add(this.StartTimeTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NewMeetingLabel);
            this.Name = "MeetingCreationView";
            this.Size = new System.Drawing.Size(324, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NewMeetingLabel;
        private System.Windows.Forms.Button NextButton;
    }
}
