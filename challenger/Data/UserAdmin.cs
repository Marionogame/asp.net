using challenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenger.Data
{
    public class UserAdmin
    {
        public User GetData(string name, string password) {
            using (normal34dbEntities context = new normal34dbEntities()) {

                var userData = context.User
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Username == name && u.PaswordHash == password);

                return userData;

            }
        }
    }
}