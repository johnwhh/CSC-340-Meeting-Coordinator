﻿using System;
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
            string date = parentForm.GetSelectedDate();

            Meeting newMeeting = new Meeting(title, null, startTime, endTime, null, description, date);
            
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

        private void StartTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNextButton();
        }

        private void EndTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNextButton();
        }

        private string[] SplitTime(string time)
        {
            if (!time.Contains(":"))
                return null;

            int colonIndex = time.IndexOf(':');
            string leftSide = time.Substring(0, colonIndex);
            string rightSide = time.Substring(colonIndex + 1);

            return new string[] { leftSide, rightSide };
        }

        private bool IsValidTime(string time)
        {
            string[] times = SplitTime(time);

            if (times == null)
                return false;

            string leftSide = times[0];
            string rightSide = times[1];

            if (leftSide.Length < 1 || leftSide.Length > 2)
                return false;

            if (rightSide.Length != 2)
                return false;

            int leftSideInt;
            if (int.TryParse(leftSide, out leftSideInt) == false)
                return false;

            int rightSideInt;
            if (int.TryParse(rightSide, out rightSideInt) == false)
                return false;

            if (leftSideInt < 0 || leftSideInt > 23)
                return false;

            if (rightSideInt < 0 || rightSideInt > 59)
                return false;

            return true;
        }

        private bool IsTimeLessThanOtherTime(string timeA, string timeB)
        {
            string[] timesA = SplitTime(timeA);
            int leftSideA = int.Parse(timesA[0]);
            int rightSideA = int.Parse(timesA[1]);

            string[] timesB = SplitTime(timeB);
            int leftSideB = int.Parse(timesB[0]);
            int rightSideB = int.Parse(timesB[1]);

            if (leftSideA > leftSideB)
                return false;

            if (rightSideA > rightSideB)
                return false;

            if (leftSideA == leftSideB && rightSideA == rightSideB)
                return false;

            return true;
        }

        private void UpdateNextButton()
        {
            string startTime = StartTimeTextBox.Text;
            string endTime = EndTimeTextBox.Text;
            bool areTimesValid = IsValidTime(startTime) && IsValidTime(endTime);

            if(areTimesValid)
            {
                if (IsTimeLessThanOtherTime(startTime, endTime))
                {
                    NextButton.Enabled = true;
                    return;
                }
            }

            NextButton.Enabled = false;
        }
    }
}
