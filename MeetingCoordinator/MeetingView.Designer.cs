namespace MeetingCoordinator
{
    partial class MeetingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingView));
            this.NewDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NewEndTimeLabel = new System.Windows.Forms.Label();
            this.NewStartTimeLabel = new System.Windows.Forms.Label();
            this.NewLocationLabel = new System.Windows.Forms.Label();
            this.NewTitleLabel = new System.Windows.Forms.Label();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewAttendeesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewDescriptionTextBox
            // 
            this.NewDescriptionTextBox.Location = new System.Drawing.Point(20, 221);
            this.NewDescriptionTextBox.Multiline = true;
            this.NewDescriptionTextBox.Name = "NewDescriptionTextBox";
            this.NewDescriptionTextBox.ReadOnly = true;
            this.NewDescriptionTextBox.Size = new System.Drawing.Size(204, 80);
            this.NewDescriptionTextBox.TabIndex = 33;
            this.NewDescriptionTextBox.Text = resources.GetString("NewDescriptionTextBox.Text");
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(17, 205);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 32;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NewEndTimeLabel
            // 
            this.NewEndTimeLabel.AutoSize = true;
            this.NewEndTimeLabel.Location = new System.Drawing.Point(75, 109);
            this.NewEndTimeLabel.Name = "NewEndTimeLabel";
            this.NewEndTimeLabel.Size = new System.Drawing.Size(45, 13);
            this.NewEndTimeLabel.TabIndex = 30;
            this.NewEndTimeLabel.Text = "1:00 pm";
            // 
            // NewStartTimeLabel
            // 
            this.NewStartTimeLabel.AutoSize = true;
            this.NewStartTimeLabel.Location = new System.Drawing.Point(74, 82);
            this.NewStartTimeLabel.Name = "NewStartTimeLabel";
            this.NewStartTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.NewStartTimeLabel.TabIndex = 29;
            this.NewStartTimeLabel.Text = "12:00 pm";
            // 
            // NewLocationLabel
            // 
            this.NewLocationLabel.AutoSize = true;
            this.NewLocationLabel.Location = new System.Drawing.Point(74, 53);
            this.NewLocationLabel.Name = "NewLocationLabel";
            this.NewLocationLabel.Size = new System.Drawing.Size(167, 13);
            this.NewLocationLabel.TabIndex = 28;
            this.NewLocationLabel.Text = "McKinley\'s, Downtown Shelbyville";
            // 
            // NewTitleLabel
            // 
            this.NewTitleLabel.Location = new System.Drawing.Point(5, 13);
            this.NewTitleLabel.Name = "NewTitleLabel";
            this.NewTitleLabel.Size = new System.Drawing.Size(236, 13);
            this.NewTitleLabel.TabIndex = 27;
            this.NewTitleLabel.Text = "Lunch";
            this.NewTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Location = new System.Drawing.Point(17, 133);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(58, 13);
            this.AttendeesLabel.TabIndex = 26;
            this.AttendeesLabel.Text = "Attendees:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(17, 109);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.EndTimeLabel.TabIndex = 25;
            this.EndTimeLabel.Text = "End time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(17, 82);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.StartTimeLabel.TabIndex = 24;
            this.StartTimeLabel.Text = "Start time:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(17, 53);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 23;
            this.LocationLabel.Text = "Location:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(44, 307);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 22;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(125, 307);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewAttendeesTextBox
            // 
            this.NewAttendeesTextBox.Location = new System.Drawing.Point(20, 149);
            this.NewAttendeesTextBox.Multiline = true;
            this.NewAttendeesTextBox.Name = "NewAttendeesTextBox";
            this.NewAttendeesTextBox.ReadOnly = true;
            this.NewAttendeesTextBox.Size = new System.Drawing.Size(205, 53);
            this.NewAttendeesTextBox.TabIndex = 34;
            this.NewAttendeesTextBox.Text = resources.GetString("NewAttendeesTextBox.Text");
            // 
            // MeetingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.NewAttendeesTextBox);
            this.Controls.Add(this.NewDescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NewEndTimeLabel);
            this.Controls.Add(this.NewStartTimeLabel);
            this.Controls.Add(this.NewLocationLabel);
            this.Controls.Add(this.NewTitleLabel);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Name = "MeetingView";
            this.Size = new System.Drawing.Size(242, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewDescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NewEndTimeLabel;
        private System.Windows.Forms.Label NewStartTimeLabel;
        private System.Windows.Forms.Label NewLocationLabel;
        private System.Windows.Forms.Label NewTitleLabel;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NewAttendeesTextBox;
    }
}
