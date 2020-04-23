using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class MeetingCreationView : UserControl
    {
        private MainForm parentForm;
        public MeetingCreationView(MainForm parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string startTime = StartTimeTextBox.Text;
            string endTime = EndTimeTextBox.Text;
            string description = DescriptionTextBox.Text;

            Meeting newMeeting = new Meeting(title, null, startTime, endTime, null, description);
            
            MeetingCreationConfirmationView meetingCreationConfirmationView = new MeetingCreationConfirmationView(parentForm, newMeeting);
            meetingCreationConfirmationView.PopulateAttendeesListBox();
            meetingCreationConfirmationView.PopulateRoomsListBox();

            parentForm.AddCenteredControl(meetingCreationConfirmationView);
            parentForm.Controls.Remove(this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }
    }
}
