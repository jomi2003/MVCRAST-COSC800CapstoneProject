using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MVCRAST.Models
{
    public enum Status
    {
        Ongoing, Completed
    }
    public class POAMItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int POAMItemID { get; set; }
        public string WeaknessType { get; set; }
        public DateTime TargetDate { get; set; }
        Categorization? RiskLevel { get; set; }
       // public virtual ICollection<SystemControl> SystemControl { get; set; }
       //Foreign key
        public virtual int ControlID { get; set; }
        public virtual Controls Controls { get; set; }
        //Foreign key
        public  int SystemID { get; set; }
        public virtual Systems Systems { get; set; }
        public string Responsible { get; set; }
        public decimal FundingResource { get; set; }
        public DateTime SchedCompletionDate { get; set; }
        public string Milestone { get; set; }
        public string SourceOfWeakness { get; set; }
        Status? POAMStatus { get; set; }
        public string Comments { get; set;}
        //Foreign key
       // public int POAMID { get; set; }
       // public virtual POAM POAM { get; set; }

        //Foreign key
        
        //public int SystemControlID { get; set; } 
       // public virtual SystemControl SystemControl { get; set;} 


    }
}