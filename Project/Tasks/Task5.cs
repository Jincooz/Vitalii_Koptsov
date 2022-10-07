using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task5
    {
        public static string DealWithFriendList(string friendList)
        {
            string[] friendsNames = friendList.Split(';');
            List<Friend> friends = new List<Friend>();
            foreach (string friendNames in friendsNames)
            {
                string[] names = friendNames.Split(':');
                try
                {
                    friends.Add(new Friend()
                    {
                        FirstName = names[0],
                        LastName = names[1]
                    });
                }
                catch (Exception)
                {
                    throw new Exception("Friend list have unsupported format");
                }                    

            }
            var resultList = friends.OrderBy(friend => friend.LastName)
                                    .ThenBy(friend => friend.FirstName)
                                    .Select(friend => friend.ToString());
            return String.Join("" , resultList);
        }
    }
    internal class Friend
    {
        private string _firstName = "";
        private string _lastName = "";
        public string FirstName { get => _firstName; set => _firstName = value.ToUpper(); }
        public string LastName { get => _lastName; set => _lastName = value.ToUpper(); }
        public override string ToString() 
        {
            return $"({LastName}, {FirstName})";
        }
    }
}
