using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationDemo.Models
{
    public class UserRepository : IDisposable
    {
        private static List<UserDetails> usersTable;
        private static List<string> rolesTable;

        static UserRepository()
        {
            usersTable = new List<UserDetails>();
            rolesTable = new List<string>();
        }

        public UserDetails GetUserByName(string userName, string passWord)
        {
            UserDetails user = usersTable.SingleOrDefault(u => u.UserName == userName && u.Password == passWord);
            return user;
        }

        public UserDetails GetUserByName(string userName)
        {
            UserDetails user = usersTable.SingleOrDefault(u => u.UserName == userName);
            return user;
        }

        public IEnumerable<UserDetails> GetAllUsers()
        {
            return usersTable.AsEnumerable();
        }

        public int RegisterUser(UserDetails user)
        {
            UserDetails newUser = new UserDetails();
            newUser.UserName = user.UserName;
            newUser.Password = user.Password;
            newUser.UserEmailAddress = user.UserEmailAddress;

            usersTable.Add(newUser);

            return newUser.UserID;
        }

        public void AddRole(string name)
        {
            rolesTable.Add(name);
        }

        public  string[] GetAllRoles()
        {
            return rolesTable.ToArray();
        }

        public void Dispose()
        {
            
        }
    }
}