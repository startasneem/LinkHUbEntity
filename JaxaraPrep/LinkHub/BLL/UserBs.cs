using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class UserBs
    {
        private UserDB aDb;
        
        public UserBs()
        {
            aDb=new UserDB();
        }
        public IEnumerable<tbl_User> GetAllUsers()
        {
            return aDb.GetAllUsers();
        }

        public tbl_User GetById(int id)
        {
            return aDb.GetById(id);
        }

        public void Insert(tbl_User user)
        {
            aDb.Insert(user);
        }

        public void Delete(int id)
        {
            aDb.Delete(id);
        }

        public void Update(tbl_User user)
        {
            aDb.Update(user);
        }

    }
}
