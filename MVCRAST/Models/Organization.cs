using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class Organization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizationID { get; set; }
        public string OrgName { get; set; }
        public string OrgSymbol { get; set; }

       // public virtual ICollection<Users> Users { get; set; }
       //Foreign key
       public int UserID { get; set; }
       public virtual User Users { get; set; }
    }
}