namespace MeetingCoordinator
{
    public class User
    {
        public enum Rank : int
        {
            Manager = 0,
            Employee = 1,
            ConferenceRoom = 2
        }

        public string fullName;
        public string username;
        public Rank rank;

        public User(string fullName, string username, Rank rank)
        {
            this.fullName = fullName;
            this.username = username;
            this.rank = rank;
        }
    }
}
