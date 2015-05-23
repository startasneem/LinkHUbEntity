using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class UrLBs
    {
        private UrLdb aUrLdb;

        public UrLBs()
        {
            aUrLdb=new UrLdb();
        }

        public IEnumerable<tbl_Url> GetUrls()
        {
            return aUrLdb.GetUrls();
        }

        public tbl_Url GetById(int id)
        {
            return aUrLdb.GetById(id);
        }

        public void Insert(tbl_Url url)
        {
            aUrLdb.Insert(url);
        }

        public void Delete(int id)
        {
            aUrLdb.Delete(id);
        }

        public void Update(tbl_Url url)
        {
            aUrLdb.Update(url);
        }


    }
}
