namespace MeetingCoordinator
{
    partial class MainForm
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
            this.MonthlyMeetingsButton = new System.Windows.Forms.Button();
            this.MeetingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddMeetingButton = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // MonthlyMeetingsButton
            // 
            this.MonthlyMeetingsButton.Location = new System.Drawing.Point(519, 148);
            this.MonthlyMeetingsButton.Name = "MonthlyMeetingsButton";
            this.MonthlyMeetingsButton.Size = new System.Drawing.Size(152, 23);
            this.MonthlyMeetingsButton.TabIndex = 9;
            this.MonthlyMeetingsButton.Text = "View Monthly Meetings";
            this.MonthlyMeetingsButton.UseVisualStyleBackColor = true;
            this.MonthlyMeetingsButton.Click += new System.EventHandler(this.MonthlyMeetingsButton_Click);
            // 
            // MeetingsPanel
            // 
            this.MeetingsPanel.AutoScroll = true;
            this.MeetingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeetingsPanel.Location = new System.Drawing.Point(12, 183);
            this.MeetingsPanel.Name = "MeetingsPanel";
            this.MeetingsPanel.Size = new System.Drawing.Size(760, 368);
            this.MeetingsPanel.TabIndex = 8;
            this.MeetingsPanel.WrapContents = false;
            // 
            // AddMeetingButton
            // 
            this.AddMeetingButton.Location = new System.Drawing.Point(116, 148);
            this.AddMeetingButton.Name = "AddMeetingButton";
            this.AddMeetingButton.Size = new System.Drawing.Size(152, 23);
            this.AddMeetingButton.TabIndex = 7;
            this.AddMeetingButton.Text = "Add Meeting";
            this.AddMeetingButton.UseVisualStyleBackColor = true;
            this.AddMeetingButton.Click += new System.EventHandler(this.AddMeetingButton_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(280, 9);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 6;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MonthlyMeetingsButton);
            this.Controls.Add(this.MeetingsPanel);
            this.Controls.Add(this.AddMeetingButton);
            this.Controls.Add(this.Calendar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Meeting Coordinator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MonthlyMeetingsButton;
        private System.Windows.Forms.FlowLayoutPanel MeetingsPanel;
        private System.Windows.Forms.Button AddMeetingButton;
        private System.Windows.Forms.MonthCalendar Calendar;
    }
}