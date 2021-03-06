﻿namespace MeetingCoordinator
{
    partial class MeetingEditView
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
            this.NextButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(190, 328);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 23);
            this.NextButton.TabIndex = 43;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(36, 183);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(254, 130);
            this.DescriptionTextBox.TabIndex = 42;
            this.DescriptionTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(33, 167);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 41;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(38, 328);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 40;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(223, 114);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(45, 20);
            this.EndTimeTextBox.TabIndex = 39;
            this.EndTimeTextBox.Text = "23:00";
            this.EndTimeTextBox.TextChanged += new System.EventHandler(this.EndTimeTextBox_TextChanged);
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(93, 115);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(45, 20);
            this.StartTimeTextBox.TabIndex = 38;
            this.StartTimeTextBox.Text = "22:00";
            this.StartTimeTextBox.TextChanged += new System.EventHandler(this.StartTimeTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(69, 70);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(221, 20);
            this.TitleTextBox.TabIndex = 37;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(166, 118);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.EndTimeLabel.TabIndex = 36;
            this.EndTimeLabel.Text = "End time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(33, 117);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.StartTimeLabel.TabIndex = 35;
            this.StartTimeLabel.Text = "Start time:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(33, 73);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 34;
            this.TitleLabel.Text = "Title:";
            // 
            // NewMeetingLabel
            // 
            this.NewMeetingLabel.AutoSize = true;
            this.NewMeetingLabel.Location = new System.Drawing.Point(125, 22);
            this.NewMeetingLabel.Name = "NewMeetingLabel";
            this.NewMeetingLabel.Size = new System.Drawing.Size(66, 13);
            this.NewMeetingLabel.TabIndex = 33;
            this.NewMeetingLabel.Text = "Edit Meeting";
            // 
            // MeetingEditView
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
            this.Name = "MeetingEditView";
            this.Size = new System.Drawing.Size(322, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
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
    }
}
