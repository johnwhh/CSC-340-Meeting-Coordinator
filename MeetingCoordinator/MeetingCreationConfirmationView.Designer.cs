namespace MeetingCoordinator
{
    partial class MeetingCreationConfirmationView
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
            this.AttendeesListBox = new System.Windows.Forms.CheckedListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateMeetingButton = new System.Windows.Forms.Button();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.NewMeetingLabel = new System.Windows.Forms.Label();
            this.LocationListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // AttendeesListBox
            // 
            this.AttendeesListBox.FormattingEnabled = true;
            this.AttendeesListBox.Items.AddRange(new object[] {
            "Aidan Barbour",
            "Jeff Davidson",
            "Jack Holtzworth",
            "Jerry Jeremy"});
            this.AttendeesListBox.Location = new System.Drawing.Point(37, 202);
            this.AttendeesListBox.Name = "AttendeesListBox";
            this.AttendeesListBox.Size = new System.Drawing.Size(254, 124);
            this.AttendeesListBox.TabIndex = 48;
            this.AttendeesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AttendeesListBox_ItemCheck);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(37, 332);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 45;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateMeetingButton
            // 
            this.CreateMeetingButton.Enabled = false;
            this.CreateMeetingButton.Location = new System.Drawing.Point(191, 332);
            this.CreateMeetingButton.Name = "CreateMeetingButton";
            this.CreateMeetingButton.Size = new System.Drawing.Size(100, 23);
            this.CreateMeetingButton.TabIndex = 44;
            this.CreateMeetingButton.Text = "Create Meeting";
            this.CreateMeetingButton.UseVisualStyleBackColor = true;
            this.CreateMeetingButton.Click += new System.EventHandler(this.CreateMeetingButton_Click);
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Location = new System.Drawing.Point(34, 186);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(58, 13);
            this.AttendeesLabel.TabIndex = 38;
            this.AttendeesLabel.Text = "Attendees:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(34, 51);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 35;
            this.LocationLabel.Text = "Location:";
            // 
            // NewMeetingLabel
            // 
            this.NewMeetingLabel.Location = new System.Drawing.Point(37, 20);
            this.NewMeetingLabel.Name = "NewMeetingLabel";
            this.NewMeetingLabel.Size = new System.Drawing.Size(254, 13);
            this.NewMeetingLabel.TabIndex = 33;
            this.NewMeetingLabel.Text = "New Meeting";
            this.NewMeetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationListBox
            // 
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.Items.AddRange(new object[] {
            "Aidan Barbour",
            "Jeff Davidson",
            "Jack Holtzworth",
            "Jerry Jeremy"});
            this.LocationListBox.Location = new System.Drawing.Point(37, 67);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(254, 109);
            this.LocationListBox.TabIndex = 49;
            this.LocationListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LocationListBox_ItemCheck);
            // 
            // MeetingCreationConfirmationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LocationListBox);
            this.Controls.Add(this.AttendeesListBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateMeetingButton);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.NewMeetingLabel);
            this.Name = "MeetingCreationConfirmationView";
            this.Size = new System.Drawing.Size(322, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AttendeesListBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateMeetingButton;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label NewMeetingLabel;
        private System.Windows.Forms.CheckedListBox LocationListBox;
    }
}
