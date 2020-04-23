using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace MeetingCoordinator
{
    class MeetingManager
    {
        private const string connStr = "Put EKU Database details here.";
        public void InsertMeeting(Meeting newMeeting, string date, MainForm parentForm)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string statement = "INSERT INTO ajjmeetings (title, location, startTime, endTime, attendees, description, date) VALUES (@title, @location, @startTime, @endTime, @attendees, @description, @date);";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@title", newMeeting.title);
                cmd.Parameters.AddWithValue("@location", newMeeting.location);
                cmd.Parameters.AddWithValue("@startTime", newMeeting.startTime);
                cmd.Parameters.AddWithValue("@endTime", newMeeting.endTime);
                cmd.Parameters.AddWithValue("@attendees", newMeeting.attendees);
                cmd.Parameters.AddWithValue("@description", newMeeting.description);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                ShowError(parentForm, "The input was too long.");
                Console.WriteLine(ex.ToString());
                conn.Close();
                return;
            }
            conn.Close();

            parentForm.AddMeeting(newMeeting);
        }

        private void ShowError(MainForm parentForm, string description = null)
        {
            ErrorView errorView = new ErrorView(parentForm);
            if(description != null)
                errorView.SetDescriptionText(description);
            parentForm.Controls.Add(errorView);
            errorView.Location = new Point(parentForm.Width / 2 - (errorView.Width / 2), parentForm.Height / 2 - (errorView.Height / 2));
            errorView.BringToFront();
        }

        private float TimeToFloat(string time)
        {
            int colonIndex = time.IndexOf(':');
            int hour = Int32.Parse(time.Substring(0, colonIndex));
            int minutes = Int32.Parse(time.Substring(colonIndex + 1, 2));
            float fraction = (float)minutes / 60;
            return hour + fraction;
        }

        public void RemoveMeeting(Meeting meeting, string date)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string statement = "DELETE FROM ajjmeetings WHERE title = @title AND location = @location AND startTime = @startTime AND endTime = @endTime AND attendees = @attendees AND description = @description AND date = @date LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@title", meeting.title);
                cmd.Parameters.AddWithValue("@location", meeting.location);
                cmd.Parameters.AddWithValue("@startTime", meeting.startTime);
                cmd.Parameters.AddWithValue("@endTime", meeting.endTime);
                cmd.Parameters.AddWithValue("@attendees", meeting.attendees);
                cmd.Parameters.AddWithValue("@description", meeting.description);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        public void UpdateMeeting(Meeting oldMeeting, Meeting newMeeting, string date, MainForm parent)
        {
            RemoveMeeting(oldMeeting, date);
            InsertMeeting(newMeeting, date, parent);
        }

        private User[] GetAllUsers()
        {
            List<User> users = new List<User>();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM ajjusers WHERE rank != 2";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string fullName = row["fullName"].ToString();
                string username = row["username"].ToString();
                User.Rank rank = (User.Rank)(int)row["rank"];

                User user = new User(fullName, username, rank);
                users.Add(user);
            }
            table.Dispose();
            return users.ToArray();
        }

        private User[] GetAllRooms()
        {
            List<User> users = new List<User>();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM ajjusers WHERE rank = 2";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string fullName = row["fullName"].ToString();

                User user = new User(fullName, null, User.Rank.ConferenceRoom);
                users.Add(user);
            }
            table.Dispose();
            return users.ToArray();
        }

        public Meeting[] GetDailyMeetings(string date)
        {
            List<Meeting> meetings = new List<Meeting>();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM ajjmeetings WHERE date=@myDate";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@myDate", date);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string title = row["title"].ToString();
                string location = row["location"].ToString();
                string startTime = row["startTime"].ToString(); ;
                string endTime = row["endTime"].ToString(); ;
                string attendees = row["attendees"].ToString(); ;
                string description = row["description"].ToString(); ;
                Meeting meeting = new Meeting(title, location, startTime, endTime, attendees, description);
                meetings.Add(meeting);
            }
            table.Dispose();
            return meetings.ToArray();
        }

        public Meeting[] GetDailyMeetingsForUser(User user, string date)
        {
            List<Meeting> meetings = new List<Meeting>();

            foreach (Meeting meeting in GetDailyMeetings(date))
            {
                if (meeting.attendees.Contains(user.fullName))
                    meetings.Add(meeting);
            }

            return meetings.ToArray();
        }

        public Meeting[] GetMonthlyMeetings(string month, string year)
        {
            List<Meeting> meetings = new List<Meeting>();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM ajjmeetings WHERE MONTH(date) = @month AND YEAR(date) = @year";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string title = row["title"].ToString();
                string location = row["location"].ToString();
                string startTime = row["startTime"].ToString(); ;
                string endTime = row["endTime"].ToString(); ;
                string attendees = row["attendees"].ToString(); ;
                string description = row["description"].ToString(); ;
                Meeting meeting = new Meeting(title, location, startTime, endTime, attendees, description);
                meetings.Add(meeting);
            }
            table.Dispose();
            return meetings.ToArray();
        }

        public Meeting[] GetMonthlyMeetingsForUser(User user, string month, string year)
        {
            List<Meeting> meetings = new List<Meeting>();

            foreach (Meeting meeting in GetMonthlyMeetings(month, year))
            {
                if (meeting.attendees.Contains(user.fullName))
                    meetings.Add(meeting);
            }

            return meetings.ToArray();
        }

        public string[] GetAvailableEmployeeNames(Meeting meeting, string date)
        {
            User[] allUsers = GetAllUsers().ToArray();
            List<string> fullNames = new List<string>();

            foreach(User user in allUsers)
            {
                if (IsUserAvailable(user, meeting, date))
                    fullNames.Add(user.fullName);
            }

            return fullNames.ToArray();
        }

        public string[] GetAvailableRoomNames(Meeting meeting, string date)
        {
            User[] allUsers = GetAllRooms().ToArray();
            List<string> fullNames = new List<string>();

            foreach (User user in allUsers)
            {
                if (IsUserAvailable(user, meeting, date, true))
                    fullNames.Add(user.fullName);
            }

            return fullNames.ToArray();
        }

        private bool IsUserAvailable(User user, Meeting meeting, string date, bool isLocation = false) {
            string[] busyHours = GetBusyHours(user.fullName, date, isLocation);

            foreach (string busyHour in busyHours)
            {
                string[] times = busyHour.Split('-');
                float startTime = TimeToFloat(times[0]);
                float endTime = TimeToFloat(times[1]);

                bool startConflictExists = TimeToFloat(meeting.endTime) >= startTime && TimeToFloat(meeting.endTime) <= endTime;
                bool endConflictExists = TimeToFloat(meeting.startTime) <= endTime && TimeToFloat(meeting.startTime) >= startTime;
                if (startConflictExists || endConflictExists)
                    return false;
            }

            return true;
        }

        public string[] GetBusyHours(string fullName, string date, bool isLocation=false)
        {
            List<string> busyHours = new List<string>();
            Meeting[] meetings = GetDailyMeetings(date).ToArray();

            foreach(Meeting meeting in meetings)
            {
                if(isLocation)
                {
                    if (meeting.location == fullName)
                    {
                        busyHours.Add(meeting.startTime + "-" + meeting.endTime);
                    }
                } else {
                    if (meeting.attendees.Contains(fullName))
                    {
                        busyHours.Add(meeting.startTime + "-" + meeting.endTime);
                    }
                }
            }

            return busyHours.ToArray();
        }

        //public string GetMeetingConflictStatus(Meeting meeting, string date)
        //{
        //    string[] fullNames = meeting.attendees.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        //    foreach(string fullName in fullNames)
        //    {
        //        string[] busyHours = GetBusyHours(fullName, date).ToArray();

        //        foreach (string busyHour in busyHours)
        //        {
        //            string[] times = busyHour.Split('-');
        //            float startTime = TimeToFloat(times[0]);
        //            float endTime = TimeToFloat(times[1]);

        //            bool startConflictExists = TimeToFloat(meeting.endTime) >= startTime && TimeToFloat(meeting.endTime) <= endTime;
        //            bool endConflictExists = TimeToFloat(meeting.startTime) <= endTime && TimeToFloat(meeting.startTime) >= startTime;
        //            if (startConflictExists || endConflictExists)
        //                return fullName + " has a conflicting meeting.";
        //        }
        //    }

        //    string[] busyRoomHours = GetBusyHours(meeting.location, date, true).ToArray();

        //    foreach (string busyHour in busyRoomHours)
        //    {
        //        string[] times = busyHour.Split('-');
        //        float startTime = TimeToFloat(times[0]);
        //        float endTime = TimeToFloat(times[1]);

        //        bool startConflictExists = TimeToFloat(meeting.endTime) >= startTime && TimeToFloat(meeting.endTime) <= endTime;
        //        bool endConflictExists = TimeToFloat(meeting.startTime) <= endTime && TimeToFloat(meeting.startTime) >= startTime;
        //        if (startConflictExists || endConflictExists)
        //            return "There is already a meeting at " + meeting.location;
        //    }

        //    return null;
        //}
    }
}
