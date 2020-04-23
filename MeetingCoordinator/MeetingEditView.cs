using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class MeetingEditView : UserControl
    {
        private MainForm parentForm;
        private Meeting currentMeeting;
        private Meeting oldMeeting;

        public MeetingEditView(MainForm parent, Meeting meeting)
        {
            parentForm = parent;
            currentMeeting = meeting;
            oldMeeting = meeting;
            InitializeComponent();
            TitleTextBox.Text = meeting.title;
            StartTimeTextBox.Text = meeting.startTime;
            EndTimeTextBox.Text = meeting.endTime;
            DescriptionTextBox.Text = meeting.description;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string startTime = StartTimeTextBox.Text;
            string endTime = EndTimeTextBox.Text;
            string description = DescriptionTextBox.Text;
            Meeting newMeeting = new Meeting(title, currentMeeting.location, startTime, endTime, currentMeeting.attendees, description);

            MeetingEditConfirmationView meetingEditConfirmationView = new MeetingEditConfirmationView(parentForm, newMeeting, oldMeeting);
            meetingEditConfirmationView.PopulateAttendeesListBox();
            meetingEditConfirmationView.PopulateRoomsListBox();
            
            parentForm.AddCenteredControl(meetingEditConfirmationView);
            parentForm.Controls.Remove(this);
        }
    }
}
