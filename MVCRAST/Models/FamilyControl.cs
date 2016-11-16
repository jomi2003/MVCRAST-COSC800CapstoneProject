using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class FamilyControl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FamilyControlID { get; set; }
        public string FamilyName { get; set; }
        public string FamilyDescription { get; set; }
        //public virtual ICollection<Control> Controls { get; set;}
        //Foreign key
        //public int ControlID { get; set;}
        //public virtual Controls Controls { get; set; }

    }
}