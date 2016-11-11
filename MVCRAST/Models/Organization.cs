using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class Organization
    {
        public int ID { get; set; }
        public string OrgName { get; set; }
        public string OrgSymbol { get; set; }
        public virtual List<Users> Users { get; set; }

    }
}