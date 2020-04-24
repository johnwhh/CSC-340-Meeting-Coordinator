using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class MeetingCreationConfirmationView : UserControl
    {
        private MainForm parentForm;
        private Meeting currentMeeting;
        private MeetingManager meetingManager;

        private bool isLocationSelected = false;
        private bool isAttendeeSelected = false;

        public MeetingCreationConfirmationView(MainForm parent, Meeting meeting)
        {
            parentForm = parent;
            currentMeeting = meeting;
            meetingManager = new MeetingManager();
            InitializeComponent();
            NewMeetingLabel.Text = meeting.title;
        }

        private void CreateMeetingButton_Click(object sender, EventArgs e)
        {
            string title = currentMeeting.title;
            string location = GetLocation();
            string startTime = currentMeeting.startTime;
            string endTime = currentMeeting.endTime;
            string attendees = GetAttendees();
            string description = currentMeeting.description;

            Meeting newMeeting = new Meeting(title, location, startTime, endTime, attendees, description, currentMeeting.date);
            meetingManager.InsertMeeting(newMeeting, parentForm.GetSelectedDate(), parentForm);

            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        public void PopulateAttendeesListBox()
        {
            string[] fullNames = meetingManager.GetAvailableEmployeeNames(currentMeeting, parentForm.GetSelectedDate());

            AttendeesListBox.Items.Clear();
            foreach (string fullName in fullNames)
            {
                AttendeesListBox.Items.Add(fullName, false);
            }

            AttendeesListBox.CheckOnClick = true;
        }

        public void PopulateRoomsListBox()
        {
            string[] fullNames = meetingManager.GetAvailableRoomNames(currentMeeting, parentForm.GetSelectedDate());

            LocationListBox.Items.Clear();
            foreach (string fullName in fullNames)
            {
                LocationListBox.Items.Add(fullName, false);
            }

            LocationListBox.CheckOnClick = true;
        }

        private string GetAttendees()
        {
            string fullNames = "";
            CheckedListBox.CheckedItemCollection checkedItems = AttendeesListBox.CheckedItems;
            for (int i = 0; i < checkedItems.Count; i++)
            {
                fullNames += checkedItems[i].ToString();

                if(i < checkedItems.Count - 1)
                {
                    fullNames += ", ";
                }
            }
            return fullNames;
        }

        private string GetLocation()
        {
            CheckedListBox.CheckedItemCollection checkedItems = LocationListBox.CheckedItems;
            if (checkedItems.Count == 0)
                return null;

            return checkedItems[0].ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        private void LocationListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < LocationListBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    LocationListBox.SetItemChecked(i, false);
                }
            }
            isLocationSelected = e.NewValue == CheckState.Checked;
            UpdateCreateMeetingButton();
        }

        private void AttendeesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            isAttendeeSelected = (e.NewValue == CheckState.Checked || AttendeesListBox.CheckedItems.Count > 1);
            UpdateCreateMeetingButton();
        }

        private void UpdateCreateMeetingButton()
        {
            CreateMeetingButton.Enabled = isLocationSelected && isAttendeeSelected;
        }
    }
}
