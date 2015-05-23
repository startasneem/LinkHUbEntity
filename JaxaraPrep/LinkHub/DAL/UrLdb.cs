using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class UrLdb
    {
        private LinkHubDbEntities aEntities;

        public UrLdb()
        {
            aEntities=new LinkHubDbEntities();
        }

        public IEnumerable<tbl_Url> GetUrls()
        {
            return aEntities.tbl_Url.ToList();
        }

        public tbl_Url GetById(int id)
        {
            return aEntities.tbl_Url.Find(id);
        }

        public void Insert(tbl_Url url)
        {
            aEntities.tbl_Url.Add(url);
            Save();
        }

        public void Save()
        {
            aEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            tbl_Url aUrl = aEntities.tbl_Url.Find(id);
            aEntities.tbl_Url.Remove(aUrl);
            Save();
        }

        public void Update(tbl_Url url)
        {
            aEntities.Entry(url).State=EntityState.Modified;
            
        }


    }
}
