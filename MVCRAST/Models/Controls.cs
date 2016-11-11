using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class Controls
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ControlID { get; set; }
        public string ControlName { get; set; }
        public virtual FamilyControl FamilyControl { get; set; } 
        public virtual ICollection< SystemControl> SystemControl { get; set; }
    }
}