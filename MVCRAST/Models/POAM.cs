using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum Status
    {
        Ongoing, Completed
    }
    public class POAM
    {
        public int ID { get; set; }
        public string WeaknessType { get; set; }
        public DateTime TargetDate { get; set; }
        Categorization? RiskLevel { get; set; }
        public virtual ICollection<SystemControl> SystemControl { get; set; }
        public virtual int ControlID { get; set; }
        public virtual int SystemID { get; set; }
        public string Responsible { get; set; }
        public decimal FundingResource { get; set; }
        public DateTime SchedCompletionDate { get; set; }
        public string Milestone { get; set; }
        public string SourceOfWeakness { get; set; }
        Status? POAMStatus { get; set; }
        public string Comments { get; set;}
       

    }
}