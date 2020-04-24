using System;
namespace MeetingCoordinator
{
    public class Meeting
    {
        public string title;
        public string location;
        public string startTime;
        public string endTime;
        public string attendees;
        public string description;
        public string date;

        public Meeting(string title, string location, string startTime, string endTime, string attendees, string description, string date)
        {
            this.title = title;
            this.location = location;
            this.startTime = startTime;
            this.endTime = endTime;
            this.attendees = attendees;
            this.description = description;
            this.date = date;
        }

        public bool Equals(Meeting otherMeeting)
        {
            return title == otherMeeting.title &&
                    location == otherMeeting.location &&
                    startTime == otherMeeting.startTime &&
                    endTime == otherMeeting.endTime &&
                    attendees == otherMeeting.attendees &&
                    description == otherMeeting.description &&
                    date == otherMeeting.date;
        }
    }
}
