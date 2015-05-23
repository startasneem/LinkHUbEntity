using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class CategoryDB
    {
        private LinkHubDbEntities aEntities;

        public CategoryDB()
        {
            aEntities = new LinkHubDbEntities();
        }

        public IEnumerable<tbl_Category> GetAllCategories()
        {
            return aEntities.tbl_Category.ToList();
        }

        public tbl_Category GetById(int id)
        {
            return aEntities.tbl_Category.Find(id);
        }

        public void Insert(tbl_Category aCategory)
        {
            aEntities.tbl_Category.Add(aCategory);
            save();
        }

        private void save()
        {
            aEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            tbl_Category aCategory = aEntities.tbl_Category.Find(id);
            aEntities.tbl_Category.Remove(aCategory);
            save();
        }

        public void Update(tbl_Category aCategory)
        {
            aEntities.Entry(aCategory).State = EntityState.Modified;
            
        }
    }
}
