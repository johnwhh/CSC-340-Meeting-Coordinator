using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class MeetingView : UserControl
    {
        private MainForm parentForm;
        private Meeting currentMeeting;
        public MeetingView(MainForm parentForm, Meeting meeting)
        {
            this.parentForm = parentForm;

            InitializeComponent();

            if (parentForm.GetCurrentUser().rank != User.Rank.Manager)
            {
                HideButtons();
            }

            UpdateMeetingView(meeting);
        }

        public void UpdateMeetingView(Meeting meeting)
        {
            NewTitleLabel.Text = meeting.title;
            NewLocationLabel.Text = meeting.location;
            NewStartTimeLabel.Text = meeting.startTime;
            NewEndTimeLabel.Text = meeting.endTime;
            NewAttendeesTextBox.Text = meeting.attendees;
            NewDescriptionTextBox.Text = meeting.description;
            DateLabel.Text = meeting.date.Replace(" 12:00:00 AM", "");

            currentMeeting = meeting;
        }

        public void ToggleEditButton(bool state)
        {
            EditButton.Enabled = state;
        }

        public void ToggleDeleteButton(bool state)
        {
            DeleteButton.Enabled = state;
        }

        private void HideButtons()
        {
            EditButton.Visible = false;
            DeleteButton.Visible = false;
        }

        public void ToggleDate(bool state)
        {
            DateLabel.Visible = state;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConfirmationView confirmationView = new ConfirmationView(parentForm, currentMeeting);
            parentForm.ToggleButtons(false);
            parentForm.Controls.Add(confirmationView);
            confirmationView.Location = new Point(parentForm.Width / 2 - (confirmationView.Width / 2), parentForm.Height / 2 - (confirmationView.Height / 2));
            confirmationView.BringToFront();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MeetingEditView meetingEditView = new MeetingEditView(parentForm, currentMeeting);
            parentForm.ToggleButtons(false);
            parentForm.Controls.Add(meetingEditView);
            meetingEditView.Location = new Point(parentForm.Width / 2 - (meetingEditView.Width / 2), parentForm.Height / 2 - (meetingEditView.Height / 2));
            meetingEditView.BringToFront();
        }
    }
}
