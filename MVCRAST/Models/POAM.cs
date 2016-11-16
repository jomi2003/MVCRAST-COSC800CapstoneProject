using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class POAM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int POAMID { get; set; }
        //public int SystemsID { get; set; }
        public DateTime LastUpdated { get; set; }
        public string AuthorizationStatus { get; set; } //ATO
       // public virtual Systems System { get; set; }
      //  public virtual ICollection <POAMItem>POAMItem { get; set; }
        //Foreign key
        public int POAMItemID { get; set; }
        public virtual POAMItem POAMItem { get; set; }
    }
}