﻿using System;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class MeetingEditConfirmationView : UserControl
    {
        private MainForm parentForm;
        private Meeting oldMeeting;
        private Meeting currentMeeting;
        private MeetingManager meetingManager;

        private bool isLocationSelected = false;
        private bool isAttendeeSelected = false;

        public MeetingEditConfirmationView(MainForm parent, Meeting newMeeting, Meeting oldMeeting)
        {
            parentForm = parent;
            this.oldMeeting = oldMeeting;
            currentMeeting = newMeeting;
            meetingManager = new MeetingManager();
            InitializeComponent();
            NewMeetingLabel.Text = newMeeting.title;
            UpdateCreateMeetingButton();
        }

        private void SaveMeetingButton_Click(object sender, EventArgs e)
        {
            string title = currentMeeting.title;
            string location = GetLocation();
            string startTime = currentMeeting.startTime;
            string endTime = currentMeeting.endTime;
            string attendees = GetAttendees();
            string description = currentMeeting.description;

            Meeting newMeeting = new Meeting(title, location, startTime, endTime, attendees, description, currentMeeting.date);

            MeetingManager meetingManager = new MeetingManager();
            meetingManager.UpdateMeeting(oldMeeting, newMeeting, parentForm.GetSelectedDate(), parentForm);
            parentForm.UpdateMeetingsPanel();

            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }

        public void PopulateAttendeesListBox()
        {
            string[] fullNames = meetingManager.GetAvailableEmployeeNames(currentMeeting, parentForm.GetSelectedDate(), oldMeeting);

            AttendeesListBox.Items.Clear();
            foreach (string fullName in fullNames)
            {
                if (oldMeeting.attendees.Contains(fullName))
                {
                    AttendeesListBox.Items.Add(fullName, true);
                    isAttendeeSelected = true;
                }
                else
                    AttendeesListBox.Items.Add(fullName, false);
            }

            AttendeesListBox.CheckOnClick = true;
        }

        public void PopulateRoomsListBox()
        {
            // Get people who are available among all meetings - oldMeeting
            string[] fullNames = meetingManager.GetAvailableRoomNames(currentMeeting, parentForm.GetSelectedDate(), oldMeeting);

            LocationListBox.Items.Clear();
            foreach (string fullName in fullNames)
            {
                if (fullName == oldMeeting.location)
                {
                    LocationListBox.Items.Add(fullName, true);
                    isLocationSelected = true;
                } else
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

                if (i < checkedItems.Count - 1)
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
            SaveMeetingButton.Enabled = isLocationSelected && isAttendeeSelected;
        }
    }
}
