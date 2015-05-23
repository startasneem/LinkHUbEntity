using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class UserDB
    {
        private LinkHubDbEntities aEntities;

        public UserDB()
        {
            aEntities=new LinkHubDbEntities();
        }

        public IEnumerable<tbl_User> GetAllUsers()
        {
            return aEntities.tbl_User.ToList();
        }

        public tbl_User GetById(int id)
        {
            return aEntities.tbl_User.Find(id);
        }

        public void Insert(tbl_User user)
        {
            aEntities.tbl_User.Add(user);
            Save();
        }

        public void Save()
        {
            aEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            tbl_User user = aEntities.tbl_User.Find(id);
            aEntities.tbl_User.Remove(user);
            Save();
        }

        public void Update(tbl_User user)
        {
            aEntities.Entry(user).State = EntityState.Modified;
            
        }
    }
}
