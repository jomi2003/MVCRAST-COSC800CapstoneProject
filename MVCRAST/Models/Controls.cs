using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class Controls
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ControlID { get; set; }
        public string ControlName { get; set; }
        //Foreign key
        public int FamilyControlID { get; set; }
        public virtual FamilyControl FamilyControl { get; set; } 
        //public virtual ICollection< SystemControl> SystemControl { get; set; }
        //Foreign key
        //public int SystemControlID { get; set; }
        //public virtual SystemControl SystemControl { get; set; }
    }
}