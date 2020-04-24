using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeetingCoordinator
{
    public partial class MainForm : Form
    {
        private bool isViewingMonthly = false;
        private User currentUser = null;
        public MainForm()
        {
            InitializeComponent();
            ShowLoginView();
        }

        public void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateMeetingsPanel();
        }

        public void UpdateMeetingsPanel()
        {
            if (!isViewingMonthly)
                ShowDailyMeetings();
            else
                ShowMonthlyMeetings();
        }

        private void ShowLoginView()
        {
            LoginView loginView = new LoginView(this);

            AddCenteredControl(loginView);
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
            ShowDailyMeetings();
            
            if(user.rank != User.Rank.Manager)
            {
                AddMeetingButton.Visible = false;
            }
        }

        public User GetCurrentUser()
        {
            return currentUser;
        }

        private void ShowDailyMeetings()
        {
            MeetingsPanel.Controls.Clear();

            string date = GetSelectedDate();

            MeetingManager meetingManager = new MeetingManager();
            Meeting[] meetings = currentUser.rank == User.Rank.Manager ? meetingManager.GetDailyMeetings(date) : meetingManager.GetDailyMeetingsForUser(currentUser, date);

            foreach (Meeting meeting in meetings)
            {
                AddMeeting(meeting);
            }
        }

        private void ShowMonthlyMeetings()
        {
            string month = Calendar.SelectionEnd.Month.ToString();
            string year = Calendar.SelectionEnd.Year.ToString();
            MeetingsPanel.Controls.Clear();

            MeetingManager meetingManager = new MeetingManager();
            Meeting[] meetings = currentUser.rank == User.Rank.Manager ? meetingManager.GetMonthlyMeetings(month, year) : meetingManager.GetMonthlyMeetingsForUser(currentUser, month, year);

            foreach (Meeting meeting in meetings)
            {
                AddMeeting(meeting, true);
            }
        }

        public string GetSelectedDate()
        {
            return Calendar.SelectionEnd.Year.ToString() + "-" + Calendar.SelectionEnd.Month.ToString() + "-" + Calendar.SelectionEnd.Day.ToString();
        }

        private void AddMeetingButton_Click(object sender, EventArgs e)
        {
            MeetingCreationView meetingCreationView = new MeetingCreationView(this);
            ToggleButtons(false);
            AddCenteredControl(meetingCreationView);
        }

        public void AddMeeting(Meeting meeting, bool isMonthly=false)
        {
            MeetingView newMeetingView = new MeetingView(this, meeting);

            if (isMonthly)
            {
                newMeetingView.ToggleDate(true);
                newMeetingView.ToggleEditButton(false);
            }

            MeetingsPanel.Controls.Add(newMeetingView);
        }

        private void MonthlyMeetingsButton_Click(object sender, EventArgs e)
        {
            isViewingMonthly = !isViewingMonthly;

            if (isViewingMonthly)
            {
                MonthlyMeetingsButton.Text = "View Daily Meetings";
                ShowMonthlyMeetings();
                AddMeetingButton.Enabled = false;
                ToggleEditButtons(false);
            }
            else
            {
                MonthlyMeetingsButton.Text = "View Monthly Meetings";
                ShowDailyMeetings();
                AddMeetingButton.Enabled = true;
                ToggleEditButtons(true);
            }

        }

        public void ToggleButtons(bool state)
        {
            AddMeetingButton.Enabled = state;
            MonthlyMeetingsButton.Enabled = state;
            Calendar.Enabled = state;

            foreach (Control control in MeetingsPanel.Controls)
            {
                MeetingView meetingView = control as MeetingView;

                meetingView.ToggleEditButton(state);
                meetingView.ToggleDeleteButton(state);
            }
        }

        public void ToggleEditButtons(bool state)
        {
            foreach (Control control in MeetingsPanel.Controls)
            {
                MeetingView meetingView = control as MeetingView;

                meetingView.ToggleEditButton(state);
            }
        }

        public void AddCenteredControl(Control control)
        {
            Controls.Add(control);
            control.Location = new Point(Width / 2 - (control.Width / 2), Height / 2 - (control.Height / 2));
            control.BringToFront();
        }
    }
}
