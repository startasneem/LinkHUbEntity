using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBs
    {
        public Categorybs Categorybs { get; set; }
        public UserBs UserBs { get; set; }
        public UrLBs UrLBs { get; set; }

        public BaseBs()
        {
            Categorybs = new Categorybs();
            UserBs = new UserBs();
            UrLBs = new UrLBs();
        }
    }
}
