using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public enum  Categorization
    {
        Low, Medium, High
    }
    public class Systems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SystemsID { get; set; }
        public string SystemName { get; set; }
        public Categorization? Confidentiality { get; set; }
        public Categorization? Integrity { get; set; }
        public Categorization? Availability { get; set; }
        public DateTime AssessmentStartDate { get; set; }
        public DateTime AssessmentEndDate { get; set; }
        public int AssessmentPriority { get; set; }
        //Foreign key
        public int UserID { get; set; }
        public virtual User User { get; set; }
        //public virtual ICollection<SystemControl> SystemControls { get; set;}
        // needs an objectID with this class
        //Foreign key
        //public int SystemControlID { get; set; }
        //public virtual SystemControl SystemControls { get; set; }
        //Foreign key
        public int SAPID { get; set; }
        public virtual SAP SAP { get; set; }
        //Foreign key
        public int POAMID { get; set; }
        public virtual POAM POAM { get; set; }
       

    }
}