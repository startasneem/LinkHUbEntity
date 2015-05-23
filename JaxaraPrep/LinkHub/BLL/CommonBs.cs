using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BOL;

namespace BLL
{
    public class CommonBs:BaseBs
    {
        public void InsertQuickUrls(QuickSubmit aSubmit)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    tbl_User u = aSubmit.aUser;
                    u.Password = u.Confirmpassword = "123";
                    u.Role = "U";
                    UserBs.Insert(u);

                    tbl_Url url = aSubmit.aUrl;
                    url.u_id = u.Id;
                    url.IsApproved = "P";
                    url.urlDesc = url.Title;
                    UrLBs.Insert(url);
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    
                   throw new Exception(ex.Message);
                }
                
            }

        }
    }

   


}
