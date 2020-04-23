namespace MeetingCoordinator
{
    partial class MeetingEditConfirmationView
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
            this.LocationListBox = new System.Windows.Forms.CheckedListBox();
            this.AttendeesListBox = new System.Windows.Forms.CheckedListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveMeetingButton = new System.Windows.Forms.Button();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.NewMeetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LocationListBox
            // 
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.Items.AddRange(new object[] {
            "Aidan Barbour",
            "Jeff Davidson",
            "Jack Holtzworth",
            "Jerry Jeremy"});
            this.LocationListBox.Location = new System.Drawing.Point(36, 66);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(254, 109);
            this.LocationListBox.TabIndex = 56;
            this.LocationListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LocationListBox_ItemCheck);
            // 
            // AttendeesListBox
            // 
            this.AttendeesListBox.FormattingEnabled = true;
            this.AttendeesListBox.Items.AddRange(new object[] {
            "Aidan Barbour",
            "Jeff Davidson",
            "Jack Holtzworth",
            "Jerry Jeremy"});
            this.AttendeesListBox.Location = new System.Drawing.Point(36, 201);
            this.AttendeesListBox.Name = "AttendeesListBox";
            this.AttendeesListBox.Size = new System.Drawing.Size(254, 124);
            this.AttendeesListBox.TabIndex = 55;
            this.AttendeesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AttendeesListBox_ItemCheck);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(36, 331);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 54;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveMeetingButton
            // 
            this.SaveMeetingButton.Enabled = false;
            this.SaveMeetingButton.Location = new System.Drawing.Point(190, 331);
            this.SaveMeetingButton.Name = "SaveMeetingButton";
            this.SaveMeetingButton.Size = new System.Drawing.Size(100, 23);
            this.SaveMeetingButton.TabIndex = 53;
            this.SaveMeetingButton.Text = "Save Meeting";
            this.SaveMeetingButton.UseVisualStyleBackColor = true;
            this.SaveMeetingButton.Click += new System.EventHandler(this.SaveMeetingButton_Click);
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Location = new System.Drawing.Point(33, 185);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(58, 13);
            this.AttendeesLabel.TabIndex = 52;
            this.AttendeesLabel.Text = "Attendees:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(33, 50);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 51;
            this.LocationLabel.Text = "Location:";
            // 
            // NewMeetingLabel
            // 
            this.NewMeetingLabel.Location = new System.Drawing.Point(36, 19);
            this.NewMeetingLabel.Name = "NewMeetingLabel";
            this.NewMeetingLabel.Size = new System.Drawing.Size(254, 13);
            this.NewMeetingLabel.TabIndex = 50;
            this.NewMeetingLabel.Text = "Meeting Title";
            this.NewMeetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeetingEditConfirmationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LocationListBox);
            this.Controls.Add(this.AttendeesListBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveMeetingButton);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.NewMeetingLabel);
            this.Name = "MeetingEditConfirmationView";
            this.Size = new System.Drawing.Size(320, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox LocationListBox;
        private System.Windows.Forms.CheckedListBox AttendeesListBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveMeetingButton;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label NewMeetingLabel;
    }
}
