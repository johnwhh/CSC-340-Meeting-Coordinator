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

        public Meeting(string title, string location, string startTime, string endTime, string attendees, string description)
        {
            this.title = title;
            this.location = location;
            this.startTime = startTime;
            this.endTime = endTime;
            this.attendees = attendees;
            this.description = description;
        }
    }
}
