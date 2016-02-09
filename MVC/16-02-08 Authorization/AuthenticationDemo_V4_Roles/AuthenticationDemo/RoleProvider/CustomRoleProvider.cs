using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using AuthenticationDemo.Models;

namespace AuthenticationDemo
{
    public class CustomRoleProvider : RoleProvider
    {
        public override bool IsUserInRole(string username, string roleName)
        {
            using (var usersContext = new UserRepository())
            {
                var user = usersContext.GetAllUsers().SingleOrDefault(u => u.UserName == username);
                if (user == null)
                    return false;
                //return user.UserRoles != null && user.UserRoles.Select(
                //     u => u.Role).Any(r => r.RoleName == roleName);
                return user.UserRoles != null && user.UserRoles.Contains(roleName);
            }
        }

        public override string[] GetRolesForUser(string username)
        {
            using (var usersContext = new UserRepository())
            {
                var user = usersContext.GetAllUsers().SingleOrDefault(u => u.UserName == username);
                if (user == null)
                    return new string[] { };
                return user.UserRoles == null ? new string[] { } : user.UserRoles.ToArray();
                  // .Select(u => u.Role).Select(u => u.RoleName).ToArray();
            }
        }

        // -- Snip --

        public override string[] GetAllRoles()
        {
            using (var usersContext = new UserRepository())
            {
                // return usersContext.Roles.Select(r => r.RoleName).ToArray();
                return usersContext.GetAllRoles();
            }
        }

        // -- Snip --

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            var usersContext = new UserRepository();
            foreach (string username in usernames)
            {
                UserDetails userDetails = usersContext.GetUserByName(username);
                foreach (string role in roleNames)
                {
                    if (usersContext.GetAllRoles().Contains(role))
                        userDetails.UserRoles.Add(role);

                }
            }
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            var usersContext = new UserRepository();
            usersContext.AddRole(roleName);
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}