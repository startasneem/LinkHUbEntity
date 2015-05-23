using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class Categorybs
    {
        private CategoryDB aCategoryDb;

        public Categorybs()
        {
            aCategoryDb=new CategoryDB();
        }

        public IEnumerable<tbl_Category> GetCategories()
        {
             return aCategoryDb.GetAllCategories();
        }

        public tbl_Category GetById(int id)
        {
            return aCategoryDb.GetById(id);
        }

        public void Insert(tbl_Category aCategory)
        {
            aCategoryDb.Insert(aCategory);
        }

        public void Delete(int id)
        {
            aCategoryDb.Delete(id);
        }

        public void Update(tbl_Category aCategory)
        {
            aCategoryDb.Update(aCategory);
        }
    }
}
