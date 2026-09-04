using Tests.Models;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users_list = new List<User>();
            User user1 = new User
            {
                Name = "Test",
                Email = "Shashmichael8         ",
                Id = "333456789"
            };
            users_list.Add(user1);
            User user2 = new User
            {
                Name = "yali",
                Email = "yalicohen6",
                Id = "333987654"
            };
            users_list.Add(user2);
            foreach (User us in users_list)
            {
                Console.WriteLine(us.Name);
            }
        }
    }
}
