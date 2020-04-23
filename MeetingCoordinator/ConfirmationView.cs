using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class ConfirmationView : UserControl
    {
        private MainForm parentForm;
        private Meeting currentMeeting;
        public ConfirmationView(MainForm parent, Meeting meeting)
        {
            parentForm = parent;
            currentMeeting = meeting;
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
            MeetingManager meetingManager = new MeetingManager();
            meetingManager.RemoveMeeting(currentMeeting, parentForm.GetSelectedDate());
            parentForm.UpdateMeetingsPanel();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }
    }
}
